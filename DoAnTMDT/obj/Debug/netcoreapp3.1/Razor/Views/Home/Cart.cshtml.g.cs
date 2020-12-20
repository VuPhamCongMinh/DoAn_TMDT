#pragma checksum "D:\Noi chua chat xam cua tui\DoAnTMDT\Views\Home\Cart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e131bf844ba8132817b363d3219eefea266fbf2"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e131bf844ba8132817b363d3219eefea266fbf2", @"/Views/Home/Cart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3637e389f18fe28ba1e16562545f4d94ae190a8e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Cart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DoAnTMDT.ViewModels.CartAndUserViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("bg0 p-t-75 p-b-85"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("cartForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
    double sum = 0;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e131bf844ba8132817b363d3219eefea266fbf24497", async() => {
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
#line 21 "D:\Noi chua chat xam cua tui\DoAnTMDT\Views\Home\Cart.cshtml"
                             foreach (var cart in Model.Carts)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "D:\Noi chua chat xam cua tui\DoAnTMDT\Views\Home\Cart.cshtml"
                                 foreach (var cartDetail in cart.CartDetails)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <tr class=\"table_row\">\r\n                                        <td class=\"column-1\">\r\n                                            <div class=\"how-itemcart1\">\r\n                                                <img");
                BeginWriteAttribute("src", " src=\"", 1357, "\"", 1405, 1);
#nullable restore
#line 28 "D:\Noi chua chat xam cua tui\DoAnTMDT\Views\Home\Cart.cshtml"
WriteAttributeValue("", 1363, Url.Content(cartDetail.Product.ImagePath), 1363, 42, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" alt=\"IMG\">\r\n                                            </div>\r\n                                        </td>\r\n                                        <td class=\"column-2\"> ");
#nullable restore
#line 31 "D:\Noi chua chat xam cua tui\DoAnTMDT\Views\Home\Cart.cshtml"
                                                         Write(cartDetail.Product.ProductName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                        <td class=\"column-3\">$ ");
#nullable restore
#line 32 "D:\Noi chua chat xam cua tui\DoAnTMDT\Views\Home\Cart.cshtml"
                                                          Write(cartDetail.Product.ProductPrice);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</td>
                                        <td class=""column-4"">
                                            <div class=""wrap-num-product flex-w m-l-auto m-r-0"">
                                                <div class=""btn-num-product-down cl8 hov-btn3 trans-04 flex-c-m"" data-id=""");
#nullable restore
#line 35 "D:\Noi chua chat xam cua tui\DoAnTMDT\Views\Home\Cart.cshtml"
                                                                                                                     Write(cartDetail.ProductID);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" data-size=\"");
#nullable restore
#line 35 "D:\Noi chua chat xam cua tui\DoAnTMDT\Views\Home\Cart.cshtml"
                                                                                                                                                       Write(cartDetail.Size);

#line default
#line hidden
#nullable disable
                WriteLiteral(@""">
                                                    <i class=""fs-16 zmdi zmdi-minus""></i>
                                                </div>

                                                <input class=""mtext-104 cl3 txt-center num-product"" type=""number"" name=""num-product1""");
                BeginWriteAttribute("value", " value=\"", 2339, "\"", 2367, 1);
#nullable restore
#line 39 "D:\Noi chua chat xam cua tui\DoAnTMDT\Views\Home\Cart.cshtml"
WriteAttributeValue("", 2347, cartDetail.Quantity, 2347, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n\r\n                                                <div class=\"btn-num-product-up cl8 hov-btn3 trans-04 flex-c-m\" data-id=\"");
#nullable restore
#line 41 "D:\Noi chua chat xam cua tui\DoAnTMDT\Views\Home\Cart.cshtml"
                                                                                                                   Write(cartDetail.ProductID);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" data-size=\"");
#nullable restore
#line 41 "D:\Noi chua chat xam cua tui\DoAnTMDT\Views\Home\Cart.cshtml"
                                                                                                                                                     Write(cartDetail.Size);

#line default
#line hidden
#nullable disable
                WriteLiteral(@""">
                                                    <i class=""fs-16 zmdi zmdi-plus""></i>
                                                </div>
                                            </div>
                                        </td>
                                        <td class=""column-5"">$ ");
#nullable restore
#line 46 "D:\Noi chua chat xam cua tui\DoAnTMDT\Views\Home\Cart.cshtml"
                                                           Write(cartDetail.Product.ProductPrice * cartDetail.Quantity);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n");
