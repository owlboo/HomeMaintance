#pragma checksum "D:\Study\Visual Project\ASP.NET\HomeMaintance\HomeMaintance\Views\Shared\_FooterPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b120b99e038844bfee7a87e698a5532e492d9aa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__FooterPartial), @"mvc.1.0.view", @"/Views/Shared/_FooterPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_FooterPartial.cshtml", typeof(AspNetCore.Views_Shared__FooterPartial))]
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
#line 1 "D:\Study\Visual Project\ASP.NET\HomeMaintance\HomeMaintance\Views\_ViewImports.cshtml"
using HomeMaintance;

#line default
#line hidden
#line 2 "D:\Study\Visual Project\ASP.NET\HomeMaintance\HomeMaintance\Views\_ViewImports.cshtml"
using HomeMaintance.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b120b99e038844bfee7a87e698a5532e492d9aa", @"/Views/Shared/_FooterPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5f6aeb9979061b40e00ceea01da9755c2c3efc0", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__FooterPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SystemConfig>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(147, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(159, 378, true);
            WriteLiteral(@"    <section class=""footer"">
        <div class=""container-fluid"">
            <div class=""row"">
                <div class=""col-lg-4"">
                    <br />
                    <br />
                    <div>
                        <span><i class=""fas fa-phone"" style=""height:10px; width:10px; color:white""></i></span><label style=""margin-left:20px;color:white;"">");
            EndContext();
            BeginContext(538, 18, false);
#line 16 "D:\Study\Visual Project\ASP.NET\HomeMaintance\HomeMaintance\Views\Shared\_FooterPartial.cshtml"
                                                                                                                                                      Write(Model.CompanyPhone);

#line default
#line hidden
            EndContext();
            BeginContext(556, 257, true);
            WriteLiteral(@"</label>
                    </div>
                    <br />
                    <div>
                        <span><i class=""fas fa-map-marker-alt"" style=""height:10px; width:10px; color:white""></i></span><label style=""margin-left:20px;color:white;"">");
            EndContext();
            BeginContext(814, 20, false);
#line 20 "D:\Study\Visual Project\ASP.NET\HomeMaintance\HomeMaintance\Views\Shared\_FooterPartial.cshtml"
                                                                                                                                                               Write(Model.CompanyAddress);

#line default
#line hidden
            EndContext();
            BeginContext(834, 258, true);
            WriteLiteral(@"</label>
                    </div>
                    <br />
                    <div>
                        <span><i class=""fas fa-envelope-square"" style=""height:10px; width:10px; color:white""></i></span><label style=""margin-left:20px;color:white;"">");
            EndContext();
            BeginContext(1093, 18, false);
#line 24 "D:\Study\Visual Project\ASP.NET\HomeMaintance\HomeMaintance\Views\Shared\_FooterPartial.cshtml"
                                                                                                                                                                Write(Model.CompanyEmail);

#line default
#line hidden
            EndContext();
            BeginContext(1111, 126, true);
            WriteLiteral("</label>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-lg-4\">\r\n                    <h3>");
            EndContext();
            BeginContext(1238, 17, false);
#line 28 "D:\Study\Visual Project\ASP.NET\HomeMaintance\HomeMaintance\Views\Shared\_FooterPartial.cshtml"
                   Write(Model.CompanyName);

#line default
#line hidden
            EndContext();
            BeginContext(1255, 895, true);
            WriteLiteral(@"</h3>
                    <div class=""wrapper"">
                        <ul class=""social-icons icon-circle icon-zoom list-unstyled list-inline"">
                            <li> <a href=""#""><i class=""fab fa-facebook-f""></i></a></li>
                            <li> <a href=""#""><i class=""fab fa-twitter""></i></a></li>
                            <li> <a href=""#""><i class=""fab fa-linkedin-in""></i></a></li>
                        </ul>
                    </div>
                    <div class=""copyright"">
                        <p>© 2019 Nam Việt. All Rights Reserved</p>

                    </div>
                </div>
                <div class=""col-lg-4"">
                    <div>
                        Chỗ này select dịch vụ rồi bỏ vào theo thẻ a
                    </div>
                </div>
            </div>

        </div>
    </section>
   ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SystemConfig> Html { get; private set; }
    }
}
#pragma warning restore 1591
