using eShopSolution.ViewModels.Cart;
using eShopSolution.ViewModels.Common;
using eShopSolution.ViewModels.Sales;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.ApiIntegration
{
    public interface ICartApiClient 
    {
        Task<ApiResult<PagedResult<CartVm>>> GetCartPaging(GetCartPagingRequest request);
        Task<bool> DeleteCart(int id);
        
    }
}
