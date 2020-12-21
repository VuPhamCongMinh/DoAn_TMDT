#pragma checksum "C:\Users\ACER\source\repos\DoAn_TMDT\DoAnTMDT\Views\Home\TrackCart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f8c301ff2dbfd4bd4c901e745faecdd942ab46f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_TrackCart), @"mvc.1.0.view", @"/Views/Home/TrackCart.cshtml")]
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
#line 1 "C:\Users\ACER\source\repos\DoAn_TMDT\DoAnTMDT\Views\_ViewImports.cshtml"
using DoAnTMDT;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ACER\source\repos\DoAn_TMDT\DoAnTMDT\Views\_ViewImports.cshtml"
using DoAnTMDT.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f8c301ff2dbfd4bd4c901e745faecdd942ab46f", @"/Views/Home/TrackCart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3637e389f18fe28ba1e16562545f4d94ae190a8e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_TrackCart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DoAnTMDT.ViewModels.TrackCartViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/trackcart.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ACER\source\repos\DoAn_TMDT\DoAnTMDT\Views\Home\TrackCart.cshtml"
  
    ViewData["Title"] = "Tracking giỏ hàng";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\ACER\source\repos\DoAn_TMDT\DoAnTMDT\Views\Home\TrackCart.cshtml"
  
    void RenderCssClass(bool isCompleted)
    {
        if (isCompleted)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"step0 active\"></li>\r\n");
#nullable restore
#line 12 "C:\Users\ACER\source\repos\DoAn_TMDT\DoAnTMDT\Views\Home\TrackCart.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"step0\"></li>\r\n");
#nullable restore
#line 16 "C:\Users\ACER\source\repos\DoAn_TMDT\DoAnTMDT\Views\Home\TrackCart.cshtml"
        }
    }

    void RenderShippingStatus(bool isCompleted, Cart cart)
    {
        if (isCompleted)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"align-self-center\">\r\n                <p class=\"font-weight-bold\">Hàng đã được giao</p>\r\n                <p class=\"font-weight-light\"></p>\r\n            </div>\r\n");
#nullable restore
#line 27 "C:\Users\ACER\source\repos\DoAn_TMDT\DoAnTMDT\Views\Home\TrackCart.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"align-self-center\">\r\n                <p class=\"font-weight-bold\">Hàng đang được giao</p>\r\n                <p class=\"font-weight-light\">Hàng sẽ được giao trong khoảng 2-3 ngày</p>\r\n            </div>\r\n");
#nullable restore
#line 34 "C:\Users\ACER\source\repos\DoAn_TMDT\DoAnTMDT\Views\Home\TrackCart.cshtml"
        }
    }


    void RenderPaymentStatus(bool isCompleted, Cart cart)
    {
        if (isCompleted)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"align-self-center\">\r\n                <p class=\"font-weight-bold\">Đã thanh toán</p>\r\n                <p class=\"font-weight-light\">");
#nullable restore
#line 44 "C:\Users\ACER\source\repos\DoAn_TMDT\DoAnTMDT\Views\Home\TrackCart.cshtml"
                                        Write(cart.PayDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n");
#nullable restore
#line 46 "C:\Users\ACER\source\repos\DoAn_TMDT\DoAnTMDT\Views\Home\TrackCart.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"align-self-center\">\r\n                <p class=\"font-weight-bold\">Chưa thanh toán</p>\r\n                <p class=\"font-weight-light\"></p>\r\n            </div>\r\n");
#nullable restore
#line 53 "C:\Users\ACER\source\repos\DoAn_TMDT\DoAnTMDT\Views\Home\TrackCart.cshtml"
        }
    }

    void RenderButton(bool isCompleted, string cartID)
    {
        if (isCompleted)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <button type=\"button\" class=\"w-100 btn btn-outline-dark font-weight-bold confirmed-cart\" disabled>Xác nhận hoàn thành đơn hàng</button>\r\n");