#nullable restore
#line 47 "D:\Noi chua chat xam cua tui\DoAnTMDT\Views\Home\Cart.cshtml"
                                           sum += @cartDetail.Quantity * @cartDetail.Product.ProductPrice;

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    </tr>\r\n");
#nullable restore
#line 49 "D:\Noi chua chat xam cua tui\DoAnTMDT\Views\Home\Cart.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "D:\Noi chua chat xam cua tui\DoAnTMDT\Views\Home\Cart.cshtml"
                                 
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                        </table>
                    </div>
                </div>
            </div>

            <div class=""col-sm-10 col-lg-7 col-xl-5 m-lr-auto m-b-50"">
                <div class=""bor10 p-lr-40 p-t-30 p-b-40 m-l-63 m-r-40 m-lr-0-xl p-lr-15-sm"">
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
                                $");
#nullable restore
#line 72 "D:\Noi chua chat xam cua tui\DoAnTMDT\Views\Home\Cart.cshtml"
                            Write(sum);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                            </span>
                        </div>
                    </div>

                    <div class=""flex-w flex-t bor12 p-t-15 p-b-30"">
                        <div class=""size-208 w-full-ssm"">
                            <span class=""stext-110 cl2"">
                                Shipping:
                            </span>
                        </div>

                        <div class=""size-209 p-r-18 p-r-0-sm w-full-ssm"">
                            <div class=""rs1-select2 rs2-select2 bor8 bg0 m-b-12"">
                                <select class=""js-select2"" name=""addressValue"">
");
#nullable restore
#line 87 "D:\Noi chua chat xam cua tui\DoAnTMDT\Views\Home\Cart.cshtml"
                                     foreach (var diachi in Model.User.DeliveryInfo)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e131bf844ba8132817b363d3219eefea266fbf213401", async() => {
#nullable restore
#line 89 "D:\Noi chua chat xam cua tui\DoAnTMDT\Views\Home\Cart.cshtml"
                                                                        Write(diachi.Address);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 89 "D:\Noi chua chat xam cua tui\DoAnTMDT\Views\Home\Cart.cshtml"
                                           WriteLiteral(diachi.AddressValue);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 90 "D:\Noi chua chat xam cua tui\DoAnTMDT\Views\Home\Cart.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                </select>
                                <div class=""dropDownSelect2""></div>
                            </div>

                            <div class=""bor8 bg0 m-b-12"">
                                <input class=""stext-111 cl8 plh3 size-111 p-lr-15"" type=""text"" id=""diachi"" placeholder=""Địa chỉ"" disabled>
                            </div>

                            <div class=""bor8 bg0 m-b-22"">
                                <input class=""stext-111 cl8 plh3 size-111 p-lr-15"" type=""text"" id=""sdt"" placeholder=""SĐT"" disabled>
                            </div>
                        </div>
                    </div>

                    <div class=""flex-w flex-t p-t-27 p-b-33"">
                        <div class=""size-208"">
                            <span class=""mtext-101 cl2"">
                                Total:
                            </span>
                        </div>

                        <div class=""size-209 p-t-1"">
             ");
                WriteLiteral("               $\r\n                            <span class=\"mtext-110 cl2\" id=\"sumValue\">\r\n                                ");
#nullable restore
#line 115 "D:\Noi chua chat xam cua tui\DoAnTMDT\Views\Home\Cart.cshtml"
                           Write(sum);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </span>\r\n                        </div>\r\n                    </div>\r\n                    <input type=\"checkbox\" id=\"point\"");
                BeginWriteAttribute("value", " value=\"", 6167, "\"", 6192, 1);
#nullable restore
#line 119 "D:\Noi chua chat xam cua tui\DoAnTMDT\Views\Home\Cart.cshtml"
WriteAttributeValue("", 6175, Model.User.Point, 6175, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                    <label for=\"point\">Sử dụng ");
#nullable restore
#line 120 "D:\Noi chua chat xam cua tui\DoAnTMDT\Views\Home\Cart.cshtml"
                                          Write(Model.User.Point);

#line default
#line hidden
#nullable disable
                WriteLiteral(" xu  (1 xu = 1 $) ?</label>\r\n                    <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 6329, "\"", 6364, 1);
