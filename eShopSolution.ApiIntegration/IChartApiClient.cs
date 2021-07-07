using eShopSolution.ViewModels.Cart;
using eShopSolution.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.ApiIntegration
{
    public interface IChartApiClient
    {
        Task<ApiResult<PagedResult<Statistical>>> Get(PagingRequestBase request);
    }
}
