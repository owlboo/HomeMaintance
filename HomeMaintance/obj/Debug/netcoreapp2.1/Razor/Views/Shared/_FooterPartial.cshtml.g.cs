#pragma checksum "C:\Users\MR-BOO\Documents\GitHub\HomeMaintance\HomeMaintance\Views\Shared\_FooterPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23b359199fcb6aed081484da8d3d2b26adfa50b3"
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
#line 1 "C:\Users\MR-BOO\Documents\GitHub\HomeMaintance\HomeMaintance\Views\_ViewImports.cshtml"
using HomeMaintance;

#line default
#line hidden
#line 2 "C:\Users\MR-BOO\Documents\GitHub\HomeMaintance\HomeMaintance\Views\_ViewImports.cshtml"
using HomeMaintance.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23b359199fcb6aed081484da8d3d2b26adfa50b3", @"/Views/Shared/_FooterPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5f6aeb9979061b40e00ceea01da9755c2c3efc0", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__FooterPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeMaintance.Models.ViewModels.FooterViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ServiceDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Customer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color:white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(178, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 9 "C:\Users\MR-BOO\Documents\GitHub\HomeMaintance\HomeMaintance\Views\Shared\_FooterPartial.cshtml"
 if (Model != null)
{

#line default
#line hidden
            BeginContext(213, 346, true);
            WriteLiteral(@"    <section class=""footer"" style=""margin-top:50px"">
        <div class=""container-fluid"">
            <div class=""row"">
                <div class=""col-lg-4"">
                    <div>
                        <span><i class=""fas fa-phone"" style=""height:10px; width:10px; color:white""></i></span><label style=""margin-left:20px;color:white;"">");
            EndContext();
            BeginContext(560, 32, false);
#line 16 "C:\Users\MR-BOO\Documents\GitHub\HomeMaintance\HomeMaintance\Views\Shared\_FooterPartial.cshtml"
                                                                                                                                                      Write(Model.SystemConfigs.CompanyPhone);

#line default
#line hidden
            EndContext();
            BeginContext(592, 257, true);
            WriteLiteral(@"</label>
                    </div>
                    <br />
                    <div>
                        <span><i class=""fas fa-map-marker-alt"" style=""height:10px; width:10px; color:white""></i></span><label style=""margin-left:20px;color:white;"">");
            EndContext();
            BeginContext(850, 34, false);
#line 20 "C:\Users\MR-BOO\Documents\GitHub\HomeMaintance\HomeMaintance\Views\Shared\_FooterPartial.cshtml"
                                                                                                                                                               Write(Model.SystemConfigs.CompanyAddress);

#line default
#line hidden
            EndContext();
            BeginContext(884, 258, true);
            WriteLiteral(@"</label>
                    </div>
                    <br />
                    <div>
                        <span><i class=""fas fa-envelope-square"" style=""height:10px; width:10px; color:white""></i></span><label style=""margin-left:20px;color:white;"">");
            EndContext();
            BeginContext(1143, 32, false);
#line 24 "C:\Users\MR-BOO\Documents\GitHub\HomeMaintance\HomeMaintance\Views\Shared\_FooterPartial.cshtml"
                                                                                                                                                                Write(Model.SystemConfigs.CompanyEmail);

#line default
#line hidden
            EndContext();
            BeginContext(1175, 126, true);
            WriteLiteral("</label>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-lg-4\">\r\n                    <h3>");
            EndContext();
            BeginContext(1302, 31, false);
#line 28 "C:\Users\MR-BOO\Documents\GitHub\HomeMaintance\HomeMaintance\Views\Shared\_FooterPartial.cshtml"
                   Write(Model.SystemConfigs.CompanyName);

#line default
#line hidden
            EndContext();
            BeginContext(1333, 766, true);
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
                <div class=""col-lg-4"" style=""padding-left:100px;"">
                    <div>
                        <ul>
");
            EndContext();
#line 44 "C:\Users\MR-BOO\Documents\GitHub\HomeMaintance\HomeMaintance\Views\Shared\_FooterPartial.cshtml"
                             foreach (var item in Model.Services)
                            {


#line default
#line hidden
            BeginContext(2199, 65, true);
            WriteLiteral("                                <li class=\"text-left text-light\">");
            EndContext();
            BeginContext(2264, 139, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d560f4e95c8f4dc7b12765924485747a", async() => {
                BeginContext(2383, 16, false);
#line 47 "C:\Users\MR-BOO\Documents\GitHub\HomeMaintance\HomeMaintance\Views\Shared\_FooterPartial.cshtml"
                                                                                                                                                                                  Write(item.ServiceName);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 47 "C:\Users\MR-BOO\Documents\GitHub\HomeMaintance\HomeMaintance\Views\Shared\_FooterPartial.cshtml"
                                                                                                                                             WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2403, 8, true);
            WriteLiteral(" </li>\r\n");
            EndContext();
#line 48 "C:\Users\MR-BOO\Documents\GitHub\HomeMaintance\HomeMaintance\Views\Shared\_FooterPartial.cshtml"

                            }

#line default
#line hidden
            BeginContext(2444, 137, true);
            WriteLiteral("                        </ul>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n    </section>\r\n");
            EndContext();
#line 57 "C:\Users\MR-BOO\Documents\GitHub\HomeMaintance\HomeMaintance\Views\Shared\_FooterPartial.cshtml"

}

#line default
#line hidden
            BeginContext(2586, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeMaintance.Models.ViewModels.FooterViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
