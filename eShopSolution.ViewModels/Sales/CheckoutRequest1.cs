using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.ViewModels.Sales
{
    public class CheckoutRequest1
    {
        public int id { get; set; }
        public Guid UserId { get; set; }
        public string Name { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }
        public DateTime OrderDate { get; set; }

        public int ProductId { get; set; }

        public int Quantity { get; set; }


    }
}
