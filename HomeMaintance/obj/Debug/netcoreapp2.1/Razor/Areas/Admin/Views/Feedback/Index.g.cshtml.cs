#pragma checksum "D:\Study\Visual Project\ASP.NET\HomeMaintance\HomeMaintance\Areas\Admin\Views\Feedback\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba9d7afb5a11ef45543e882cb9d00c6265160129"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Feedback_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Feedback/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Feedback/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Feedback_Index))]
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
#line 1 "D:\Study\Visual Project\ASP.NET\HomeMaintance\HomeMaintance\Areas\Admin\Views\_ViewImports.cshtml"
using HomeMaintance;

#line default
#line hidden
#line 2 "D:\Study\Visual Project\ASP.NET\HomeMaintance\HomeMaintance\Areas\Admin\Views\_ViewImports.cshtml"
using HomeMaintance.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba9d7afb5a11ef45543e882cb9d00c6265160129", @"/Areas/Admin/Views/Feedback/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5f6aeb9979061b40e00ceea01da9755c2c3efc0", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Feedback_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<HomeMaintance.Models.Feedback>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(51, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Study\Visual Project\ASP.NET\HomeMaintance\HomeMaintance\Areas\Admin\Views\Feedback\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Admin/_LayoutAdmin.cshtml";

#line default
#line hidden
            BeginContext(145, 367, true);
            WriteLiteral(@"<section class=""contact py-lg-5 py-md-4 py-md-3 py-2"">
    <div class=""container py-lg-5 py-md-4 py-md-3 py-2"">
        <div class=""w3_mg"">
            <h3>Bảng phản hồi</h3>
        </div>
        <div class=""row"">
            <table class=""table"""">
                <thead>
                    <tr>
                        <th>
                            ");
            EndContext();
            BeginContext(513, 46, false);
#line 17 "D:\Study\Visual Project\ASP.NET\HomeMaintance\HomeMaintance\Areas\Admin\Views\Feedback\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.SenderName));

#line default
#line hidden
            EndContext();
            BeginContext(559, 91, true);
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
            EndContext();
            BeginContext(651, 43, false);
#line 20 "D:\Study\Visual Project\ASP.NET\HomeMaintance\HomeMaintance\Areas\Admin\Views\Feedback\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.Content));

#line default
#line hidden
            EndContext();
            BeginContext(694, 91, true);
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
            EndContext();
            BeginContext(786, 47, false);
#line 23 "D:\Study\Visual Project\ASP.NET\HomeMaintance\HomeMaintance\Areas\Admin\Views\Feedback\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.CreatedDate));

#line default
#line hidden
            EndContext();
            BeginContext(833, 91, true);
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
            EndContext();
            BeginContext(925, 41, false);
#line 26 "D:\Study\Visual Project\ASP.NET\HomeMaintance\HomeMaintance\Areas\Admin\Views\Feedback\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(966, 91, true);
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
            EndContext();
            BeginContext(1058, 41, false);
#line 29 "D:\Study\Visual Project\ASP.NET\HomeMaintance\HomeMaintance\Areas\Admin\Views\Feedback\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(1099, 146, true);
            WriteLiteral("\r\n                        </th>\r\n                        <th></th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
            EndContext();
#line 35 "D:\Study\Visual Project\ASP.NET\HomeMaintance\HomeMaintance\Areas\Admin\Views\Feedback\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
            BeginContext(1318, 96, true);
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(1415, 45, false);
#line 39 "D:\Study\Visual Project\ASP.NET\HomeMaintance\HomeMaintance\Areas\Admin\Views\Feedback\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.SenderName));

#line default
#line hidden
            EndContext();
            BeginContext(1460, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(1564, 42, false);
#line 42 "D:\Study\Visual Project\ASP.NET\HomeMaintance\HomeMaintance\Areas\Admin\Views\Feedback\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Content));

#line default
#line hidden
            EndContext();
            BeginContext(1606, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(1710, 30, false);
#line 45 "D:\Study\Visual Project\ASP.NET\HomeMaintance\HomeMaintance\Areas\Admin\Views\Feedback\Index.cshtml"
                           Write(item.CreatedDate.ToString("d"));

#line default
#line hidden
            EndContext();
            BeginContext(1740, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(1844, 40, false);
#line 48 "D:\Study\Visual Project\ASP.NET\HomeMaintance\HomeMaintance\Areas\Admin\Views\Feedback\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1884, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(1988, 40, false);
#line 51 "D:\Study\Visual Project\ASP.NET\HomeMaintance\HomeMaintance\Areas\Admin\Views\Feedback\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(2028, 68, true);
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 54 "D:\Study\Visual Project\ASP.NET\HomeMaintance\HomeMaintance\Areas\Admin\Views\Feedback\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(2119, 90, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<HomeMaintance.Models.Feedback>> Html { get; private set; }
    }
}
#pragma warning restore 1591
