#pragma checksum "D:\Noi chua chat xam cua tui\DoAnTMDT\Views\Shared\ProductView\_ShowProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1051124ca4605de89e253c1afa5c06c34259df6e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_ProductView__ShowProduct), @"mvc.1.0.view", @"/Views/Shared/ProductView/_ShowProduct.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1051124ca4605de89e253c1afa5c06c34259df6e", @"/Views/Shared/ProductView/_ShowProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3637e389f18fe28ba1e16562545f4d94ae190a8e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_ProductView__ShowProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "D:\Noi chua chat xam cua tui\DoAnTMDT\Views\Shared\ProductView\_ShowProduct.cshtml"
 foreach (var product in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-sm-6 col-md-4 col-lg-3 p-b-35 isotope-item women\">\r\n        <!-- Block2 -->\r\n        <div class=\"block2\">\r\n            <div class=\"block2-pic hov-img0\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 263, "\"", 287, 1);
#nullable restore
#line 10 "D:\Noi chua chat xam cua tui\DoAnTMDT\Views\Shared\ProductView\_ShowProduct.cshtml"
WriteAttributeValue("", 269, product.ImagePath, 269, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"IMG-PRODUCT\">\r\n\r\n                <a href=\"#\" ");
            WriteLiteral(" class=\"block2-btn flex-c-m stext-103 cl2 size-102 bg0 bor2 hov-btn1 p-lr-15 trans-04 js-show-modal1\" data-productid=\"");
#nullable restore
#line 12 "D:\Noi chua chat xam cua tui\DoAnTMDT\Views\Shared\ProductView\_ShowProduct.cshtml"
                                                                                                                                                                                                 Write(product.ProductID);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""">
                    Quick View
                </a>
            </div>

            <div class=""block2-txt flex-w flex-t p-t-14"">
                <div class=""block2-txt-child1 flex-col-l "">
                    <a href=""product-detail.html"" class=""stext-104 cl4 hov-cl1 trans-04 js-name-b2 p-b-6"">
                        ");
#nullable restore
#line 20 "D:\Noi chua chat xam cua tui\DoAnTMDT\Views\Shared\ProductView\_ShowProduct.cshtml"
                   Write(product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </a>\r\n\r\n                    <span class=\"stext-105 cl3\">\r\n                        ");
#nullable restore
#line 24 "D:\Noi chua chat xam cua tui\DoAnTMDT\Views\Shared\ProductView\_ShowProduct.cshtml"
                   Write(product.ProductPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" $
                    </span>
                </div>

                <div class=""block2-txt-child2 flex-r p-t-3"">
                    <a href=""#"" class=""btn-addwish-b2 dis-block pos-relative js-addwish-b2"">
                        <img class=""icon-heart1 dis-block trans-04"" src=""images/icons/icon-heart-01.png"" alt=""ICON"">
                        <img class=""icon-heart2 dis-block trans-04 ab-t-l"" src=""images/icons/icon-heart-02.png"" alt=""ICON"">
                    </a>
                </div>
            </div>
        </div>
    </div>
");
#nullable restore
#line 53 "D:\Noi chua chat xam cua tui\DoAnTMDT\Views\Shared\ProductView\_ShowProduct.cshtml"
                

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
