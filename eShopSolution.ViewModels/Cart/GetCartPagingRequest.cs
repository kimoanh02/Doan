using eShopSolution.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.ViewModels.Cart
{
    public class GetCartPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }
    }
}
