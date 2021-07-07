using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.ViewModels.Cart
{
   public class CartDetailRequest
    {
        public int ProductId { set; get; }
        public int Quantity { set; get; }
        public decimal Price { set; get; }

    }
}
