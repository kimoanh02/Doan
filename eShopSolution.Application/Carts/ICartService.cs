using eShopSolution.ViewModels.Cart;
using eShopSolution.ViewModels.Catalog.Products;
using eShopSolution.ViewModels.Common;
using eShopSolution.ViewModels.Sales;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Application.Carts
{
    public interface ICartService
    {
        Task<ApiResult<PagedResult<CartVm>>> GetCartPaging(GetCartPagingRequest request);
        Task<int> Delete(int id);
        Task<ApiResult<CartDetailRequest>> GetById(int id);
        Task<ApiResult<PagedResult<Statistical>>> Get(PagingRequestBase request);
    }
}
