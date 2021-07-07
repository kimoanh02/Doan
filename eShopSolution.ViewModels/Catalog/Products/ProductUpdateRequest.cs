using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eShopSolution.ViewModels.Catalog.Products
{
    public class ProductUpdateRequest
    {
        public int Id { get; set; }
        public string Name { set; get; }
        public string Description { set; get; }
        [Required(ErrorMessage = "Bạn phải nhập chi tiết sản phẩm")]
        public string Details { set; get; }
        public string SeoDescription { set; get; }
        [Required(ErrorMessage = "Bạn phải nhập title")]
        public string SeoTitle { set; get; }
        [Required(ErrorMessage = "Bạn phải nhập mô tả")]
        public string SeoAlias { get; set; }

        public string LanguageId { set; get; }

        public bool? IsFeatured { get; set; }
        [Required(ErrorMessage = "Bạn phải nhập ảnh sản phẩm")]
        public IFormFile ThumbnailImage { get; set; }
    }
}