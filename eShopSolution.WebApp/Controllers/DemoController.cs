using eShopSolution.Data.EF;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace eShopSolution.WebApp.Controllers
{

    public class DemoController : Controller
    {
        private readonly EShopDbContext _context;
        public DemoController(EShopDbContext context)
        {
            _context = context;
        }
        
        public IActionResult Index()
        {
            return View();
        }
    }
}
