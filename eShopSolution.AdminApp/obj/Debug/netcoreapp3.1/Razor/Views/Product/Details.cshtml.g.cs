#pragma checksum "C:\Users\Oanh\Documents\baitap\eShopSolution-develop\eShopSolution.AdminApp\Views\Product\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb5c49d82a3178d74c206743589992793ec31c04"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Details), @"mvc.1.0.view", @"/Views/Product/Details.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Oanh\Documents\baitap\eShopSolution-develop\eShopSolution.AdminApp\Views\_ViewImports.cshtml"
using eShopSolution.AdminApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Oanh\Documents\baitap\eShopSolution-develop\eShopSolution.AdminApp\Views\_ViewImports.cshtml"
using eShopSolution.AdminApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb5c49d82a3178d74c206743589992793ec31c04", @"/Views/Product/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca35779156182fbbd70c23158559b9e62f992e10", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<eShopSolution.ViewModels.Catalog.Products.ProductVm>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Oanh\Documents\baitap\eShopSolution-develop\eShopSolution.AdminApp\Views\Product\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""container-fluid"">
        <h1 class=""mt-4"">Chi tiết </h1>
        <ol class=""breadcrumb mb-4"">
            <li class=""breadcrumb-item""><a href=""/"">Trang chủ</a></li>
            <li class=""breadcrumb-item active"">Chi tiết sản phẩm</li>
        </ol>
        <div class=""card mb-4"">
            <div class=""card-header"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb5c49d82a3178d74c206743589992793ec31c044861", async() => {
                WriteLiteral("Về danh sách");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"card-body\">\r\n                <div class=\"col-md-12\">\r\n                    <dl class=\"row\">\r\n                        <dt class=\"col-sm-2\">\r\n                            ");
#nullable restore
#line 23 "C:\Users\Oanh\Documents\baitap\eShopSolution-develop\eShopSolution.AdminApp\Views\Product\Details.cshtml"
                       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dt>\r\n                        <dd class=\"col-sm-10\">\r\n                            ");
#nullable restore
#line 26 "C:\Users\Oanh\Documents\baitap\eShopSolution-develop\eShopSolution.AdminApp\Views\Product\Details.cshtml"
                       Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-2\">\r\n                            ");
#nullable restore
#line 29 "C:\Users\Oanh\Documents\baitap\eShopSolution-develop\eShopSolution.AdminApp\Views\Product\Details.cshtml"
                       Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dt>\r\n                        <dd class=\"col-sm-10\">\r\n                            ");
#nullable restore
#line 32 "C:\Users\Oanh\Documents\baitap\eShopSolution-develop\eShopSolution.AdminApp\Views\Product\Details.cshtml"
                       Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-2\">\r\n                            ");
#nullable restore
#line 35 "C:\Users\Oanh\Documents\baitap\eShopSolution-develop\eShopSolution.AdminApp\Views\Product\Details.cshtml"
                       Write(Html.DisplayNameFor(model => model.OriginalPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dt>\r\n                        <dd class=\"col-sm-10\">\r\n                            ");
#nullable restore
#line 38 "C:\Users\Oanh\Documents\baitap\eShopSolution-develop\eShopSolution.AdminApp\Views\Product\Details.cshtml"
                       Write(Html.DisplayFor(model => model.OriginalPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-2\">\r\n                            ");
#nullable restore
#line 41 "C:\Users\Oanh\Documents\baitap\eShopSolution-develop\eShopSolution.AdminApp\Views\Product\Details.cshtml"
                       Write(Html.DisplayNameFor(model => model.Stock));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dt>\r\n                        <dd class=\"col-sm-10\">\r\n                            ");
#nullable restore
#line 44 "C:\Users\Oanh\Documents\baitap\eShopSolution-develop\eShopSolution.AdminApp\Views\Product\Details.cshtml"
                       Write(Html.DisplayFor(model => model.Stock));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-2\">\r\n                            ");
#nullable restore
#line 47 "C:\Users\Oanh\Documents\baitap\eShopSolution-develop\eShopSolution.AdminApp\Views\Product\Details.cshtml"
                       Write(Html.DisplayNameFor(model => model.ViewCount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dt>\r\n                        <dd class=\"col-sm-10\">\r\n                            ");
#nullable restore
#line 50 "C:\Users\Oanh\Documents\baitap\eShopSolution-develop\eShopSolution.AdminApp\Views\Product\Details.cshtml"
                       Write(Html.DisplayFor(model => model.ViewCount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-2\">\r\n                            ");
#nullable restore
#line 53 "C:\Users\Oanh\Documents\baitap\eShopSolution-develop\eShopSolution.AdminApp\Views\Product\Details.cshtml"
                       Write(Html.DisplayNameFor(model => model.DateCreated));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dt>\r\n                        <dd class=\"col-sm-10\">\r\n                            ");
#nullable restore
#line 56 "C:\Users\Oanh\Documents\baitap\eShopSolution-develop\eShopSolution.AdminApp\Views\Product\Details.cshtml"
                       Write(Html.DisplayFor(model => model.DateCreated));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-2\">\r\n                            ");
