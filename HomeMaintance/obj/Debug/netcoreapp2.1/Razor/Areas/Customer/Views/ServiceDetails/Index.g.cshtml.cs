#pragma checksum "D:\Study\Visual Project\ASP.NET\HomeMaintance\HomeMaintance\Areas\Customer\Views\ServiceDetails\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48c994199ae601856a5ac5ba7597b2e71e5f94b3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_ServiceDetails_Index), @"mvc.1.0.view", @"/Areas/Customer/Views/ServiceDetails/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Customer/Views/ServiceDetails/Index.cshtml", typeof(AspNetCore.Areas_Customer_Views_ServiceDetails_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48c994199ae601856a5ac5ba7597b2e71e5f94b3", @"/Areas/Customer/Views/ServiceDetails/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5f6aeb9979061b40e00ceea01da9755c2c3efc0", @"/Areas/Customer/Views/_ViewImports.cshtml")]
    public class Areas_Customer_Views_ServiceDetails_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeMaintance.Models.ViewModels.ServiceDetailsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Study\Visual Project\ASP.NET\HomeMaintance\HomeMaintance\Areas\Customer\Views\ServiceDetails\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Admin/_LayoutAdmin.cshtml";

#line default
#line hidden
            BeginContext(156, 73, true);
            WriteLiteral("<br />\r\n<br />\r\n<br />\r\n<br />\r\n<br />\r\n\r\n<h2 class=\"text-dark\">Dịch vụ: ");
            EndContext();
            BeginContext(230, 26, false);
#line 12 "D:\Study\Visual Project\ASP.NET\HomeMaintance\HomeMaintance\Areas\Customer\Views\ServiceDetails\Index.cshtml"
                          Write(Model.Services.ServiceName);

#line default
#line hidden
            EndContext();
            BeginContext(256, 17, true);
            WriteLiteral("</h2>\r\n<hr />\r\n\r\n");
            EndContext();
            BeginContext(274, 37, false);
#line 15 "D:\Study\Visual Project\ASP.NET\HomeMaintance\HomeMaintance\Areas\Customer\Views\ServiceDetails\Index.cshtml"
Write(Html.Raw(@Model.Services.Description));

#line default
#line hidden
            EndContext();
            BeginContext(311, 20, true);
            WriteLiteral("\r\n\r\n<br />\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeMaintance.Models.ViewModels.ServiceDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591