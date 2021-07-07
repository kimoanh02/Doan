
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace eShopSolution.AdminApp.Controllers
{
    public class DemoController : Controller
    {

        public IActionResult Export()
        { 
                var data = "Hello";
                var stream = new MemoryStream();
                using (var package = new ExcelPackage(stream))
                {
                    var sheet = package.Workbook.Worksheets.Add("Loai");
                    //đổ dữ liệu vào sheet
                    sheet.Cells.LoadFromCollection(data, true);
                    //Save
                    package.Save();
                }
                stream.Position = 0;
                var filename = $"Loai_{DateTime.Now.ToString("yyyyMMddHHmmss")}.xlsx";
                return File(stream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", filename);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
