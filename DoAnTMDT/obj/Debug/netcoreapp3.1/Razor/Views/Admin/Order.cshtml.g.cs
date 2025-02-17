#pragma checksum "D:\Noi chua chat xam cua tui\DoAnTMDT\Views\Admin\Order.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "856bbe4bb1f62d49d8f11bf7d8a1174f01c5a29f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Order), @"mvc.1.0.view", @"/Views/Admin/Order.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"856bbe4bb1f62d49d8f11bf7d8a1174f01c5a29f", @"/Views/Admin/Order.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3637e389f18fe28ba1e16562545f4d94ae190a8e", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Order : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DoAnTMDT.Models.Cart>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Noi chua chat xam cua tui\DoAnTMDT\Views\Admin\Order.cshtml"
  
    ViewData["Title"] = "Order";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Danh sách hóa đơn</h1>\r\n\r\n");
            WriteLiteral("<table class=\"table\" id=\"order_tbl\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n");
            WriteLiteral("                Mã đơn hàng\r\n            </th>\r\n            <th>\r\n");
            WriteLiteral("                Mã khách hàng\r\n            </th>\r\n            <th>\r\n");
            WriteLiteral("                Thanh toán\r\n            </th>\r\n            <th>\r\n");
            WriteLiteral("                Ngày mua\r\n            </th>\r\n            <th>\r\n");
            WriteLiteral("                Ngày trả tiền\r\n            </th>\r\n            <th>\r\n");
            WriteLiteral("                Tình trạng ĐH\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 43 "D:\Noi chua chat xam cua tui\DoAnTMDT\Views\Admin\Order.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 47 "D:\Noi chua chat xam cua tui\DoAnTMDT\Views\Admin\Order.cshtml"
               Write(Html.DisplayFor(modelItem => item.CartID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                 <td>\r\n                    ");
#nullable restore
#line 50 "D:\Noi chua chat xam cua tui\DoAnTMDT\Views\Admin\Order.cshtml"
               Write(Html.DisplayFor(modelItem => item.UserID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 53 "D:\Noi chua chat xam cua tui\DoAnTMDT\Views\Admin\Order.cshtml"
               Write(Html.DisplayFor(modelItem => item.IsPayed));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 56 "D:\Noi chua chat xam cua tui\DoAnTMDT\Views\Admin\Order.cshtml"
               Write(Html.DisplayFor(modelItem => item.OderDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 59 "D:\Noi chua chat xam cua tui\DoAnTMDT\Views\Admin\Order.cshtml"
               Write(Html.DisplayFor(modelItem => item.PayDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 62 "D:\Noi chua chat xam cua tui\DoAnTMDT\Views\Admin\Order.cshtml"
               Write(Html.DisplayFor(modelItem => item.IsCompleted));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 65 "D:\Noi chua chat xam cua tui\DoAnTMDT\Views\Admin\Order.cshtml"
               Write(Html.ActionLink("Chi tiết", "DetailOrder", new { id = item.CartID }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 72 "D:\Noi chua chat xam cua tui\DoAnTMDT\Views\Admin\Order.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        $(document).ready(function () {\r\n            $(\'#order_tbl\').DataTable();\r\n        });\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DoAnTMDT.Models.Cart>> Html { get; private set; }
    }
}
#pragma warning restore 1591