#nullable restore
#line 59 "C:\Users\Oanh\Documents\baitap\eShopSolution-develop\eShopSolution.AdminApp\Views\Product\Details.cshtml"
                       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dt>\r\n                        <dd class=\"col-sm-10\">\r\n                            ");
#nullable restore
#line 62 "C:\Users\Oanh\Documents\baitap\eShopSolution-develop\eShopSolution.AdminApp\Views\Product\Details.cshtml"
                       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-2\">\r\n                            ");
#nullable restore
#line 65 "C:\Users\Oanh\Documents\baitap\eShopSolution-develop\eShopSolution.AdminApp\Views\Product\Details.cshtml"
                       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dt>\r\n                        <dd class=\"col-sm-10\">\r\n                            ");
#nullable restore
#line 68 "C:\Users\Oanh\Documents\baitap\eShopSolution-develop\eShopSolution.AdminApp\Views\Product\Details.cshtml"
                       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-2\">\r\n                            ");
#nullable restore
#line 71 "C:\Users\Oanh\Documents\baitap\eShopSolution-develop\eShopSolution.AdminApp\Views\Product\Details.cshtml"
                       Write(Html.DisplayNameFor(model => model.Details));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dt>\r\n                        <dd class=\"col-sm-10\">\r\n                            ");
#nullable restore
#line 74 "C:\Users\Oanh\Documents\baitap\eShopSolution-develop\eShopSolution.AdminApp\Views\Product\Details.cshtml"
                       Write(Html.Raw(Model.Details));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-2\">\r\n                            ");
#nullable restore
#line 77 "C:\Users\Oanh\Documents\baitap\eShopSolution-develop\eShopSolution.AdminApp\Views\Product\Details.cshtml"
                       Write(Html.DisplayNameFor(model => model.SeoDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dt>\r\n                        <dd class=\"col-sm-10\">\r\n                            ");
#nullable restore
#line 80 "C:\Users\Oanh\Documents\baitap\eShopSolution-develop\eShopSolution.AdminApp\Views\Product\Details.cshtml"
                       Write(Html.DisplayFor(model => model.SeoDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-2\">\r\n                            ");
#nullable restore
#line 83 "C:\Users\Oanh\Documents\baitap\eShopSolution-develop\eShopSolution.AdminApp\Views\Product\Details.cshtml"
                       Write(Html.DisplayNameFor(model => model.SeoTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dt>\r\n                        <dd class=\"col-sm-10\">\r\n                            ");
#nullable restore
#line 86 "C:\Users\Oanh\Documents\baitap\eShopSolution-develop\eShopSolution.AdminApp\Views\Product\Details.cshtml"
                       Write(Html.DisplayFor(model => model.SeoTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-2\">\r\n                            ");
#nullable restore
#line 89 "C:\Users\Oanh\Documents\baitap\eShopSolution-develop\eShopSolution.AdminApp\Views\Product\Details.cshtml"
                       Write(Html.DisplayNameFor(model => model.SeoAlias));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dt>\r\n                        <dd class=\"col-sm-10\">\r\n                            ");
#nullable restore
#line 92 "C:\Users\Oanh\Documents\baitap\eShopSolution-develop\eShopSolution.AdminApp\Views\Product\Details.cshtml"
                       Write(Html.DisplayFor(model => model.SeoAlias));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-2\">\r\n                            ");
#nullable restore
#line 95 "C:\Users\Oanh\Documents\baitap\eShopSolution-develop\eShopSolution.AdminApp\Views\Product\Details.cshtml"
                       Write(Html.DisplayNameFor(model => model.ThumbnailImage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dt>\r\n                        <dd class=\"col-sm-10\">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 4674, "\"", 4734, 1);
#nullable restore
#line 98 "C:\Users\Oanh\Documents\baitap\eShopSolution-develop\eShopSolution.AdminApp\Views\Product\Details.cshtml"
WriteAttributeValue("", 4680, Configuration["BaseAddress"] + Model.ThumbnailImage, 4680, 54, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:200px !important; height: 200px !important\" />\r\n\r\n                        </dd>\r\n                    </dl>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.Extensions.Configuration.IConfiguration Configuration { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<eShopSolution.ViewModels.Catalog.Products.ProductVm> Html { get; private set; }
    }
}
#pragma warning restore 1591
