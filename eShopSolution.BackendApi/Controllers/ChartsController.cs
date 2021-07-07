using eShopSolution.Application.Carts;
using eShopSolution.ViewModels.Common;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShopSolution.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChartsController : ControllerBase
    {
   
        private readonly ICartService _cartService;

        public ChartsController(ICartService cartService)
        {
            _cartService = cartService;
        }
        [HttpGet("paging")]
        public async Task<IActionResult> Get([FromQuery] PagingRequestBase request)
        {
            var result = await _cartService.Get(request);
            return Ok(result);
        }
        
    }
}