#nullable restore
#line 61 "C:\Users\ACER\source\repos\DoAn_TMDT\DoAnTMDT\Views\Home\TrackCart.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <button type=\"button\" class=\"w-100 btn btn-outline-dark font-weight-bold confirmed-cart\" data-cartid=\"");
#nullable restore
#line 64 "C:\Users\ACER\source\repos\DoAn_TMDT\DoAnTMDT\Views\Home\TrackCart.cshtml"
                                                                                                             Write(cartID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Xác nhận hoàn thành đơn hàng</button>\r\n");
#nullable restore
#line 65 "C:\Users\ACER\source\repos\DoAn_TMDT\DoAnTMDT\Views\Home\TrackCart.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2f8c301ff2dbfd4bd4c901e745faecdd942ab46f8108", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n<h4 class=\"text-center ltext-109 cl2 p-t-50\">Orders đã hoàn tất</h4>\r\n");
#nullable restore
#line 73 "C:\Users\ACER\source\repos\DoAn_TMDT\DoAnTMDT\Views\Home\TrackCart.cshtml"
 if (Model.CompletedOrders.Count() != 0)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 75 "C:\Users\ACER\source\repos\DoAn_TMDT\DoAnTMDT\Views\Home\TrackCart.cshtml"
     foreach (var cart in Model.CompletedOrders)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div>
            <div class=""card"">
                <div class=""row d-flex justify-content-between px-3 top"">
                    <div class=""d-flex flex-column"">
                        <p>MÃ ĐƠN HÀNG <span class=""text-primary font-weight-bold"">#");
#nullable restore
#line 81 "C:\Users\ACER\source\repos\DoAn_TMDT\DoAnTMDT\Views\Home\TrackCart.cshtml"
                                                                               Write(cart.CartID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n                        <p>Hình thức <span class=\"text-primary font-weight-bold\">");
#nullable restore
#line 82 "C:\Users\ACER\source\repos\DoAn_TMDT\DoAnTMDT\Views\Home\TrackCart.cshtml"
                                                                             Write(cart.IsCOD ? "COD": "Thanh toán bằng Paypal");

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n                    </div>\r\n                    <div class=\"d-flex flex-column text-sm-right\">\r\n                        <p class=\"mb-0\">Thời gian dự kiến hàng được giao <span>");
#nullable restore
#line 85 "C:\Users\ACER\source\repos\DoAn_TMDT\DoAnTMDT\Views\Home\TrackCart.cshtml"
                                                                          Write(cart.PayDate.AddDays(3).ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></p>
                        <p>Đơn vị vận chuyển <span class=""font-weight-bold"">Lương Sơn Hiền Express</span></p>
                    </div>
                </div> <!-- Add class 'active' to progress -->
                <div class=""row d-flex justify-content"">
                    <div class=""col-12"">
                        <ul id=""progressbar"" class=""text-center"">
                            <li class=""active step0""></li>
                            <li class=""active step0""></li>
");
#nullable restore
#line 94 "C:\Users\ACER\source\repos\DoAn_TMDT\DoAnTMDT\Views\Home\TrackCart.cshtml"
                              RenderCssClass(cart.IsCompleted); 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </ul>
                    </div>
                </div>
                <div class=""row d-flex justify-content-between top"">
                    <div class=""row d-flex icon-content"">
                        <img class=""icon"" src=""https://i.imgur.com/9nnc9Et.png"">
                        <div class=""align-self-center"">
                            <p class=""font-weight-bold"">Đặt hàng thành công</p>
                            <p class=""font-weight-light"">");
#nullable restore
#line 104 "C:\Users\ACER\source\repos\DoAn_TMDT\DoAnTMDT\Views\Home\TrackCart.cshtml"
                                                    Write(cart.OderDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"row d-flex icon-content\">\r\n                        <img class=\"icon\" src=\"https://i.imgur.com/u1AzR7w.png\">\r\n");
#nullable restore
#line 109 "C:\Users\ACER\source\repos\DoAn_TMDT\DoAnTMDT\Views\Home\TrackCart.cshtml"
                           RenderPaymentStatus(cart.IsPayed, cart);

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                    <div class=\"row d-flex icon-content\">\r\n                        <img class=\"icon\" src=\"https://i.imgur.com/TkPm63y.png\">\r\n");
#nullable restore
#line 113 "C:\Users\ACER\source\repos\DoAn_TMDT\DoAnTMDT\Views\Home\TrackCart.cshtml"
                           RenderShippingStatus(cart.IsCompleted, cart);

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n                <div class=\"row d-flex justify-content-center mt-2\">\r\n                    <div class=\"col-md-10\">\r\n");
#nullable restore
#line 118 "C:\Users\ACER\source\repos\DoAn_TMDT\DoAnTMDT\Views\Home\TrackCart.cshtml"
                          RenderButton(cart.IsCompleted, cart.CartID); 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>
                </div>
            </div>
        </div>
        <table class=""table-shopping-cart"">
            <tr class=""table_head"">
                <th class=""column-1"">SẢN PHẨM</th>
                <th class=""column-2""></th>
                <th class=""column-3"">GIÁ</th>
            </tr>
