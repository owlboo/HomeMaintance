#pragma checksum "C:\Users\MR-BOO\Documents\GitHub\HomeMaintance\HomeMaintance\Areas\Admin\Views\TypicalConstruction\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4853ce9d4ee3d6ce5817f476b160446311d3e667"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_TypicalConstruction_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/TypicalConstruction/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/TypicalConstruction/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_TypicalConstruction_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4853ce9d4ee3d6ce5817f476b160446311d3e667", @"/Areas/Admin/Views/TypicalConstruction/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3fb17c3e73a2d2520600855a3f42d5557a0e7d74", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_TypicalConstruction_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TypicalConstruction>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\MR-BOO\Documents\GitHub\HomeMaintance\HomeMaintance\Areas\Admin\Views\TypicalConstruction\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Admin/_LayoutAdmin.cshtml";

#line default
#line hidden
            BeginContext(133, 259, true);
            WriteLiteral(@"
<section class=""contact py-lg-5 py-md-4 py-md-3 py-2"">
    <div class=""container py-lg-5 py-md-4 py-md-3 py-2"">
        <div class=""w3_mg"">
            <h3>Danh sách công trình tiêu biểu</h3>
        </div>
        <div class=""offset-10"">
            ");
            EndContext();
            BeginContext(392, 107, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a0d2b1251c54441ba2b9d090175057ef", async() => {
                BeginContext(436, 59, true);
                WriteLiteral("<i class=\"fa fa-plus\"></i> &nbsp; Thêm công trình tiêu biểu");
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
            BeginContext(499, 196, true);
            WriteLiteral("\r\n        </div>\r\n        <div class=\"row\">\r\n            <table class=\"table table-striped\" style=\"font-size: 1em\">\r\n                <thead>\r\n                    <tr>\r\n                        <th>");
            EndContext();
            BeginContext(696, 32, false);
#line 19 "C:\Users\MR-BOO\Documents\GitHub\HomeMaintance\HomeMaintance\Areas\Admin\Views\TypicalConstruction\Index.cshtml"
                       Write(Html.DisplayNameFor(m => m.Name));

#line default
#line hidden
            EndContext();
            BeginContext(728, 35, true);
            WriteLiteral("</th>\r\n                        <th>");
            EndContext();
            BeginContext(764, 40, false);
#line 20 "C:\Users\MR-BOO\Documents\GitHub\HomeMaintance\HomeMaintance\Areas\Admin\Views\TypicalConstruction\Index.cshtml"
                       Write(Html.DisplayNameFor(m => m.CustomerName));

#line default
#line hidden
            EndContext();
            BeginContext(804, 35, true);
            WriteLiteral("</th>\r\n                        <th>");
            EndContext();
            BeginContext(840, 37, false);
#line 21 "C:\Users\MR-BOO\Documents\GitHub\HomeMaintance\HomeMaintance\Areas\Admin\Views\TypicalConstruction\Index.cshtml"
                       Write(Html.DisplayNameFor(m => m.Thumbnail));

#line default
#line hidden
            EndContext();
            BeginContext(877, 35, true);
            WriteLiteral("</th>\r\n                        <th>");
            EndContext();
            BeginContext(913, 35, false);
#line 22 "C:\Users\MR-BOO\Documents\GitHub\HomeMaintance\HomeMaintance\Areas\Admin\Views\TypicalConstruction\Index.cshtml"
                       Write(Html.DisplayNameFor(m => m.Address));

#line default
#line hidden
            EndContext();
            BeginContext(948, 35, true);
            WriteLiteral("</th>\r\n                        <th>");
            EndContext();
            BeginContext(984, 39, false);
#line 23 "C:\Users\MR-BOO\Documents\GitHub\HomeMaintance\HomeMaintance\Areas\Admin\Views\TypicalConstruction\Index.cshtml"
                       Write(Html.DisplayNameFor(m => m.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1023, 120, true);
            WriteLiteral("</th>\r\n                        <th></th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
            EndContext();
#line 28 "C:\Users\MR-BOO\Documents\GitHub\HomeMaintance\HomeMaintance\Areas\Admin\Views\TypicalConstruction\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(1208, 54, true);
            WriteLiteral("                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(1263, 31, false);
#line 31 "C:\Users\MR-BOO\Documents\GitHub\HomeMaintance\HomeMaintance\Areas\Admin\Views\TypicalConstruction\Index.cshtml"
                       Write(Html.DisplayFor(m => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1294, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1330, 39, false);
#line 32 "C:\Users\MR-BOO\Documents\GitHub\HomeMaintance\HomeMaintance\Areas\Admin\Views\TypicalConstruction\Index.cshtml"
                       Write(Html.DisplayFor(m => item.CustomerName));

#line default
#line hidden
            EndContext();
            BeginContext(1369, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1404, 76, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "01ac880f70284fc9a92d11288fc392ed", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1414, "~/images/TypicalImages/", 1414, 23, true);
#line 33 "C:\Users\MR-BOO\Documents\GitHub\HomeMaintance\HomeMaintance\Areas\Admin\Views\TypicalConstruction\Index.cshtml"
AddHtmlAttributeValue("", 1437, item.Thumbnail, 1437, 15, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1480, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1516, 34, false);
#line 34 "C:\Users\MR-BOO\Documents\GitHub\HomeMaintance\HomeMaintance\Areas\Admin\Views\TypicalConstruction\Index.cshtml"
                       Write(Html.DisplayFor(m => item.Address));

#line default
#line hidden
            EndContext();
            BeginContext(1550, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1586, 38, false);
#line 35 "C:\Users\MR-BOO\Documents\GitHub\HomeMaintance\HomeMaintance\Areas\Admin\Views\TypicalConstruction\Index.cshtml"
                       Write(Html.DisplayFor(m => item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1624, 195, true);
            WriteLiteral("</td>\r\n                        <td style=\"width:150px\">\r\n                            <div class=\"btn-group\" role=\"group\">\r\n                                <a type=\"button\" class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1819, "\"", 1854, 1);
#line 38 "C:\Users\MR-BOO\Documents\GitHub\HomeMaintance\HomeMaintance\Areas\Admin\Views\TypicalConstruction\Index.cshtml"
WriteAttributeValue("", 1826, Url.Action("Edit/"+item.Id), 1826, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1855, 105, true);
            WriteLiteral("><i class=\"fas fa-edit\"></i></a>\r\n                                <a type=\"button\" class=\"btn btn-danger\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1960, "\"", 1997, 1);
#line 39 "C:\Users\MR-BOO\Documents\GitHub\HomeMaintance\HomeMaintance\Areas\Admin\Views\TypicalConstruction\Index.cshtml"
WriteAttributeValue("", 1967, Url.Action("Delete/"+item.Id), 1967, 30, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1998, 213, true);
            WriteLiteral(" onclick=\"$(\'.top-alert\').notify(\'Delete success\', {position: \'top center\'});\"><i class=\"fas fa-trash-alt\"></i></a>\r\n                            </div>\r\n\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 44 "C:\Users\MR-BOO\Documents\GitHub\HomeMaintance\HomeMaintance\Areas\Admin\Views\TypicalConstruction\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(2230, 88, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TypicalConstruction>> Html { get; private set; }
    }
}
#pragma warning restore 1591
