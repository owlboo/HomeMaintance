#pragma checksum "D:\Study\Visual Project\ASP.NET\HomeMaintance\HomeMaintance\Areas\Admin\Views\HouseModelCategory\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1518dd9ca2f4fdc22b2fe51563e5dc487faf477e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_HouseModelCategory_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/HouseModelCategory/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/HouseModelCategory/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_HouseModelCategory_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1518dd9ca2f4fdc22b2fe51563e5dc487faf477e", @"/Areas/Admin/Views/HouseModelCategory/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5f6aeb9979061b40e00ceea01da9755c2c3efc0", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_HouseModelCategory_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<HouseModelCategory>>
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
#line 2 "D:\Study\Visual Project\ASP.NET\HomeMaintance\HomeMaintance\Areas\Admin\Views\HouseModelCategory\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Admin/_LayoutAdmin.cshtml";

#line default
#line hidden
            BeginContext(132, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(198, 214, true);
            WriteLiteral("        <div class=\"container py-lg-5 py-md-4 py-md-3 py-2\">\r\n            <div class=\"w3_mg\">\r\n                <h3>Bảng loại công việc</h3>\r\n            </div>\r\n            <div class=\"offset-10\">\r\n                ");
            EndContext();
            BeginContext(412, 91, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71b822f6ad534ee48e097ee8defb9143", async() => {
                BeginContext(456, 43, true);
                WriteLiteral("<i class=\"fa fa-plus\"></i> &nbsp; Thêm mới");
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
            BeginContext(503, 461, true);
            WriteLiteral(@"
            </div>
            <div class=""row"">
                <table class=""table table-striped"">
                    <thead>
                        <tr>
                            <th>Tên danh mục mẫu nhà</th>
                            <th>Ngày tạo</th>
                            <th>Ngày chỉnh sửa</th>
                            <th></th>
                        </tr>
                    </thead>
                    <tbody>
");
            EndContext();
#line 26 "D:\Study\Visual Project\ASP.NET\HomeMaintance\HomeMaintance\Areas\Admin\Views\HouseModelCategory\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
            BeginContext(1045, 70, true);
            WriteLiteral("                            <tr>\r\n                                <td>");
            EndContext();
            BeginContext(1116, 49, false);
#line 29 "D:\Study\Visual Project\ASP.NET\HomeMaintance\HomeMaintance\Areas\Admin\Views\HouseModelCategory\Index.cshtml"
                               Write(Html.DisplayFor(m => item.HouseModelCategoryName));

#line default
#line hidden
            EndContext();
            BeginContext(1165, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(1209, 38, false);
#line 30 "D:\Study\Visual Project\ASP.NET\HomeMaintance\HomeMaintance\Areas\Admin\Views\HouseModelCategory\Index.cshtml"
                               Write(Html.DisplayFor(m => item.CreatedDate));

#line default
#line hidden
            EndContext();
            BeginContext(1247, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(1291, 37, false);
#line 31 "D:\Study\Visual Project\ASP.NET\HomeMaintance\HomeMaintance\Areas\Admin\Views\HouseModelCategory\Index.cshtml"
                               Write(Html.DisplayFor(m=>item.ModifiedDate));

#line default
#line hidden
            EndContext();
            BeginContext(1328, 113, true);
            WriteLiteral("</td>                                \r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(1441, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "373e5f379cbb4de182ff3c42e3fdae9f", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
#line 33 "D:\Study\Visual Project\ASP.NET\HomeMaintance\HomeMaintance\Areas\Admin\Views\HouseModelCategory\Index.cshtml"
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
            BeginContext(1496, 76, true);
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
            EndContext();
#line 36 "D:\Study\Visual Project\ASP.NET\HomeMaintance\HomeMaintance\Areas\Admin\Views\HouseModelCategory\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(1599, 94, true);
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n\r\n        </div>\r\n");
            EndContext();
            BeginContext(1713, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<HouseModelCategory>> Html { get; private set; }
    }
}
#pragma warning restore 1591
