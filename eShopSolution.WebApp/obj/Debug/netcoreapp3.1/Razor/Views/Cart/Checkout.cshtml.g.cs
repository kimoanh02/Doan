#pragma checksum "C:\Users\Oanh\Documents\baitap\eShopSolution-develop\eShopSolution.WebApp\Views\Cart\Checkout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e28b97576bd84e7c227951af7dd872ce7aad7602"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Checkout), @"mvc.1.0.view", @"/Views/Cart/Checkout.cshtml")]
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
#line 1 "C:\Users\Oanh\Documents\baitap\eShopSolution-develop\eShopSolution.WebApp\Views\_ViewImports.cshtml"
using eShopSolution.WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Oanh\Documents\baitap\eShopSolution-develop\eShopSolution.WebApp\Views\_ViewImports.cshtml"
using eShopSolution.WebApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Oanh\Documents\baitap\eShopSolution-develop\eShopSolution.WebApp\Views\_ViewImports.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e28b97576bd84e7c227951af7dd872ce7aad7602", @"/Views/Cart/Checkout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee06ad07f2f53f131a1de1d20dd4b74c4f42f338", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Checkout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CheckoutViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("inputCountry"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "V??nh Ph??c", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "hong@gmail.com", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Email"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0987667892", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("PhoneNumber"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Oanh\Documents\baitap\eShopSolution-develop\eShopSolution.WebApp\Views\Cart\Checkout.cshtml"
  
    ViewData["Title"] = "Checkout";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Oanh\Documents\baitap\eShopSolution-develop\eShopSolution.WebApp\Views\Cart\Checkout.cshtml"
  
    var culture = CultureInfo.CurrentCulture.Name;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n<ul class=\"breadcrumb\">\n    <li><a href=\"/\">Trang ch???</a> <span class=\"divider\">/</span></li>\n    <li class=\"active\"> Gi??? h??ng</li>\n</ul>\n<h3>\n    Gi??? h??ng c?? [ <small>");
