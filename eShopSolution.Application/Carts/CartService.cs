using eShopSolution.Data.EF;
using eShopSolution.Data.Entities;
using eShopSolution.Utilities.Exceptions;
using eShopSolution.ViewModels.Cart;
using eShopSolution.ViewModels.Catalog.Products;
using eShopSolution.ViewModels.Common;
using eShopSolution.ViewModels.Sales;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace eShopSolution.Application.Carts
{
    public class CartService : ICartService
    {
        private readonly EShopDbContext _context;

        public CartService(EShopDbContext context)
        {
            _context = context;
        }

        public async Task<int> Delete(int id)
        {

            var cart = await _context.Orders.FindAsync(id);
            if (cart == null) throw new EShopException($"Cannot find a product: {id}");

            _context.Orders.Remove(cart);

            return await _context.SaveChangesAsync();
        }

        public async Task<ApiResult<PagedResult<Statistical>>> Get(PagingRequestBase request)
        {
            //1. Select join
            var query = from p in _context.Products
                        join od in _context.OrderDetails on p.Id equals od.ProductId
                        join o in _context.Orders on od.OrderId equals o.Id
                        
                        select new { p, od, o };



            var data = await query.Skip((request.PageIndex - 1) * request.PageSize).GroupBy(x => x.o.OrderDate)
                .Select(g => new Statistical()
                {
                    Date = g.Key,
                    Revenues = g.Sum(x => ((x.od.Quantity) * (x.p.Price))),
                    Benefit= g.Sum(x=>(((x.od.Quantity) * (x.p.Price))- ((x.od.Quantity) * (x.p.OriginalPrice))))

                }).ToListAsync();

            int totalRow = await query.CountAsync();

            

            //4. Select and projection
            var pagedResult = new PagedResult<Statistical>()
            {
                TotalRecords = totalRow,
                PageIndex = request.PageIndex,
                PageSize = request.PageSize,
                Items = data
            };

            return new ApiSuccessResult<PagedResult<Statistical>>(pagedResult);
        }

        public async Task<ApiResult<CartDetailRequest>> GetById(int id)
        {

            var user = await _context.OrderDetails.FindAsync(id);
            if (user == null)
            {
                return new ApiErrorResult<CartDetailRequest>("Sản phẩm không tồn tại");
            }
            //var roles = await _context.OrderDetails.(user);
            //var userVm = new UserVm()
            //{
            //    Email = user.Email,
            //    PhoneNumber = user.PhoneNumber,
            //    FirstName = user.FirstName,
            //    Dob = user.Dob,
            //    Id = user.Id,
            //    LastName = user.LastName,
            //    UserName = user.UserName,
            //    Roles = roles
            //};
            return new ApiSuccessResult<CartDetailRequest>();
        }

        public async Task<ApiResult<PagedResult<CartVm>>> GetCartPaging(GetCartPagingRequest request)
        {

            var query = from O in _context.Orders
                        select new { O };
            if (!string.IsNullOrEmpty(request.Keyword))
            {
                query = query.Where(x => x.O.ShipAddress.Contains(request.Keyword)
                 || x.O.ShipName.Contains(request.Keyword) || x.O.ShipPhoneNumber.Contains(request.Keyword) );
            }

            //3. Paging
            int totalRow = await query.CountAsync();

            var data = await query.Skip((request.PageIndex - 1) * request.PageSize)
                .Take(request.PageSize)
                .Select(x => new CartVm()
                {
                    Id=x.O.Id,
                    ShipName= x.O.ShipName,
                    ShipAddress= x.O.ShipAddress,
                    ShipEmail= x.O.ShipEmail,
                    ShipPhoneNumber= x.O.ShipPhoneNumber,
                    OrderDate= x.O.OrderDate
                }).ToListAsync();

            //4. Select and projection
            var pagedResult = new PagedResult<CartVm>()
            {
                TotalRecords = totalRow,
                PageIndex = request.PageIndex,
                PageSize = request.PageSize,
                Items = data
            };
            return new ApiSuccessResult<PagedResult<CartVm>>(pagedResult);
        }
    }
}
