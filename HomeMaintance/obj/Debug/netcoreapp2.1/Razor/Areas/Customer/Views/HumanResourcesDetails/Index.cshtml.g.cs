#pragma checksum "C:\Users\MR-BOO\Documents\GitHub\HomeMaintance\HomeMaintance\Areas\Customer\Views\HumanResourcesDetails\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e86e5c1099fe5fba4ebb1e5f67b6302d3724b8ad"
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
#line 1 "C:\Users\MR-BOO\Documents\GitHub\HomeMaintance\HomeMaintance\Areas\Customer\Views\_ViewImports.cshtml"
using HomeMaintance;

#line default
#line hidden
#line 3 "C:\Users\MR-BOO\Documents\GitHub\HomeMaintance\HomeMaintance\Areas\Customer\Views\HumanResourcesDetails\Index.cshtml"
using HomeMaintance.Models;

#line default
#line hidden
#line 2 "C:\Users\MR-BOO\Documents\GitHub\HomeMaintance\HomeMaintance\Areas\Customer\Views\HumanResourcesDetails\Index.cshtml"
using HomeMaintance.Reposity;

#line default
#line hidden
#line 4 "C:\Users\MR-BOO\Documents\GitHub\HomeMaintance\HomeMaintance\Areas\Customer\Views\HumanResourcesDetails\Index.cshtml"
using HomeMaintance.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e86e5c1099fe5fba4ebb1e5f67b6302d3724b8ad", @"/Areas/Customer/Views/HumanResourcesDetails/Index.cshtml")]
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
#line 5 "C:\Users\MR-BOO\Documents\GitHub\HomeMaintance\HomeMaintance\Areas\Customer\Views\HumanResourcesDetails\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Admin/_LayoutAdmin.cshtml";
    IUnitOfWork unitOfWork = (IUnitOfWork)ViewData["DbContext"];
    //var systemconf = unitOfWork.Repository<SystemConfig>().GetAll().FirstOrDefault();
    FooterViewModel footerView = new FooterViewModel
    {
        SystemConfigs = unitOfWork.Repository<SystemConfig>().GetAll().FirstOrDefault(),
        Services = unitOfWork.Repository<Services>().GetAll().Take(6).ToList()
    };
    //FooterViewModel ft = ViewBag.Footer;

#line default
#line hidden
            BeginContext(653, 172, true);
            WriteLiteral("\r\n<section class=\"contact py-lg-5 py-md-4 py-md-3 py-2\">\r\n    <div class=\"container py-lg-5 py-md-4 py-md-3 py-2\">\r\n        <div class=\"w3_mg\">\r\n            <h3>Thông tin #");
            EndContext();
            BeginContext(826, 16, false);
#line 21 "C:\Users\MR-BOO\Documents\GitHub\HomeMaintance\HomeMaintance\Areas\Customer\Views\HumanResourcesDetails\Index.cshtml"
                      Write(Model.PersonName);

#line default
#line hidden
            EndContext();
            BeginContext(842, 181, true);
            WriteLiteral("</h3>\r\n\r\n        </div>\r\n        <div class=\"p-4 border rounded\" style=\"font-size: 1.2em;\">\r\n            <div class=\"row\">\r\n                <div class=\"col-4\">\r\n                    ");
            EndContext();
            BeginContext(1023, 81, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "548d328fff424ce0940845e4fdffa5dc", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1033, "~/images/HumanImages/", 1033, 21, true);
#line 27 "C:\Users\MR-BOO\Documents\GitHub\HomeMaintance\HomeMaintance\Areas\Customer\Views\HumanResourcesDetails\Index.cshtml"
AddHtmlAttributeValue("", 1054, Model.Avatar, 1054, 13, false);

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
            BeginContext(1104, 204, true);
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-8\">\r\n                    <div class=\"row\">\r\n                        <div class=\"col-4\">Họ tên: </div>\r\n                        <div class=\"col-8\">");
            EndContext();
            BeginContext(1309, 16, false);
#line 32 "C:\Users\MR-BOO\Documents\GitHub\HomeMaintance\HomeMaintance\Areas\Customer\Views\HumanResourcesDetails\Index.cshtml"
                                      Write(Model.PersonName);

#line default
#line hidden
            EndContext();
            BeginContext(1325, 182, true);
            WriteLiteral("</div>\r\n                    </div>\r\n                    <div class=\"row\">\r\n                        <div class=\"col-4\">Kinh nghiệm: </div>\r\n                        <div class=\"col-8\">");
            EndContext();
            BeginContext(1508, 21, false);
#line 36 "C:\Users\MR-BOO\Documents\GitHub\HomeMaintance\HomeMaintance\Areas\Customer\Views\HumanResourcesDetails\Index.cshtml"
                                      Write(Model.ExperienceYears);

#line default
#line hidden
            EndContext();
            BeginContext(1529, 188, true);
            WriteLiteral(" năm</div>\r\n                    </div>\r\n                    <div class=\"row\">\r\n                        <div class=\"col-4\">Số điện thoại: </div>\r\n                        <div class=\"col-8\">");
            EndContext();
            BeginContext(1718, 17, false);
#line 40 "C:\Users\MR-BOO\Documents\GitHub\HomeMaintance\HomeMaintance\Areas\Customer\Views\HumanResourcesDetails\Index.cshtml"
                                      Write(Model.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(1735, 178, true);
            WriteLiteral("</div>\r\n                    </div>\r\n                    <div class=\"row\">\r\n                        <div class=\"col-4\">Vai trò: </div>\r\n                        <div class=\"col-8\">");
            EndContext();
            BeginContext(1914, 10, false);
#line 44 "C:\Users\MR-BOO\Documents\GitHub\HomeMaintance\HomeMaintance\Areas\Customer\Views\HumanResourcesDetails\Index.cshtml"
                                      Write(Model.Role);

#line default
#line hidden
            EndContext();
            BeginContext(1924, 217, true);
            WriteLiteral("</div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <br />\r\n            <br />\r\n            <div class=\"row\">\r\n                <div class=\"col-12\">Mô tả:</div>\r\n                ");
            EndContext();
            BeginContext(2142, 28, false);
#line 52 "C:\Users\MR-BOO\Documents\GitHub\HomeMaintance\HomeMaintance\Areas\Customer\Views\HumanResourcesDetails\Index.cshtml"
           Write(Html.Raw(@Model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(2170, 64, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n</section>\r\n");
            EndContext();
            BeginContext(2235, 64, false);
#line 58 "C:\Users\MR-BOO\Documents\GitHub\HomeMaintance\HomeMaintance\Areas\Customer\Views\HumanResourcesDetails\Index.cshtml"
Write(Html.Partial("~/Views/Shared/_FooterPartial.cshtml", footerView));

#line default
#line hidden
            EndContext();
            BeginContext(2299, 3, true);
            WriteLiteral(";\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2321, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 61 "C:\Users\MR-BOO\Documents\GitHub\HomeMaintance\HomeMaintance\Areas\Customer\Views\HumanResourcesDetails\Index.cshtml"
       await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
                BeginContext(2392, 140, true);
                WriteLiteral("    <script>\r\n        $(document).ready(function () {\r\n\r\n            $(\'#summernote\').summernote(\'disable\');\r\n\r\n        });\r\n    </script>\r\n");
                EndContext();
            }
            );
            BeginContext(2535, 2, true);
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
