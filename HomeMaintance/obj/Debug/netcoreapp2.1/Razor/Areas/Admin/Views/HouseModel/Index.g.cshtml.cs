#pragma checksum "C:\Users\MR-BOO\Documents\GitHub\HomeMaintance\HomeMaintance\Areas\Admin\Views\HouseModel\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b451e588a9768926b7e9405112c95513ebb02d4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_HouseModel_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/HouseModel/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/HouseModel/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_HouseModel_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b451e588a9768926b7e9405112c95513ebb02d4", @"/Areas/Admin/Views/HouseModel/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5f6aeb9979061b40e00ceea01da9755c2c3efc0", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_HouseModel_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<HouseModels>>
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
#line 2 "C:\Users\MR-BOO\Documents\GitHub\HomeMaintance\HomeMaintance\Areas\Admin\Views\HouseModel\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Admin/_LayoutAdmin.cshtml";

#line default
#line hidden
            BeginContext(118, 224, true);
            WriteLiteral("\r\n<section class=\"contact py-lg-5 py-md-4 py-md-3 py-2\">\r\n<div class=\"container py-lg-5 py-md-4 py-md-3 py-2\">\r\n    <div class=\"w3_mg\">\r\n        <h3>Bảng loại công việc</h3>\r\n    </div>\r\n    <div class=\"offset-10\">\r\n        ");
            EndContext();
            BeginContext(342, 86, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9331b7dca37b48f3aa6272c3cd3935be", async() => {
                BeginContext(386, 38, true);
                WriteLiteral("<i class=\"fa fa-plus\"></i> &nbsp; Thêm");
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
            BeginContext(428, 593, true);
            WriteLiteral(@"
    </div>
    <div class=""row"">
        <table class=""table table-striped"">
            <thead>
                <tr>
                    <th style=""width:20%;"">Tên mẫu nhà</th>
                    <th style=""width:20%;"">Danh mục</th>
                    <th style=""width:20%;"">Hình đại diện</th>
                    <th style=""width:20%;"">Mô tả</th>
                    <th style=""width:20%;"">Ngày tạo</th>
                    <th style=""width:20%;"">Ngày chỉnh sửa</th>
                    <th></th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 29 "C:\Users\MR-BOO\Documents\GitHub\HomeMaintance\HomeMaintance\Areas\Admin\Views\HouseModel\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(1086, 73, true);
            WriteLiteral("                    <tr>\r\n                        <td style=\"width:20%;\">");
            EndContext();
            BeginContext(1160, 41, false);
#line 32 "C:\Users\MR-BOO\Documents\GitHub\HomeMaintance\HomeMaintance\Areas\Admin\Views\HouseModel\Index.cshtml"
                                          Write(Html.DisplayFor(m => item.HouseModelName));

#line default
#line hidden
            EndContext();
            BeginContext(1201, 54, true);
            WriteLiteral("</td>\r\n                        <td style=\"width:20%;\">");
            EndContext();
            BeginContext(1256, 66, false);
#line 33 "C:\Users\MR-BOO\Documents\GitHub\HomeMaintance\HomeMaintance\Areas\Admin\Views\HouseModel\Index.cshtml"
                                          Write(Html.DisplayFor(m=>item.HouseModelCategory.HouseModelCategoryName));

#line default
#line hidden
            EndContext();
            BeginContext(1322, 39, true);
            WriteLiteral("</td>\r\n                        <td><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1361, "\"", 1387, 1);
#line 34 "C:\Users\MR-BOO\Documents\GitHub\HomeMaintance\HomeMaintance\Areas\Admin\Views\HouseModel\Index.cshtml"
WriteAttributeValue("", 1367, item.ImageThumbnail, 1367, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1388, 70, true);
            WriteLiteral(" width=\"50%;\" /></td>\r\n                        <td style=\"width:20%;\">");
            EndContext();
            BeginContext(1459, 36, false);
#line 35 "C:\Users\MR-BOO\Documents\GitHub\HomeMaintance\HomeMaintance\Areas\Admin\Views\HouseModel\Index.cshtml"
                                          Write(Html.DisplayFor(m=>item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1495, 54, true);
            WriteLiteral("</td>\r\n                        <td style=\"width:20%;\">");
            EndContext();
            BeginContext(1550, 36, false);
#line 36 "C:\Users\MR-BOO\Documents\GitHub\HomeMaintance\HomeMaintance\Areas\Admin\Views\HouseModel\Index.cshtml"
                                          Write(Html.DisplayFor(m=>item.CreatedDate));

#line default
#line hidden
            EndContext();
            BeginContext(1586, 54, true);
            WriteLiteral("</td>\r\n                        <td style=\"width:20%;\">");
            EndContext();
            BeginContext(1641, 37, false);
#line 37 "C:\Users\MR-BOO\Documents\GitHub\HomeMaintance\HomeMaintance\Areas\Admin\Views\HouseModel\Index.cshtml"
                                          Write(Html.DisplayFor(m=>item.ModifiedDate));

#line default
#line hidden
            EndContext();
            BeginContext(1678, 66, true);
            WriteLiteral("</td>\r\n                        <td >\r\n                            ");
            EndContext();
            BeginContext(1744, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "92cc383c382b46fdbaf1897d4d9b813f", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
#line 39 "C:\Users\MR-BOO\Documents\GitHub\HomeMaintance\HomeMaintance\Areas\Admin\Views\HouseModel\Index.cshtml"
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
            BeginContext(1799, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 42 "C:\Users\MR-BOO\Documents\GitHub\HomeMaintance\HomeMaintance\Areas\Admin\Views\HouseModel\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1878, 76, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n\r\n</div>\r\n</section>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<HouseModels>> Html { get; private set; }
    }
}
#pragma warning restore 1591
