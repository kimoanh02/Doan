using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eShopSolution.ViewModels.Cart
{
    public class Statistical
    {
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public decimal Revenues { get; set; }
        public decimal Benefit { get; set; }
    }
}
