#pragma checksum "C:\Users\ACER\source\repos\DoAn_TMDT\DoAnTMDT\Views\Shared\Components\DisplayCartTotal\_TotalCartItem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "698ede32b8ffda5aa275e4bcee8ec2b86688a7ac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_DisplayCartTotal__TotalCartItem), @"mvc.1.0.view", @"/Views/Shared/Components/DisplayCartTotal/_TotalCartItem.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"698ede32b8ffda5aa275e4bcee8ec2b86688a7ac", @"/Views/Shared/Components/DisplayCartTotal/_TotalCartItem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3637e389f18fe28ba1e16562545f4d94ae190a8e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_DisplayCartTotal__TotalCartItem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Cart>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ACER\source\repos\DoAn_TMDT\DoAnTMDT\Views\Shared\Components\DisplayCartTotal\_TotalCartItem.cshtml"
  
    double sum = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\ACER\source\repos\DoAn_TMDT\DoAnTMDT\Views\Shared\Components\DisplayCartTotal\_TotalCartItem.cshtml"
 if (Model.Count() == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"header-cart-total w-full p-tb-40\">\r\n        <h4>Giỏ hàng đang trống trơn</h4>\r\n    </div>\r\n");
#nullable restore
#line 11 "C:\Users\ACER\source\repos\DoAn_TMDT\DoAnTMDT\Views\Shared\Components\DisplayCartTotal\_TotalCartItem.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <ul class=\"header-cart-wrapitem w-full\">\r\n");
#nullable restore
#line 15 "C:\Users\ACER\source\repos\DoAn_TMDT\DoAnTMDT\Views\Shared\Components\DisplayCartTotal\_TotalCartItem.cshtml"
         foreach (var cart in Model)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\ACER\source\repos\DoAn_TMDT\DoAnTMDT\Views\Shared\Components\DisplayCartTotal\_TotalCartItem.cshtml"
             foreach (var cartDetail in cart.CartDetails)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"header-cart-item flex-w flex-t m-b-12\">\r\n                    <div class=\"header-cart-item-img\" data-productid=\"");
#nullable restore
#line 20 "C:\Users\ACER\source\repos\DoAn_TMDT\DoAnTMDT\Views\Shared\Components\DisplayCartTotal\_TotalCartItem.cshtml"
                                                                 Write(cartDetail.ProductID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-size=\"");
#nullable restore
#line 20 "C:\Users\ACER\source\repos\DoAn_TMDT\DoAnTMDT\Views\Shared\Components\DisplayCartTotal\_TotalCartItem.cshtml"
                                                                                                   Write(cartDetail.Size);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 593, "\"", 641, 1);
#nullable restore
#line 21 "C:\Users\ACER\source\repos\DoAn_TMDT\DoAnTMDT\Views\Shared\Components\DisplayCartTotal\_TotalCartItem.cshtml"
WriteAttributeValue("", 599, Url.Content(cartDetail.Product.ImagePath), 599, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"IMG\">\r\n                    </div>\r\n\r\n                    <div class=\"header-cart-item-txt p-t-8\">\r\n                        <a href=\"#\" class=\"header-cart-item-name m-b-12 hov-cl1 trans-04\">\r\n                            ");
#nullable restore
#line 26 "C:\Users\ACER\source\repos\DoAn_TMDT\DoAnTMDT\Views\Shared\Components\DisplayCartTotal\_TotalCartItem.cshtml"
                       Write(cartDetail.Product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 26 "C:\Users\ACER\source\repos\DoAn_TMDT\DoAnTMDT\Views\Shared\Components\DisplayCartTotal\_TotalCartItem.cshtml"
                                                         Write(cartDetail.Size);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </a>\r\n\r\n                        <span class=\"header-cart-item-info\">\r\n                            ");
#nullable restore
#line 30 "C:\Users\ACER\source\repos\DoAn_TMDT\DoAnTMDT\Views\Shared\Components\DisplayCartTotal\_TotalCartItem.cshtml"
                       Write(cartDetail.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral(" x $");
#nullable restore
#line 30 "C:\Users\ACER\source\repos\DoAn_TMDT\DoAnTMDT\Views\Shared\Components\DisplayCartTotal\_TotalCartItem.cshtml"
                                               Write(cartDetail.Product.ProductPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 31 "C:\Users\ACER\source\repos\DoAn_TMDT\DoAnTMDT\Views\Shared\Components\DisplayCartTotal\_TotalCartItem.cshtml"
                               sum += @cartDetail.Quantity * @cartDetail.Product.ProductPrice;

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </span>\r\n                    </div>\r\n                </li>\r\n");
#nullable restore
#line 35 "C:\Users\ACER\source\repos\DoAn_TMDT\DoAnTMDT\Views\Shared\Components\DisplayCartTotal\_TotalCartItem.cshtml"

            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\ACER\source\repos\DoAn_TMDT\DoAnTMDT\Views\Shared\Components\DisplayCartTotal\_TotalCartItem.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n");
            WriteLiteral("    <div class=\"w-full\">\r\n        <div class=\"header-cart-total w-full p-tb-40\">\r\n            Total: $");
#nullable restore
#line 42 "C:\Users\ACER\source\repos\DoAn_TMDT\DoAnTMDT\Views\Shared\Components\DisplayCartTotal\_TotalCartItem.cshtml"
               Write(sum);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"header-cart-buttons flex-w w-full\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 1518, "\"", 1544, 1);
#nullable restore
#line 46 "C:\Users\ACER\source\repos\DoAn_TMDT\DoAnTMDT\Views\Shared\Components\DisplayCartTotal\_TotalCartItem.cshtml"
WriteAttributeValue("", 1525, Url.Action("Cart"), 1525, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"flex-c-m stext-101 cl0 size-107 bg3 bor2 hov-btn3 p-lr-15 trans-04 m-r-8 m-b-10\">\r\n                View Cart\r\n            </a>\r\n\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 1697, "\"", 1767, 1);
#nullable restore
#line 50 "C:\Users\ACER\source\repos\DoAn_TMDT\DoAnTMDT\Views\Shared\Components\DisplayCartTotal\_TotalCartItem.cshtml"
WriteAttributeValue("", 1704, Url.Action("CHeckout","Home",new { id = Model.First().CartID}), 1704, 63, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"flex-c-m stext-101 cl0 size-107 bg3 bor2 hov-btn3 p-lr-15 trans-04 m-b-10\">\r\n                Check Out\r\n            </a>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 55 "C:\Users\ACER\source\repos\DoAn_TMDT\DoAnTMDT\Views\Shared\Components\DisplayCartTotal\_TotalCartItem.cshtml"
}

#line default
#line hidden
#nullable disable
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
