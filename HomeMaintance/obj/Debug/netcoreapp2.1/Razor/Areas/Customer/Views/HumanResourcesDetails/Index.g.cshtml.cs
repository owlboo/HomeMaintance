#pragma checksum "D:\Study\Visual Project\ASP.NET\HomeMaintance\HomeMaintance\Areas\Customer\Views\HumanResourcesDetails\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "79ff6f7c05c24019d8e655d2477be41d3853db6b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_HumanResourcesDetails_Index), @"mvc.1.0.view", @"/Areas/Customer/Views/HumanResourcesDetails/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Customer/Views/HumanResourcesDetails/Index.cshtml", typeof(AspNetCore.Areas_Customer_Views_HumanResourcesDetails_Index))]
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
#line 1 "D:\Study\Visual Project\ASP.NET\HomeMaintance\HomeMaintance\Areas\Customer\Views\_ViewImports.cshtml"
using HomeMaintance;

#line default
#line hidden
#line 2 "D:\Study\Visual Project\ASP.NET\HomeMaintance\HomeMaintance\Areas\Customer\Views\_ViewImports.cshtml"
using HomeMaintance.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79ff6f7c05c24019d8e655d2477be41d3853db6b", @"/Areas/Customer/Views/HumanResourcesDetails/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5f6aeb9979061b40e00ceea01da9755c2c3efc0", @"/Areas/Customer/Views/_ViewImports.cshtml")]
    public class Areas_Customer_Views_HumanResourcesDetails_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HumanResources>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded-circle img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Study\Visual Project\ASP.NET\HomeMaintance\HomeMaintance\Areas\Customer\Views\HumanResourcesDetails\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Admin/_LayoutAdmin.cshtml";

#line default
#line hidden
            BeginContext(115, 172, true);
            WriteLiteral("\r\n<section class=\"contact py-lg-5 py-md-4 py-md-3 py-2\">\r\n    <div class=\"container py-lg-5 py-md-4 py-md-3 py-2\">\r\n        <div class=\"w3_mg\">\r\n            <h3>Thông tin #");
            EndContext();
            BeginContext(288, 16, false);
#line 10 "D:\Study\Visual Project\ASP.NET\HomeMaintance\HomeMaintance\Areas\Customer\Views\HumanResourcesDetails\Index.cshtml"
                      Write(Model.PersonName);

#line default
#line hidden
            EndContext();
            BeginContext(304, 181, true);
            WriteLiteral("</h3>\r\n\r\n        </div>\r\n        <div class=\"p-4 border rounded\" style=\"font-size: 1.2em;\">\r\n            <div class=\"row\">\r\n                <div class=\"col-4\">\r\n                    ");
            EndContext();
            BeginContext(485, 80, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4c5796ddcd1c46008f8a5eb4fa617808", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 495, "~/images/HumanImages/", 495, 21, true);
#line 16 "D:\Study\Visual Project\ASP.NET\HomeMaintance\HomeMaintance\Areas\Customer\Views\HumanResourcesDetails\Index.cshtml"
AddHtmlAttributeValue("", 516, Model.Avatar, 516, 13, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(565, 204, true);
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-8\">\r\n                    <div class=\"row\">\r\n                        <div class=\"col-4\">Họ tên: </div>\r\n                        <div class=\"col-8\">");
            EndContext();
            BeginContext(770, 16, false);
#line 21 "D:\Study\Visual Project\ASP.NET\HomeMaintance\HomeMaintance\Areas\Customer\Views\HumanResourcesDetails\Index.cshtml"
                                      Write(Model.PersonName);

#line default
#line hidden
            EndContext();
            BeginContext(786, 182, true);
            WriteLiteral("</div>\r\n                    </div>\r\n                    <div class=\"row\">\r\n                        <div class=\"col-4\">Kinh nghiệm: </div>\r\n                        <div class=\"col-8\">");
            EndContext();
            BeginContext(969, 21, false);
#line 25 "D:\Study\Visual Project\ASP.NET\HomeMaintance\HomeMaintance\Areas\Customer\Views\HumanResourcesDetails\Index.cshtml"
                                      Write(Model.ExperienceYears);

#line default
#line hidden
            EndContext();
            BeginContext(990, 188, true);
            WriteLiteral(" năm</div>\r\n                    </div>\r\n                    <div class=\"row\">\r\n                        <div class=\"col-4\">Số điện thoại: </div>\r\n                        <div class=\"col-8\">");
            EndContext();
            BeginContext(1179, 17, false);
#line 29 "D:\Study\Visual Project\ASP.NET\HomeMaintance\HomeMaintance\Areas\Customer\Views\HumanResourcesDetails\Index.cshtml"
                                      Write(Model.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(1196, 178, true);
            WriteLiteral("</div>\r\n                    </div>\r\n                    <div class=\"row\">\r\n                        <div class=\"col-4\">Vai trò: </div>\r\n                        <div class=\"col-8\">");
            EndContext();
            BeginContext(1375, 10, false);
#line 33 "D:\Study\Visual Project\ASP.NET\HomeMaintance\HomeMaintance\Areas\Customer\Views\HumanResourcesDetails\Index.cshtml"
                                      Write(Model.Role);

#line default
#line hidden
            EndContext();
            BeginContext(1385, 217, true);
            WriteLiteral("</div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <br />\r\n            <br />\r\n            <div class=\"row\">\r\n                <div class=\"col-12\">Mô tả:</div>\r\n                ");
            EndContext();
            BeginContext(1603, 28, false);
#line 41 "D:\Study\Visual Project\ASP.NET\HomeMaintance\HomeMaintance\Areas\Customer\Views\HumanResourcesDetails\Index.cshtml"
           Write(Html.Raw(@Model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1631, 64, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n</section>\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1714, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 49 "D:\Study\Visual Project\ASP.NET\HomeMaintance\HomeMaintance\Areas\Customer\Views\HumanResourcesDetails\Index.cshtml"
       await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
                BeginContext(1785, 140, true);
                WriteLiteral("    <script>\r\n        $(document).ready(function () {\r\n\r\n            $(\'#summernote\').summernote(\'disable\');\r\n\r\n        });\r\n    </script>\r\n");
                EndContext();
            }
            );
            BeginContext(1928, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HumanResources> Html { get; private set; }
    }
}
#pragma warning restore 1591
