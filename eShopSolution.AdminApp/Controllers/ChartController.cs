using eShopSolution.ApiIntegration;
using eShopSolution.ViewModels.Common;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShopSolution.AdminApp.Controllers
{
    public class ChartController : Controller
    {
        private readonly IChartApiClient _chartApiClient;
        public ChartController(IChartApiClient chartApiClient)
        {
            _chartApiClient = chartApiClient;
        }
        public async Task<IActionResult> Index(int pageIndex = 1, int pageSize = 5)
        
        {
            var request = new PagingRequestBase()
            {
                PageIndex = pageIndex,
                PageSize = pageSize
            };
            var data = await _chartApiClient.Get(request);
            
            return View(data.ResultObj);
        }

        [HttpGet]
        public IActionResult sevenStatis()
        {
            return View();
        }
    }
}
