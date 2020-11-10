#pragma checksum "D:\Noi chua chat xam cua tui\DoAnTMDT\Views\Home\Cart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "25b08852f83d57d925bf2fb3fd872daa46c55f2e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Cart), @"mvc.1.0.view", @"/Views/Home/Cart.cshtml")]
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
#line 1 "D:\Noi chua chat xam cua tui\DoAnTMDT\Views\_ViewImports.cshtml"
using DoAnTMDT;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Noi chua chat xam cua tui\DoAnTMDT\Views\_ViewImports.cshtml"
using DoAnTMDT.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25b08852f83d57d925bf2fb3fd872daa46c55f2e", @"/Views/Home/Cart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3637e389f18fe28ba1e16562545f4d94ae190a8e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Cart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Cart>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("bg0 p-t-75 p-b-85"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Noi chua chat xam cua tui\DoAnTMDT\Views\Home\Cart.cshtml"
  
    ViewData["Title"] = "Giỏ Hàng - Đồ Án TMĐT";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "25b08852f83d57d925bf2fb3fd872daa46c55f2e3856", async() => {
                WriteLiteral(@"
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-10 col-xl-7 m-lr-auto m-b-50"">
                <div class=""m-l-25 m-r--38 m-lr-0-xl"">
                    <div class=""wrap-table-shopping-cart"">
                        <table class=""table-shopping-cart"">
                            <tr class=""table_head"">
                                <th class=""column-1"">Product</th>
                                <th class=""column-2""></th>
                                <th class=""column-3"">Price</th>
                                <th class=""column-4"">Quantity</th>
                                <th class=""column-5"">Total</th>
                            </tr>

");
#nullable restore
#line 23 "D:\Noi chua chat xam cua tui\DoAnTMDT\Views\Home\Cart.cshtml"
                             foreach (var cart in Model)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "D:\Noi chua chat xam cua tui\DoAnTMDT\Views\Home\Cart.cshtml"
                                 foreach (var cartDetail in cart.CartDetails)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <tr class=\"table_row\">\r\n                                        <td class=\"column-1\">\r\n                                            <div class=\"how-itemcart1\">\r\n                                                <img");
                BeginWriteAttribute("src", " src=\"", 1285, "\"", 1333, 1);
#nullable restore
#line 30 "D:\Noi chua chat xam cua tui\DoAnTMDT\Views\Home\Cart.cshtml"
WriteAttributeValue("", 1291, Url.Content(cartDetail.Product.ImagePath), 1291, 42, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" alt=\"IMG\">\r\n                                            </div>\r\n                                        </td>\r\n                                        <td class=\"column-2\"> ");
#nullable restore
#line 33 "D:\Noi chua chat xam cua tui\DoAnTMDT\Views\Home\Cart.cshtml"
                                                         Write(cartDetail.Product.ProductName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                        <td class=\"column-3\">$ ");
#nullable restore
#line 34 "D:\Noi chua chat xam cua tui\DoAnTMDT\Views\Home\Cart.cshtml"
                                                          Write(cartDetail.Product.ProductPrice);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</td>
                                        <td class=""column-4"">
                                            <div class=""wrap-num-product flex-w m-l-auto m-r-0"">
                                                <div class=""btn-num-product-down cl8 hov-btn3 trans-04 flex-c-m"">
                                                    <i class=""fs-16 zmdi zmdi-minus""></i>
                                                </div>

                                                <input class=""mtext-104 cl3 txt-center num-product"" type=""number"" name=""num-product1""");
                BeginWriteAttribute("value", " value=\"", 2206, "\"", 2234, 1);
#nullable restore
#line 41 "D:\Noi chua chat xam cua tui\DoAnTMDT\Views\Home\Cart.cshtml"
WriteAttributeValue("", 2214, cartDetail.Quantity, 2214, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">

                                                <div class=""btn-num-product-up cl8 hov-btn3 trans-04 flex-c-m"">
                                                    <i class=""fs-16 zmdi zmdi-plus""></i>
                                                </div>
                                            </div>
                                        </td>
                                        <td class=""column-5"">$ ");
#nullable restore
#line 48 "D:\Noi chua chat xam cua tui\DoAnTMDT\Views\Home\Cart.cshtml"
                                                           Write(cartDetail.Product.ProductPrice * cartDetail.Quantity);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    </tr>\r\n");
#nullable restore
#line 50 "D:\Noi chua chat xam cua tui\DoAnTMDT\Views\Home\Cart.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "D:\Noi chua chat xam cua tui\DoAnTMDT\Views\Home\Cart.cshtml"
                                 
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                        </table>
                    </div>

                    <div class=""flex-w flex-sb-m bor15 p-t-18 p-b-15 p-lr-40 p-lr-15-sm"">
                        <div class=""flex-w flex-m m-r-20 m-tb-5"">
                            <input class=""stext-104 cl2 plh4 size-117 bor13 p-lr-20 m-r-10 m-tb-5"" type=""text"" name=""coupon"" placeholder=""Coupon Code"">

                            <div class=""flex-c-m stext-101 cl2 size-118 bg8 bor13 hov-btn3 p-lr-15 trans-04 pointer m-tb-5"">
                                Apply coupon
                            </div>
                        </div>

                        <div class=""flex-c-m stext-101 cl2 size-119 bg8 bor13 hov-btn3 p-lr-15 trans-04 pointer m-tb-10"">
                            Update Cart
                        </div>
                    </div>
                </div>
            </div>

            <div class=""col-sm-10 col-lg-7 col-xl-5 m-lr-auto m-b-50"">
                <div class=""bor10 p-lr-40 p-t-30 p-b-40 m-l-6");
                WriteLiteral(@"3 m-r-40 m-lr-0-xl p-lr-15-sm"">
                    <h4 class=""mtext-109 cl2 p-b-30"">
                        Cart Totals
                    </h4>

                    <div class=""flex-w flex-t bor12 p-b-13"">
                        <div class=""size-208"">
                            <span class=""stext-110 cl2"">
                                Subtotal:
                            </span>
                        </div>

                        <div class=""size-209"">
                            <span class=""mtext-110 cl2"">
                                $79.65
                            </span>
                        </div>
                    </div>

                    <div class=""flex-w flex-t bor12 p-t-15 p-b-30"">
                        <div class=""size-208 w-full-ssm"">
                            <span class=""stext-110 cl2"">
                                Shipping:
                            </span>
                        </div>

                        <div class=""size-20");
                WriteLiteral(@"9 p-r-18 p-r-0-sm w-full-ssm"">
                            <p class=""stext-111 cl6 p-t-2"">
                                There are no shipping methods available. Please double check your address, or contact us if you need any help.
                            </p>

                            <div class=""p-t-15"">
                                <span class=""stext-112 cl8"">
                                    Calculate Shipping
                                </span>

                                <div class=""rs1-select2 rs2-select2 bor8 bg0 m-b-12 m-t-9"">
                                    <select class=""js-select2"" name=""time"">
                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "25b08852f83d57d925bf2fb3fd872daa46c55f2e11875", async() => {
                    WriteLiteral("Select a country...");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "25b08852f83d57d925bf2fb3fd872daa46c55f2e12943", async() => {
                    WriteLiteral("USA");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "25b08852f83d57d925bf2fb3fd872daa46c55f2e13995", async() => {
                    WriteLiteral("UK");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                    </select>
                                    <div class=""dropDownSelect2""></div>
                                </div>

                                <div class=""bor8 bg0 m-b-12"">
                                    <input class=""stext-111 cl8 plh3 size-111 p-lr-15"" type=""text"" name=""state"" placeholder=""State /  country"">
                                </div>

                                <div class=""bor8 bg0 m-b-22"">
                                    <input class=""stext-111 cl8 plh3 size-111 p-lr-15"" type=""text"" name=""postcode"" placeholder=""Postcode / Zip"">
                                </div>

                                <div class=""flex-w"">
                                    <div class=""flex-c-m stext-101 cl2 size-115 bg8 bor13 hov-btn3 p-lr-15 trans-04 pointer"">
                                        Update Totals
                                    </div>
                                </div>

                            </div>
 ");
                WriteLiteral(@"                       </div>
                    </div>

                    <div class=""flex-w flex-t p-t-27 p-b-33"">
                        <div class=""size-208"">
                            <span class=""mtext-101 cl2"">
                                Total:
                            </span>
                        </div>

                        <div class=""size-209 p-t-1"">
                            <span class=""mtext-110 cl2"">
                                $79.65
                            </span>
                        </div>
                    </div>

                    <button class=""flex-c-m stext-101 cl0 size-116 bg3 bor14 hov-btn3 p-lr-15 trans-04 pointer"">
                        Proceed to Checkout
                    </button>
                </div>
            </div>
        </div>
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Cart>> Html { get; private set; }
    }
}
#pragma warning restore 1591
