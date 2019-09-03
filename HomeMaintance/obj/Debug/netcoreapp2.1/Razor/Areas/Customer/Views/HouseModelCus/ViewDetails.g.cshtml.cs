#pragma checksum "C:\Users\MR-BOO\Documents\GitHub\HomeMaintance\HomeMaintance\Areas\Customer\Views\HouseModelCus\ViewDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22ad8290494cd49392ddb6528113cd676cc989f8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_HouseModelCus_ViewDetails), @"mvc.1.0.view", @"/Areas/Customer/Views/HouseModelCus/ViewDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Customer/Views/HouseModelCus/ViewDetails.cshtml", typeof(AspNetCore.Areas_Customer_Views_HouseModelCus_ViewDetails))]
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
#line 3 "C:\Users\MR-BOO\Documents\GitHub\HomeMaintance\HomeMaintance\Areas\Customer\Views\HouseModelCus\ViewDetails.cshtml"
using HomeMaintance.Models;

#line default
#line hidden
#line 2 "C:\Users\MR-BOO\Documents\GitHub\HomeMaintance\HomeMaintance\Areas\Customer\Views\HouseModelCus\ViewDetails.cshtml"
using HomeMaintance.Reposity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22ad8290494cd49392ddb6528113cd676cc989f8", @"/Areas/Customer/Views/HouseModelCus/ViewDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5f6aeb9979061b40e00ceea01da9755c2c3efc0", @"/Areas/Customer/Views/_ViewImports.cshtml")]
    public class Areas_Customer_Views_HouseModelCus_ViewDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeMaintance.Models.ViewModels.HouseModelDetails>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "C:\Users\MR-BOO\Documents\GitHub\HomeMaintance\HomeMaintance\Areas\Customer\Views\HouseModelCus\ViewDetails.cshtml"
  
    ViewData["Title"] = "ViewDetails";
    Layout = "~/Views/Shared/_Layout.cshtml";
    IUnitOfWork unitOfWork = (IUnitOfWork)ViewData["DbContext"];
    var systemconf = unitOfWork.Repository<SystemConfig>().GetAll().FirstOrDefault();

#line default
#line hidden
            BeginContext(365, 193, true);
            WriteLiteral("\r\n<section class=\"contact py-lg-5 py-md-4 py-md-3 py-2\">\r\n    <div class=\"container py-lg-5 py-md-4 py-md-3 py-2\">\r\n        <div class=\"text-center\">\r\n            <h3 style=\"text-align:center\">");
            EndContext();
            BeginContext(559, 31, false);
#line 14 "C:\Users\MR-BOO\Documents\GitHub\HomeMaintance\HomeMaintance\Areas\Customer\Views\HouseModelCus\ViewDetails.cshtml"
                                     Write(Model.HouseModel.HouseModelName);

#line default
#line hidden
            EndContext();
            BeginContext(590, 33, true);
            WriteLiteral("</h3>\r\n            <h5>Thể loại: ");
            EndContext();
            BeginContext(624, 47, false);
#line 15 "C:\Users\MR-BOO\Documents\GitHub\HomeMaintance\HomeMaintance\Areas\Customer\Views\HouseModelCus\ViewDetails.cshtml"
                     Write(Model.HouseModelCategory.HouseModelCategoryName);

#line default
#line hidden
            EndContext();
            BeginContext(671, 70, true);
            WriteLiteral("</h5>\r\n            <hr />\r\n        </div>\r\n        <div class=\"row\">\r\n");
            EndContext();
#line 19 "C:\Users\MR-BOO\Documents\GitHub\HomeMaintance\HomeMaintance\Areas\Customer\Views\HouseModelCus\ViewDetails.cshtml"
             foreach (var item in Model.Images)
            {

#line default
#line hidden
            BeginContext(805, 58, true);
            WriteLiteral("                <div class=\"col-md-3 col-sm-12 w3_ban1\">\r\n");
            EndContext();
            BeginContext(1071, 77, true);
            WriteLiteral("                    <img class=\"card-img-top\" style=\"height:100%;width:100%;\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1148, "\"", 1168, 1);
#line 25 "C:\Users\MR-BOO\Documents\GitHub\HomeMaintance\HomeMaintance\Areas\Customer\Views\HouseModelCus\ViewDetails.cshtml"
WriteAttributeValue("", 1154, item.ImageUrl, 1154, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1169, 50, true);
            WriteLiteral(" alt=\"Card image cap\">\r\n\r\n                </div>\r\n");
            EndContext();
#line 28 "C:\Users\MR-BOO\Documents\GitHub\HomeMaintance\HomeMaintance\Areas\Customer\Views\HouseModelCus\ViewDetails.cshtml"
            }

#line default
#line hidden
            BeginContext(1234, 42, true);
            WriteLiteral("        </div>\r\n    </div>\r\n</section>\r\n\r\n");
            EndContext();
            BeginContext(1277, 64, false);
#line 33 "C:\Users\MR-BOO\Documents\GitHub\HomeMaintance\HomeMaintance\Areas\Customer\Views\HouseModelCus\ViewDetails.cshtml"
Write(Html.Partial("~/Views/Shared/_FooterPartial.cshtml", systemconf));

#line default
#line hidden
            EndContext();
            BeginContext(1341, 5, true);
            WriteLiteral(";\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeMaintance.Models.ViewModels.HouseModelDetails> Html { get; private set; }
    }
}
#pragma warning restore 1591
