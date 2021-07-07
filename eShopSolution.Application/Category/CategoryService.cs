using eShopSolution.Data.EF;
using eShopSolution.ViewModels.Category;
using eShopSolution.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace eShopSolution.Application.Category
{
    //public class CategoryService : ICategoryService
    //{
    //    private readonly EShopDbContext _context;

    //    public CategoryService(EShopDbContext context)
    //    {
    //        _context = context;
    //    }

    //    //public async Task<ApiResult<PagedResult<CategoryVm1>>> GetCategory(GetCategoryPagingRequest request)
    //    //{
    //        //var query = _context.CategoryTranslations;
    //        //if (!string.IsNullOrEmpty(request.Keyword))
    //        //{
    //        //    query = query.Where(x => x.Name.Contains(request.Keyword));
    //        //}

    //        ////3. Paging
    //        //int totalRow = await query.CountAsync();

    //        //var data = await query.Skip((request.PageIndex - 1) * request.PageSize)
    //        //    .Take(request.PageSize)
    //        //    .Select(x => new UserVm()
    //        //    {
    //        //        Email = x.Email,
    //        //        PhoneNumber = x.PhoneNumber,
    //        //        UserName = x.UserName,
    //        //        FirstName = x.FirstName,
    //        //        Id = x.Id,
    //        //        LastName = x.LastName
    //        //    }).ToListAsync();

    //        ////4. Select and projection
    //        //var pagedResult = new PagedResult<UserVm>()
    //        //{
    //        //    TotalRecords = totalRow,
    //        //    PageIndex = request.PageIndex,
    //        //    PageSize = request.PageSize,
    //        //    Items = data
    //        //};
    //        //return new ApiSuccessResult<PagedResult<UserVm>>(pagedResult);
    //    //}
    //}
}