");
#nullable restore
#line 129 "C:\Users\ACER\source\repos\DoAn_TMDT\DoAnTMDT\Views\Home\TrackCart.cshtml"
             foreach (var cartDetail in cart.CartDetails)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"table_row\">\r\n                    <td class=\"column-1\">\r\n                        <div class=\"how-itemcart1\">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 5300, "\"", 5348, 1);
#nullable restore
#line 134 "C:\Users\ACER\source\repos\DoAn_TMDT\DoAnTMDT\Views\Home\TrackCart.cshtml"
WriteAttributeValue("", 5306, Url.Content(cartDetail.Product.ImagePath), 5306, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"IMG\">\r\n                        </div>\r\n                    </td>\r\n                    <td class=\"column-2\"> ");
#nullable restore
#line 137 "C:\Users\ACER\source\repos\DoAn_TMDT\DoAnTMDT\Views\Home\TrackCart.cshtml"
                                     Write(cartDetail.Product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - x ");
#nullable restore
#line 137 "C:\Users\ACER\source\repos\DoAn_TMDT\DoAnTMDT\Views\Home\TrackCart.cshtml"
                                                                         Write(cartDetail.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 138 "C:\Users\ACER\source\repos\DoAn_TMDT\DoAnTMDT\Views\Home\TrackCart.cshtml"
                      
                        if (cart.IsCOD)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td class=\"column-3\">$ ");
#nullable restore
#line 141 "C:\Users\ACER\source\repos\DoAn_TMDT\DoAnTMDT\Views\Home\TrackCart.cshtml"
                                              Write(cartDetail.Product.ProductPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 142 "C:\Users\ACER\source\repos\DoAn_TMDT\DoAnTMDT\Views\Home\TrackCart.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td class=\"column-3\">$ ");
#nullable restore
#line 145 "C:\Users\ACER\source\repos\DoAn_TMDT\DoAnTMDT\Views\Home\TrackCart.cshtml"
                                               Write(cartDetail.Product.ProductPrice - cartDetail.Product.ProductPrice*20/100);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 146 "C:\Users\ACER\source\repos\DoAn_TMDT\DoAnTMDT\Views\Home\TrackCart.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tr>\r\n");
#nullable restore
#line 149 "C:\Users\ACER\source\repos\DoAn_TMDT\DoAnTMDT\Views\Home\TrackCart.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n");
#nullable restore
#line 151 "C:\Users\ACER\source\repos\DoAn_TMDT\DoAnTMDT\Views\Home\TrackCart.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 151 "C:\Users\ACER\source\repos\DoAn_TMDT\DoAnTMDT\Views\Home\TrackCart.cshtml"
     
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3 class=\"text-center\">Trống trơn</h3>\r\n");
#nullable restore
#line 156 "C:\Users\ACER\source\repos\DoAn_TMDT\DoAnTMDT\Views\Home\TrackCart.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h1 class=\"text-center ltext-109 cl2 p-t-50\">Orders chưa hoàn tất</h1>\r\n");
#nullable restore
#line 160 "C:\Users\ACER\source\repos\DoAn_TMDT\DoAnTMDT\Views\Home\TrackCart.cshtml"
 if (Model.InCompletedOrders.Count() != 0)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 162 "C:\Users\ACER\source\repos\DoAn_TMDT\DoAnTMDT\Views\Home\TrackCart.cshtml"
     foreach (var cart in Model.InCompletedOrders)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card\">\r\n            <div class=\"row d-flex justify-content-between px-3 top\">\r\n                <div class=\"d-flex flex-column\">\r\n                    <p>MÃ ĐƠN HÀNG <span class=\"text-primary font-weight-bold\">#");
