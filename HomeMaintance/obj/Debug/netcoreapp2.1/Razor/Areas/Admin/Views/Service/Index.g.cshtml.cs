#pragma checksum "D:\Study\Visual Project\ASP.NET\HomeMaintance\HomeMaintance\Areas\Admin\Views\Service\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "611643f85e84f3b31c18a87af19c2b50cb3b3455"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Service_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Service/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Service/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Service_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"611643f85e84f3b31c18a87af19c2b50cb3b3455", @"/Areas/Admin/Views/Service/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5f6aeb9979061b40e00ceea01da9755c2c3efc0", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Service_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Services>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_TableButtonPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Study\Visual Project\ASP.NET\HomeMaintance\HomeMaintance\Areas\Admin\Views\Service\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(118, 239, true);
            WriteLiteral("<section class=\"contact py-lg-5 py-md-4 py-md-3 py-2\">\r\n    <div class=\"container py-lg-5 py-md-4 py-md-3 py-2\">\r\n        <div class=\"w3_mg\">\r\n            <h3>Bảng dịch vụ</h3>\r\n        </div>\r\n        <div class=\"offset-10\">\r\n            ");
            EndContext();
            BeginContext(357, 98, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62a37dabb9504cbb87d394a9eb8efc24", async() => {
                BeginContext(401, 50, true);
                WriteLiteral("<i class=\"fa fa-plus\"></i> &nbsp; Thêm dịch vụ mới");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(455, 198, true);
            WriteLiteral("\r\n        </div>\r\n        <div class=\"row\">\r\n            <table class=\"table table-striped\" style=\"font-size: 1.2em\">\r\n                <thead>\r\n                    <tr>\r\n                        <th>");
            EndContext();
            BeginContext(654, 39, false);
#line 18 "D:\Study\Visual Project\ASP.NET\HomeMaintance\HomeMaintance\Areas\Admin\Views\Service\Index.cshtml"
                       Write(Html.DisplayNameFor(m => m.ServiceName));

#line default
#line hidden
            EndContext();
            BeginContext(693, 35, true);
            WriteLiteral("</th>\r\n                        <th>");
            EndContext();
            BeginContext(729, 37, false);
#line 19 "D:\Study\Visual Project\ASP.NET\HomeMaintance\HomeMaintance\Areas\Admin\Views\Service\Index.cshtml"
                       Write(Html.DisplayNameFor(m => m.MetaTitle));

#line default
#line hidden
            EndContext();
            BeginContext(766, 35, true);
            WriteLiteral("</th>\r\n                        <th>");
            EndContext();
            BeginContext(802, 39, false);
#line 20 "D:\Study\Visual Project\ASP.NET\HomeMaintance\HomeMaintance\Areas\Admin\Views\Service\Index.cshtml"
                       Write(Html.DisplayNameFor(m => m.CreatedDate));

#line default
#line hidden
            EndContext();
            BeginContext(841, 35, true);
            WriteLiteral("</th>\r\n                        <th>");
            EndContext();
            BeginContext(877, 40, false);
#line 21 "D:\Study\Visual Project\ASP.NET\HomeMaintance\HomeMaintance\Areas\Admin\Views\Service\Index.cshtml"
                       Write(Html.DisplayNameFor(m => m.ModifiedDate));

#line default
#line hidden
            EndContext();
            BeginContext(917, 35, true);
            WriteLiteral("</th>\r\n                        <th>");
            EndContext();
            BeginContext(953, 49, false);
#line 22 "D:\Study\Visual Project\ASP.NET\HomeMaintance\HomeMaintance\Areas\Admin\Views\Service\Index.cshtml"
                       Write(Html.DisplayNameFor(m => m.Category.CategoryName));

#line default
#line hidden
            EndContext();
            BeginContext(1002, 120, true);
            WriteLiteral("</th>\r\n                        <th></th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
            EndContext();
#line 27 "D:\Study\Visual Project\ASP.NET\HomeMaintance\HomeMaintance\Areas\Admin\Views\Service\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
            BeginContext(1195, 62, true);
            WriteLiteral("                        <tr>\r\n                            <td>");
            EndContext();
            BeginContext(1258, 38, false);
#line 30 "D:\Study\Visual Project\ASP.NET\HomeMaintance\HomeMaintance\Areas\Admin\Views\Service\Index.cshtml"
                           Write(Html.DisplayFor(m => item.ServiceName));

#line default
#line hidden
            EndContext();
            BeginContext(1296, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1336, 36, false);
#line 31 "D:\Study\Visual Project\ASP.NET\HomeMaintance\HomeMaintance\Areas\Admin\Views\Service\Index.cshtml"
                           Write(Html.DisplayFor(m => item.MetaTitle));

#line default
#line hidden
            EndContext();
            BeginContext(1372, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1412, 30, false);
#line 32 "D:\Study\Visual Project\ASP.NET\HomeMaintance\HomeMaintance\Areas\Admin\Views\Service\Index.cshtml"
                           Write(item.CreatedDate.ToString("d"));

#line default
#line hidden
            EndContext();
            BeginContext(1442, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1482, 31, false);
#line 33 "D:\Study\Visual Project\ASP.NET\HomeMaintance\HomeMaintance\Areas\Admin\Views\Service\Index.cshtml"
                           Write(item.ModifiedDate.ToString("d"));

#line default
#line hidden
            EndContext();
            BeginContext(1513, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1553, 48, false);
#line 34 "D:\Study\Visual Project\ASP.NET\HomeMaintance\HomeMaintance\Areas\Admin\Views\Service\Index.cshtml"
                           Write(Html.DisplayFor(m => item.Category.CategoryName));

#line default
#line hidden
            EndContext();
            BeginContext(1601, 73, true);
            WriteLiteral("</td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(1674, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "81b680fcacd94b0280ce3900aea50530", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
#line 36 "D:\Study\Visual Project\ASP.NET\HomeMaintance\HomeMaintance\Areas\Admin\Views\Service\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = item.Id;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1729, 68, true);
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 39 "D:\Study\Visual Project\ASP.NET\HomeMaintance\HomeMaintance\Areas\Admin\Views\Service\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(1820, 92, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n\r\n    </div>\r\n</section>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Services>> Html { get; private set; }
    }
}
#pragma warning restore 1591