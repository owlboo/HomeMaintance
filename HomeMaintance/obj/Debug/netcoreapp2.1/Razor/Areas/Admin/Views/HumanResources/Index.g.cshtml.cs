#pragma checksum "D:\Study\Visual Project\ASP.NET\HomeMaintance\HomeMaintance\Areas\Admin\Views\HumanResources\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "831f795269fd37cf5cf7e7b35bfbe3ea934d58af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_HumanResources_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/HumanResources/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/HumanResources/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_HumanResources_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"831f795269fd37cf5cf7e7b35bfbe3ea934d58af", @"/Areas/Admin/Views/HumanResources/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5f6aeb9979061b40e00ceea01da9755c2c3efc0", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_HumanResources_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<HumanResources>>
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
#line 2 "D:\Study\Visual Project\ASP.NET\HomeMaintance\HomeMaintance\Areas\Admin\Views\HumanResources\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Admin/_LayoutAdmin.cshtml";

#line default
#line hidden
            BeginContext(128, 243, true);
            WriteLiteral("\r\n<section class=\"contact py-lg-5 py-md-4 py-md-3 py-2\">\r\n    <div class=\"container py-lg-5 py-md-4 py-md-3 py-2\">\r\n        <div class=\"w3_mg\">\r\n            <h3>Bảng nhân công</h3>\r\n        </div>\r\n        <div class=\"offset-10\">\r\n            ");
            EndContext();
            BeginContext(371, 100, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13afedcbce99423081a85dffb0d5759b", async() => {
                BeginContext(415, 52, true);
                WriteLiteral("<i class=\"fa fa-plus\"></i> &nbsp; Thêm nhân công mới");
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
            BeginContext(471, 198, true);
            WriteLiteral("\r\n        </div>\r\n        <div class=\"row\">\r\n            <table class=\"table table-striped\" style=\"font-size: 1.2em\">\r\n                <thead>\r\n                    <tr>\r\n                        <th>");
            EndContext();
            BeginContext(670, 38, false);
#line 19 "D:\Study\Visual Project\ASP.NET\HomeMaintance\HomeMaintance\Areas\Admin\Views\HumanResources\Index.cshtml"
                       Write(Html.DisplayNameFor(m => m.PersonName));

#line default
#line hidden
            EndContext();
            BeginContext(708, 35, true);
            WriteLiteral("</th>\r\n                        <th>");
            EndContext();
            BeginContext(744, 43, false);
#line 20 "D:\Study\Visual Project\ASP.NET\HomeMaintance\HomeMaintance\Areas\Admin\Views\HumanResources\Index.cshtml"
                       Write(Html.DisplayNameFor(m => m.ExperienceYears));

#line default
#line hidden
            EndContext();
            BeginContext(787, 35, true);
            WriteLiteral("</th>\r\n                        <th>");
            EndContext();
            BeginContext(823, 39, false);
#line 21 "D:\Study\Visual Project\ASP.NET\HomeMaintance\HomeMaintance\Areas\Admin\Views\HumanResources\Index.cshtml"
                       Write(Html.DisplayNameFor(m => m.PhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(862, 35, true);
            WriteLiteral("</th>\r\n                        <th>");
            EndContext();
            BeginContext(898, 35, false);
#line 22 "D:\Study\Visual Project\ASP.NET\HomeMaintance\HomeMaintance\Areas\Admin\Views\HumanResources\Index.cshtml"
                       Write(Html.DisplayNameFor(m => m.Address));

#line default
#line hidden
            EndContext();
            BeginContext(933, 35, true);
            WriteLiteral("</th>\r\n                        <th>");
            EndContext();
            BeginContext(969, 32, false);
#line 23 "D:\Study\Visual Project\ASP.NET\HomeMaintance\HomeMaintance\Areas\Admin\Views\HumanResources\Index.cshtml"
                       Write(Html.DisplayNameFor(m => m.Role));

#line default
#line hidden
            EndContext();
            BeginContext(1001, 120, true);
            WriteLiteral("</th>\r\n                        <th></th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
            EndContext();
#line 28 "D:\Study\Visual Project\ASP.NET\HomeMaintance\HomeMaintance\Areas\Admin\Views\HumanResources\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(1186, 54, true);
            WriteLiteral("                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(1241, 37, false);
#line 31 "D:\Study\Visual Project\ASP.NET\HomeMaintance\HomeMaintance\Areas\Admin\Views\HumanResources\Index.cshtml"
                       Write(Html.DisplayFor(m => item.PersonName));

#line default
#line hidden
            EndContext();
            BeginContext(1278, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1314, 42, false);
#line 32 "D:\Study\Visual Project\ASP.NET\HomeMaintance\HomeMaintance\Areas\Admin\Views\HumanResources\Index.cshtml"
                       Write(Html.DisplayFor(m => item.ExperienceYears));

#line default
#line hidden
            EndContext();
            BeginContext(1356, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1392, 38, false);
#line 33 "D:\Study\Visual Project\ASP.NET\HomeMaintance\HomeMaintance\Areas\Admin\Views\HumanResources\Index.cshtml"
                       Write(Html.DisplayFor(m => item.PhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1430, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1466, 34, false);
#line 34 "D:\Study\Visual Project\ASP.NET\HomeMaintance\HomeMaintance\Areas\Admin\Views\HumanResources\Index.cshtml"
                       Write(Html.DisplayFor(m => item.Address));

#line default
#line hidden
            EndContext();
            BeginContext(1500, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1536, 31, false);
#line 35 "D:\Study\Visual Project\ASP.NET\HomeMaintance\HomeMaintance\Areas\Admin\Views\HumanResources\Index.cshtml"
                       Write(Html.DisplayFor(m => item.Role));

#line default
#line hidden
            EndContext();
            BeginContext(1567, 65, true);
            WriteLiteral("</td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1632, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c48b2432fb0949e5bdc82557a1e82186", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
#line 37 "D:\Study\Visual Project\ASP.NET\HomeMaintance\HomeMaintance\Areas\Admin\Views\HumanResources\Index.cshtml"
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
            BeginContext(1687, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 40 "D:\Study\Visual Project\ASP.NET\HomeMaintance\HomeMaintance\Areas\Admin\Views\HumanResources\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1766, 94, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n\r\n    </div>\r\n</section>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<HumanResources>> Html { get; private set; }
    }
}
#pragma warning restore 1591