#nullable restore
#line 167 "C:\Users\ACER\source\repos\DoAn_TMDT\DoAnTMDT\Views\Home\TrackCart.cshtml"
                                                                           Write(cart.CartID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n                    <p>Hình thức <span class=\"text-primary font-weight-bold\">");
#nullable restore
#line 168 "C:\Users\ACER\source\repos\DoAn_TMDT\DoAnTMDT\Views\Home\TrackCart.cshtml"
                                                                         Write(cart.IsCOD ? "COD": "Thanh toán bằng Paypal");

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n                </div>\r\n                <div class=\"d-flex flex-column text-sm-right\">\r\n                    <p class=\"mb-0\">Thời gian dự kiến hàng được giao <span>");
#nullable restore
#line 171 "C:\Users\ACER\source\repos\DoAn_TMDT\DoAnTMDT\Views\Home\TrackCart.cshtml"
                                                                      Write(cart.PayDate.AddDays(3).ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></p>
                    <p>Đơn vị vận chuyển <span class=""font-weight-bold"">Lương Sơn Hiền Express</span></p>
                </div>
            </div> <!-- Add class 'active' to progress -->
            <div class=""row d-flex justify-content"">
                <div class=""col-12"">
                    <ul id=""progressbar"" class=""text-center"">
                        <li class=""active step0""></li>
");
#nullable restore
#line 179 "C:\Users\ACER\source\repos\DoAn_TMDT\DoAnTMDT\Views\Home\TrackCart.cshtml"
                          RenderCssClass(cart.IsPayed); 

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"step0\"></li>\r\n");
            WriteLiteral(@"                    </ul>
                </div>
            </div>
            <div class=""row d-flex justify-content-between top"">
                <div class=""row d-flex icon-content"">
                    <img class=""icon"" src=""https://i.imgur.com/9nnc9Et.png"">
                    <div class=""align-self-center"">
                        <p class=""font-weight-bold"">Đặt hàng thành công</p>
                        <p class=""font-weight-light"">");
#nullable restore
#line 190 "C:\Users\ACER\source\repos\DoAn_TMDT\DoAnTMDT\Views\Home\TrackCart.cshtml"
                                                Write(cart.OderDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n                <div class=\"row d-flex icon-content\">\r\n                    <img class=\"icon\" src=\"https://i.imgur.com/u1AzR7w.png\">\r\n");
#nullable restore
#line 195 "C:\Users\ACER\source\repos\DoAn_TMDT\DoAnTMDT\Views\Home\TrackCart.cshtml"
                       RenderPaymentStatus(cart.IsPayed, cart);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
                <div class=""row d-flex icon-content"">
                    <img class=""icon"" src=""https://i.imgur.com/TkPm63y.png"">
                    <div class=""align-self-center"">
                        <p class=""font-weight-bold"">Hàng đang được giao</p>
                        <p class=""font-weight-light""></p>
                    </div>
                </div>
            </div>
            <div class=""row d-flex justify-content-center mt-2"">
                <div class=""col-md-10"">
                    <button type=""button"" class=""w-100 btn btn-outline-dark font-weight-bold confirmed-cart"" data-cartid=""");
#nullable restore
#line 207 "C:\Users\ACER\source\repos\DoAn_TMDT\DoAnTMDT\Views\Home\TrackCart.cshtml"
                                                                                                                     Write(cart.CartID);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""">Xác nhận hoàn thành đơn hàng</button>
                </div>
            </div>
        </div>
        <table class=""table-shopping-cart"">
            <tr class=""table_head"">
                <th class=""column-1"">SẢN PHẨM</th>
                <th class=""column-2""></th>
                <th class=""column-3"">GIÁ</th>
            </tr>
");
#nullable restore
#line 217 "C:\Users\ACER\source\repos\DoAn_TMDT\DoAnTMDT\Views\Home\TrackCart.cshtml"
             foreach (var cartDetail in cart.CartDetails)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"table_row\">\r\n                    <td class=\"column-1\">\r\n                        <div class=\"how-itemcart1\">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 9482, "\"", 9530, 1);
