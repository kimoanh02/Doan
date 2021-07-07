using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eShopSolution.ViewModels.Catalog.Products
{
    public class ProductCreateRequest
    {
        [Required(ErrorMessage = "Bạn phải nhập giá sản phẩm")]

        public decimal Price { set; get; }
        [Required(ErrorMessage = "Bạn phải nhập giá gốc sản phẩm")]

        public decimal OriginalPrice { set; get; }
        [Required(ErrorMessage = "Bạn phải số lượng tồn sản phẩm")]

        public int Stock { set; get; }

        [Required(ErrorMessage = "Bạn phải nhập tên sản phẩm")]
        public string Name { set; get; }

        [Required(ErrorMessage = "Bạn phải nhập mô tả sản phẩm")]

        public string Description { set; get; }
        [Required(ErrorMessage = "Bạn phải nhập chi tiết sản phẩm")]

        public string Details { set; get; }
        [Required(ErrorMessage = "Bạn phải nhập mô tả sản phẩm")]

        public string SeoDescription { set; get; }
        [Required(ErrorMessage = "Bạn phải nhập tiêu đề sản phẩm")]

        public string SeoTitle { set; get; }
        [Required(ErrorMessage = "Bạn phải nhập tiêu đề sản phẩm")]


        public string SeoAlias { get; set; }

        public string LanguageId { set; get; }

        public bool? IsFeatured { get; set; }
        [Required(ErrorMessage = "Bạn phải ảnh tên sản phẩm")]

        public IFormFile ThumbnailImage { get; set; }
    }
}