#nullable restore
#line 17 "C:\Users\Oanh\Documents\baitap\eShopSolution-develop\eShopSolution.WebApp\Views\Cart\Checkout.cshtml"
                    Write(Model.CartItems.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(" s???n ph???m </small>]\n</h3>\n<hr class=\"soft\" />\n");
#nullable restore
#line 20 "C:\Users\Oanh\Documents\baitap\eShopSolution-develop\eShopSolution.WebApp\Views\Cart\Checkout.cshtml"
 if (TempData["SuccessMsg"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <span class=\"alert alert-success\">");
#nullable restore
#line 22 "C:\Users\Oanh\Documents\baitap\eShopSolution-develop\eShopSolution.WebApp\Views\Cart\Checkout.cshtml"
                                 Write(TempData["SuccessMsg"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n");
#nullable restore
#line 23 "C:\Users\Oanh\Documents\baitap\eShopSolution-develop\eShopSolution.WebApp\Views\Cart\Checkout.cshtml"
}
else
{


#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table class=""table table-bordered"">
        <thead>
            <tr>
                <th>Product</th>
                <th>Description</th>
                <th>Quantity</th>
                <th>Price</th>
                <th>Total</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 38 "C:\Users\Oanh\Documents\baitap\eShopSolution-develop\eShopSolution.WebApp\Views\Cart\Checkout.cshtml"
             foreach (var item in Model.CartItems)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                    <td> <img width=\"60\"");
            BeginWriteAttribute("src", " src=\"", 1014, "\"", 1064, 1);
#nullable restore
#line 41 "C:\Users\Oanh\Documents\baitap\eShopSolution-develop\eShopSolution.WebApp\Views\Cart\Checkout.cshtml"
WriteAttributeValue("", 1020, Configuration["BaseAddress"] + item.Image, 1020, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1065, "\"", 1071, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\n                    <td>");
#nullable restore
#line 42 "C:\Users\Oanh\Documents\baitap\eShopSolution-develop\eShopSolution.WebApp\Views\Cart\Checkout.cshtml"
                   Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>\n                       \n                        ");
#nullable restore
#line 45 "C:\Users\Oanh\Documents\baitap\eShopSolution-develop\eShopSolution.WebApp\Views\Cart\Checkout.cshtml"
                   Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>");
#nullable restore
#line 47 "C:\Users\Oanh\Documents\baitap\eShopSolution-develop\eShopSolution.WebApp\Views\Cart\Checkout.cshtml"
                   Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 48 "C:\Users\Oanh\Documents\baitap\eShopSolution-develop\eShopSolution.WebApp\Views\Cart\Checkout.cshtml"
                    Write(item.Quantity*item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                </tr>\n");
#nullable restore
#line 50 "C:\Users\Oanh\Documents\baitap\eShopSolution-develop\eShopSolution.WebApp\Views\Cart\Checkout.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            <tr>\n                <td colspan=\"4\" style=\"text-align:right\"><strong>TOTAL =</strong></td>\n                <td class=\"label label-important\" style=\"display:block\"> <strong> ");
#nullable restore
#line 54 "C:\Users\Oanh\Documents\baitap\eShopSolution-develop\eShopSolution.WebApp\Views\Cart\Checkout.cshtml"
                                                                             Write(Model.CartItems.Sum(x => x.Quantity * x.Price).ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></td>\n            </tr>\n        </tbody>\n    </table>\n");
            WriteLiteral("    <table class=\"table table-bordered\">\n");
#nullable restore
#line 60 "C:\Users\Oanh\Documents\baitap\eShopSolution-develop\eShopSolution.WebApp\Views\Cart\Checkout.cshtml"
         if (User.Identity.IsAuthenticated)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr><th>Th??ng tin gi??? h??ng </th></tr>\n                        <tr>\n                            <td>\n\n\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e28b97576bd84e7c227951af7dd872ce7aad760212112", async() => {
                WriteLiteral(@"
                                    <div class=""control-group"">
                                        <label class=""control-label"" for=""inputCountry"">Name </label>
                                        <div class=""controls"">
                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e28b97576bd84e7c227951af7dd872ce7aad760212650", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 71 "C:\Users\Oanh\Documents\baitap\eShopSolution-develop\eShopSolution.WebApp\Views\Cart\Checkout.cshtml"
                                                                            WriteLiteral(User.Identity.Name);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 71 "C:\Users\Oanh\Documents\baitap\eShopSolution-develop\eShopSolution.WebApp\Views\Cart\Checkout.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CheckoutModel.Name);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                        </div>
                                    </div>
                                    <div class=""control-group"">
                                        <label class=""control-label"" for=""inputCountry"">Address </label>
                                        <div class=""controls"">
                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e28b97576bd84e7c227951af7dd872ce7aad760215594", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 77 "C:\Users\Oanh\Documents\baitap\eShopSolution-develop\eShopSolution.WebApp\Views\Cart\Checkout.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CheckoutModel.Address);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                        </div>
                                    </div>

                                    <div class=""control-group"">
                                        <label class=""control-label"" for=""inputCountry"">Email </label>
                                        <div class=""controls"">
                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e28b97576bd84e7c227951af7dd872ce7aad760217999", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#nullable restore
#line 84 "C:\Users\Oanh\Documents\baitap\eShopSolution-develop\eShopSolution.WebApp\Views\Cart\Checkout.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CheckoutModel.Email);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                        </div>
                                    </div>

                                    <div class=""control-group"">
                                        <label class=""control-label"" for=""inputCountry"">PhoneNumber </label>
                                        <div class=""controls"">
                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e28b97576bd84e7c227951af7dd872ce7aad760220495", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
#nullable restore
#line 91 "C:\Users\Oanh\Documents\baitap\eShopSolution-develop\eShopSolution.WebApp\Views\Cart\Checkout.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CheckoutModel.PhoneNumber);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                        </div>
                                    </div>

                                    <div class=""control-group"">
                                        <div class=""controls"">
                                            <button type=""submit"" class=""btn"">Mua h??ng </button>
                                        </div>
                                    </div>
                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1960, "/", 1960, 1, true);
#nullable restore
#line 67 "C:\Users\Oanh\Documents\baitap\eShopSolution-develop\eShopSolution.WebApp\Views\Cart\Checkout.cshtml"
AddHtmlAttributeValue("", 1961, culture, 1961, 8, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 1969, "/Cart/Checkout", 1969, 14, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("              \n\n                            </td>\n                        </tr> \n");
#nullable restore
#line 104 "C:\Users\Oanh\Documents\baitap\eShopSolution-develop\eShopSolution.WebApp\Views\Cart\Checkout.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <label class=\"control-label\" for=\"inputCountry\" style=\"color: red; font-size: 20px\" >B???n ph???i ????ng nh???p t??i kho???n m???i mua h??ng ???????c</label> ");
#nullable restore
#line 107 "C:\Users\Oanh\Documents\baitap\eShopSolution-develop\eShopSolution.WebApp\Views\Cart\Checkout.cshtml"
                                                                                                                                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </table>\n    <a href=\"/\" class=\"btn btn-large\"><i class=\"icon-arrow-left\"></i> Ti???p t???c mua h??ng </a>\n");
#nullable restore
#line 110 "C:\Users\Oanh\Documents\baitap\eShopSolution-develop\eShopSolution.WebApp\Views\Cart\Checkout.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CheckoutViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