#nullable restore
#line 222 "C:\Users\ACER\source\repos\DoAn_TMDT\DoAnTMDT\Views\Home\TrackCart.cshtml"
WriteAttributeValue("", 9488, Url.Content(cartDetail.Product.ImagePath), 9488, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"IMG\">\r\n                        </div>\r\n                    </td>\r\n                    <td class=\"column-2\"> ");
#nullable restore
#line 225 "C:\Users\ACER\source\repos\DoAn_TMDT\DoAnTMDT\Views\Home\TrackCart.cshtml"
                                     Write(cartDetail.Product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - x ");
#nullable restore
#line 225 "C:\Users\ACER\source\repos\DoAn_TMDT\DoAnTMDT\Views\Home\TrackCart.cshtml"
                                                                         Write(cartDetail.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 226 "C:\Users\ACER\source\repos\DoAn_TMDT\DoAnTMDT\Views\Home\TrackCart.cshtml"
                      
                        if (cart.IsCOD)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td class=\"column-3\">$ ");
#nullable restore
#line 229 "C:\Users\ACER\source\repos\DoAn_TMDT\DoAnTMDT\Views\Home\TrackCart.cshtml"
                                              Write(cartDetail.Product.ProductPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 230 "C:\Users\ACER\source\repos\DoAn_TMDT\DoAnTMDT\Views\Home\TrackCart.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td class=\"column-3\">$ ");
#nullable restore
#line 233 "C:\Users\ACER\source\repos\DoAn_TMDT\DoAnTMDT\Views\Home\TrackCart.cshtml"
                                               Write(cartDetail.Product.ProductPrice - cartDetail.Product.ProductPrice*20/100);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 234 "C:\Users\ACER\source\repos\DoAn_TMDT\DoAnTMDT\Views\Home\TrackCart.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tr>\r\n");
#nullable restore
#line 237 "C:\Users\ACER\source\repos\DoAn_TMDT\DoAnTMDT\Views\Home\TrackCart.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n");
#nullable restore
#line 239 "C:\Users\ACER\source\repos\DoAn_TMDT\DoAnTMDT\Views\Home\TrackCart.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 239 "C:\Users\ACER\source\repos\DoAn_TMDT\DoAnTMDT\Views\Home\TrackCart.cshtml"
     
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3 class=\"text-center\">Trống</h3>\r\n");
#nullable restore
#line 244 "C:\Users\ACER\source\repos\DoAn_TMDT\DoAnTMDT\Views\Home\TrackCart.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
    $('.confirmed-cart').each(function () {
        $(this).on('click', function (e) {
            let cartID = $(this).data('cartid');

            $.ajax({
                data: { id: cartID },
                type: 'POST',
                url: '");
#nullable restore
#line 255 "C:\Users\ACER\source\repos\DoAn_TMDT\DoAnTMDT\Views\Home\TrackCart.cshtml"
                 Write(Url.Action("ConfirmCompleted", "Home"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                success: function (res) {
                    setTimeout(location.reload.bind(location), 3000);
                    swal(""Thành công"", ""Đơn hàng đã hoàn tất, nhớ review bạn nhớ"", ""success"");
                },
                error: function (res) {
                    console.log(res);
                }
            });

            e.preventDefault();
        });
    });
    </script>
");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DoAnTMDT.ViewModels.TrackCartViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