#nullable restore
#line 121 "D:\Noi chua chat xam cua tui\DoAnTMDT\Views\Home\Cart.cshtml"
WriteAttributeValue("", 6337, Model.Carts.First().CartID, 6337, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" name=""id"" />
                    <input type=""hidden"" value=""false"" name=""usePoint"" id=""usePoint"" />
                    <a href=""#"" id=""normal-pay"" class=""flex-c-m stext-101 cl0 size-107 bg3 bor2 hov-btn3 p-lr-15 trans-04 m-b-10"">
                        Thanh toán COD
                    </a>
                    <a href=""#"" id=""paypal-pay"" class=""flex-c-m stext-101 cl0 size-107 bg3 bor2 hov-btn3 p-lr-15 trans-04 m-b-10"">
                        Thanh toán Paypal
                    </a>
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        $(\'#normal-pay\').click(function (e) {\r\n            e.preventDefault();\r\n            $(\'#cartForm\').attr(\'action\', \"");
#nullable restore
#line 141 "D:\Noi chua chat xam cua tui\DoAnTMDT\Views\Home\Cart.cshtml"
                                      Write(Url.Action("CodCheckout"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\").submit();\r\n        });\r\n\r\n        $(\'#paypal-pay\').click(function (e) {\r\n            e.preventDefault();\r\n            $(\'#cartForm\').attr(\'action\', \"");
#nullable restore
#line 146 "D:\Noi chua chat xam cua tui\DoAnTMDT\Views\Home\Cart.cshtml"
                                      Write(Url.Action("Checkout"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""").submit();
        });
        $('.btn-num-product-down').on('click', function () {
            var numProduct = Number($(this).prev().val());
            if (numProduct > 0) $(this).next().val(numProduct - 1);

            var idToUp = ($(this).data('id'));
            var sizeToUp = ($(this).data('size'));

            $.ajax({
                data: { itemID: idToUp, size: sizeToUp },
                url: '");
#nullable restore
#line 157 "D:\Noi chua chat xam cua tui\DoAnTMDT\Views\Home\Cart.cshtml"
                 Write(Url.Action("RemoveCart"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n                success: function (res) {\r\n                    $.ajax({\r\n                        url: \'");
#nullable restore
#line 160 "D:\Noi chua chat xam cua tui\DoAnTMDT\Views\Home\Cart.cshtml"
                         Write(Url.Action("ReloadCountTotal"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                        success: function (data) {
                            $(""#cartCount"").html(data);
                        }
                    });
                    //Re-render Giỏ hàng
                    $.ajax({
                        url: '");
#nullable restore
#line 167 "D:\Noi chua chat xam cua tui\DoAnTMDT\Views\Home\Cart.cshtml"
                         Write(Url.Action("ReloadDisplayCartTotal"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                        success: function (data) {
                            $(""#cartBar"").html(data);
                        }
                    });
                    //#endregion
                },
                error: function (res) { console.log(res); }
            });



        });

        $('.btn-num-product-up').on('click', function () {
            var numProduct = Number($(this).prev().val());
            $(this).prev().val(numProduct + 1);

            var idToUp = ($(this).data('id'));
            var sizeToUp = ($(this).data('size'));

            $.ajax({
                data: { itemID: idToUp, size: sizeToUp, quantity: 1 },
                type: 'POST',
                url: '");
#nullable restore
#line 191 "D:\Noi chua chat xam cua tui\DoAnTMDT\Views\Home\Cart.cshtml"
                 Write(Url.Action("AddCart"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n                success: function (res) {\r\n                    //#region Code re-render lại giỏ hàng trên navbar khi thêm thành công\r\n                //Re-render Bộ đếm\r\n                $.ajax({\r\n                url: \'");
#nullable restore
#line 196 "D:\Noi chua chat xam cua tui\DoAnTMDT\Views\Home\Cart.cshtml"
                 Write(Url.Action("ReloadCountTotal", "Home"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n                    success: function (data) {\r\n                        parent.$(\"#cartCount\").html(data);\r\n                }\r\n                });\r\n                //Re-render Giỏ hàng\r\n                $.ajax({\r\n                    url: \'");
#nullable restore
#line 203 "D:\Noi chua chat xam cua tui\DoAnTMDT\Views\Home\Cart.cshtml"
                     Write(Url.Action("ReloadDisplayCartTotal", "Home"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                    success: function (data) {
                        parent.$(""#cartBar"").html(data);
                    }
                });
            //#endregion
                },
                error: function (res) { console.log(res); }
            });
        });

        $('.js-select2').on('change', function () {
               $.ajax({
                data: { addressValue: this.value },
                url: '");
#nullable restore
#line 217 "D:\Noi chua chat xam cua tui\DoAnTMDT\Views\Home\Cart.cshtml"
                 Write(Url.Action("GetAddressInfo"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                   success: function (res) {
                       _addressValue = res.addressValue;
                       $('#sdt').val(res.phone);
                       $('#diachi').val(res.address);
                },
                error: function (res) { console.log(res); }
            });

        });

        $('#point').click(function () {
            let sum = parseInt($('#sumValue').text());

            if ($('#point').prop('checked')) {
                $('#sumValue').text(sum - parseInt($('#point').val()));
                $('#usePoint').val(true);
            }
            else {
                $('#sumValue').text(sum + parseInt($('#point').val()));
                $('#usePoint').val(false);
            }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DoAnTMDT.ViewModels.CartAndUserViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
