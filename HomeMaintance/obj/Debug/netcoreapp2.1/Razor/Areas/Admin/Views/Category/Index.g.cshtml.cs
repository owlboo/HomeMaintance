#pragma checksum "C:\Users\MR-BOO\Documents\GitHub\HomeMaintance\HomeMaintance\Areas\Admin\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "37be71b6379f5367e9bd4e7e6abbdf6c74e3fe82"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Category_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Category/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Category/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Category_Index))]
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
#line 1 "C:\Users\MR-BOO\Documents\GitHub\HomeMaintance\HomeMaintance\Areas\Admin\Views\_ViewImports.cshtml"
using HomeMaintance;

#line default
#line hidden
#line 2 "C:\Users\MR-BOO\Documents\GitHub\HomeMaintance\HomeMaintance\Areas\Admin\Views\_ViewImports.cshtml"
using HomeMaintance.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37be71b6379f5367e9bd4e7e6abbdf6c74e3fe82", @"/Areas/Admin/Views/Category/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5f6aeb9979061b40e00ceea01da9755c2c3efc0", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Category>>
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
#line 2 "C:\Users\MR-BOO\Documents\GitHub\HomeMaintance\HomeMaintance\Areas\Admin\Views\Category\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Admin/_LayoutAdmin.cshtml";

#line default
#line hidden
            BeginContext(122, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(184, 190, true);
            WriteLiteral("    <div class=\"container py-lg-5 py-md-4 py-md-3 py-2\">\r\n        <div class=\"w3_mg\">\r\n            <h3>Bảng loại công việc</h3>\r\n        </div>\r\n        <div class=\"offset-10\">\r\n            ");
            EndContext();
            BeginContext(374, 101, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b6a0c68346144f178b252e97aac10995", async() => {
                BeginContext(418, 53, true);
                WriteLiteral("<i class=\"fa fa-plus\"></i> &nbsp; Thêm loại mẫu nhà");
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
            BeginContext(475, 198, true);
            WriteLiteral("\r\n        </div>\r\n        <div class=\"row\">\r\n            <table class=\"table table-striped\" style=\"font-size: 1.2em\">\r\n                <thead>\r\n                    <tr>\r\n                        <th>");
            EndContext();
            BeginContext(674, 40, false);
#line 19 "C:\Users\MR-BOO\Documents\GitHub\HomeMaintance\HomeMaintance\Areas\Admin\Views\Category\Index.cshtml"
                       Write(Html.DisplayNameFor(m => m.CategoryName));

#line default
#line hidden
            EndContext();
            BeginContext(714, 35, true);
            WriteLiteral("</th>\r\n                        <th>");
            EndContext();
            BeginContext(750, 37, false);
#line 20 "C:\Users\MR-BOO\Documents\GitHub\HomeMaintance\HomeMaintance\Areas\Admin\Views\Category\Index.cshtml"
                       Write(Html.DisplayNameFor(m => m.MetaTitle));

#line default
#line hidden
            EndContext();
            BeginContext(787, 35, true);
            WriteLiteral("</th>\r\n                        <th>");
            EndContext();
            BeginContext(823, 39, false);
#line 21 "C:\Users\MR-BOO\Documents\GitHub\HomeMaintance\HomeMaintance\Areas\Admin\Views\Category\Index.cshtml"
                       Write(Html.DisplayNameFor(m => m.CreatedDate));

#line default
#line hidden
            EndContext();
            BeginContext(862, 35, true);
            WriteLiteral("</th>\r\n                        <th>");
            EndContext();
            BeginContext(898, 40, false);
#line 22 "C:\Users\MR-BOO\Documents\GitHub\HomeMaintance\HomeMaintance\Areas\Admin\Views\Category\Index.cshtml"
                       Write(Html.DisplayNameFor(m => m.ModifiedDate));

#line default
#line hidden
            EndContext();
            BeginContext(938, 120, true);
            WriteLiteral("</th>\r\n                        <th></th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
            EndContext();
#line 27 "C:\Users\MR-BOO\Documents\GitHub\HomeMaintance\HomeMaintance\Areas\Admin\Views\Category\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
            BeginContext(1131, 62, true);
            WriteLiteral("                        <tr>\r\n                            <td>");
            EndContext();
            BeginContext(1194, 39, false);
#line 30 "C:\Users\MR-BOO\Documents\GitHub\HomeMaintance\HomeMaintance\Areas\Admin\Views\Category\Index.cshtml"
                           Write(Html.DisplayFor(m => item.CategoryName));

#line default
#line hidden
            EndContext();
            BeginContext(1233, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1273, 36, false);
#line 31 "C:\Users\MR-BOO\Documents\GitHub\HomeMaintance\HomeMaintance\Areas\Admin\Views\Category\Index.cshtml"
                           Write(Html.DisplayFor(m => item.MetaTitle));

#line default
#line hidden
            EndContext();
            BeginContext(1309, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1349, 30, false);
#line 32 "C:\Users\MR-BOO\Documents\GitHub\HomeMaintance\HomeMaintance\Areas\Admin\Views\Category\Index.cshtml"
                           Write(item.CreatedDate.ToString("d"));

#line default
#line hidden
            EndContext();
            BeginContext(1379, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1419, 31, false);
#line 33 "C:\Users\MR-BOO\Documents\GitHub\HomeMaintance\HomeMaintance\Areas\Admin\Views\Category\Index.cshtml"
                           Write(item.ModifiedDate.ToString("d"));

#line default
#line hidden
            EndContext();
            BeginContext(1450, 73, true);
            WriteLiteral("</td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(1523, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "05c1dd1abd7f46e797c998ca3af98028", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
#line 35 "C:\Users\MR-BOO\Documents\GitHub\HomeMaintance\HomeMaintance\Areas\Admin\Views\Category\Index.cshtml"
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
            BeginContext(1578, 68, true);
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 38 "C:\Users\MR-BOO\Documents\GitHub\HomeMaintance\HomeMaintance\Areas\Admin\Views\Category\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(1669, 78, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n\r\n    </div>\r\n");
            EndContext();
            BeginContext(1763, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
