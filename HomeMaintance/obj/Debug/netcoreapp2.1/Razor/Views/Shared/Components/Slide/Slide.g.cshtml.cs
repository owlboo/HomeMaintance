#pragma checksum "C:\Users\MR-BOO\Documents\GitHub\HomeMaintance\HomeMaintance\Views\Shared\Components\Slide\Slide.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c7d0a7c980c7442591c14d8620f8fa555837c05f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Slide_Slide), @"mvc.1.0.view", @"/Views/Shared/Components/Slide/Slide.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/Slide/Slide.cshtml", typeof(AspNetCore.Views_Shared_Components_Slide_Slide))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7d0a7c980c7442591c14d8620f8fa555837c05f", @"/Views/Shared/Components/Slide/Slide.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5f6aeb9979061b40e00ceea01da9755c2c3efc0", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Slide_Slide : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<System.Collections.Generic.ICollection<HomeMaintance.Models.Slide>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Los Angeles"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 100%; height: 100%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(75, 261, true);
            WriteLiteral(@"
<div class=""w3_banner_info"">
    <div class=""slider"">
        <div class=""callbacks_container"">
            <div id=""demo"" class=""carousel slide"" data-ride=""carousel"">
                <!-- Indicators -->
                <ul class=""carousel-indicators"">
");
            EndContext();
#line 9 "C:\Users\MR-BOO\Documents\GitHub\HomeMaintance\HomeMaintance\Views\Shared\Components\Slide\Slide.cshtml"
                     for (int i = 0; i < @Model.Count; i++)
                    {
                        if (i == 0)
                        {

#line default
#line hidden
            BeginContext(484, 67, true);
            WriteLiteral("                            <li data-target=\"#demo\" data-slide-to=\"");
            EndContext();
            BeginContext(552, 1, false);
#line 13 "C:\Users\MR-BOO\Documents\GitHub\HomeMaintance\HomeMaintance\Views\Shared\Components\Slide\Slide.cshtml"
                                                              Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(553, 24, true);
            WriteLiteral("\" class=\"active\"></li>\r\n");
            EndContext();
#line 14 "C:\Users\MR-BOO\Documents\GitHub\HomeMaintance\HomeMaintance\Views\Shared\Components\Slide\Slide.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(661, 67, true);
            WriteLiteral("                            <li data-target=\"#demo\" data-slide-to=\"");
            EndContext();
            BeginContext(729, 1, false);
#line 17 "C:\Users\MR-BOO\Documents\GitHub\HomeMaintance\HomeMaintance\Views\Shared\Components\Slide\Slide.cshtml"
                                                              Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(730, 9, true);
            WriteLiteral("\"></li>\r\n");
            EndContext();
#line 18 "C:\Users\MR-BOO\Documents\GitHub\HomeMaintance\HomeMaintance\Views\Shared\Components\Slide\Slide.cshtml"
                        }
                    }

#line default
#line hidden
            BeginContext(789, 109, true);
            WriteLiteral("                </ul>\r\n                <!-- The slideshow -->\r\n                <div class=\"carousel-inner\">\r\n");
            EndContext();
#line 23 "C:\Users\MR-BOO\Documents\GitHub\HomeMaintance\HomeMaintance\Views\Shared\Components\Slide\Slide.cshtml"
                     for (int i = 0; i < @Model.Count; i++)
                    {
                        if (i == 0)
                        {

#line default
#line hidden
            BeginContext(1046, 96, true);
            WriteLiteral("                            <div class=\"carousel-item active\">\r\n                                ");
            EndContext();
            BeginContext(1142, 110, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b558013ae864404d967a7378fecb0ff5", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1152, "~/images/SlideImages/", 1152, 21, true);
#line 28 "C:\Users\MR-BOO\Documents\GitHub\HomeMaintance\HomeMaintance\Views\Shared\Components\Slide\Slide.cshtml"
AddHtmlAttributeValue("", 1173, Model.ElementAt(i).Image, 1173, 25, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1252, 111, true);
            WriteLiteral("\r\n                                <div class=\"carousel-caption text\">\r\n                                    <h3>");
            EndContext();
            BeginContext(1364, 23, false);
#line 30 "C:\Users\MR-BOO\Documents\GitHub\HomeMaintance\HomeMaintance\Views\Shared\Components\Slide\Slide.cshtml"
                                   Write(Model.ElementAt(i).Name);

#line default
#line hidden
            EndContext();
            BeginContext(1387, 206, true);
            WriteLiteral("</h3>\r\n                                    <p class=\"word wisteria\">Sự an toàn và hài lòng của bạn là động lực cho chúng tôi</p>\r\n                                </div>\r\n                            </div>\r\n");
            EndContext();
#line 34 "C:\Users\MR-BOO\Documents\GitHub\HomeMaintance\HomeMaintance\Views\Shared\Components\Slide\Slide.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(1677, 89, true);
            WriteLiteral("                            <div class=\"carousel-item\">\r\n                                ");
            EndContext();
            BeginContext(1766, 111, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d227e4c378c8435ea77978750485ad55", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1776, "~/images/SlideImages/", 1776, 21, true);
#line 38 "C:\Users\MR-BOO\Documents\GitHub\HomeMaintance\HomeMaintance\Views\Shared\Components\Slide\Slide.cshtml"
AddHtmlAttributeValue("", 1797, Model.ElementAt(i).Image, 1797, 25, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1877, 111, true);
            WriteLiteral("\r\n                                <div class=\"carousel-caption text\">\r\n                                    <h3>");
            EndContext();
            BeginContext(1989, 23, false);
#line 40 "C:\Users\MR-BOO\Documents\GitHub\HomeMaintance\HomeMaintance\Views\Shared\Components\Slide\Slide.cshtml"
                                   Write(Model.ElementAt(i).Name);

#line default
#line hidden
            EndContext();
            BeginContext(2012, 206, true);
            WriteLiteral("</h3>\r\n                                    <p class=\"word wisteria\">Sự an toàn và hài lòng của bạn là động lực cho chúng tôi</p>\r\n                                </div>\r\n                            </div>\r\n");
            EndContext();
#line 44 "C:\Users\MR-BOO\Documents\GitHub\HomeMaintance\HomeMaintance\Views\Shared\Components\Slide\Slide.cshtml"
                        }
                    }

#line default
#line hidden
            BeginContext(2268, 2149, true);
            WriteLiteral(@"                </div>


                <!-- Left and right controls -->
                <a class=""carousel-control-prev"" href=""#demo"" data-slide=""prev"">
                    <span class=""carousel-control-prev-icon""></span>
                </a>
                <a class=""carousel-control-next"" href=""#demo"" data-slide=""next"">
                    <span class=""carousel-control-next-icon""></span>
                </a>

            </div>
        </div>

    </div>
</div>
<script type=""text/javascript"">
    var words = document.getElementsByClassName('word');
    var wordArray = [];
    var currentWord = 0;

    words[currentWord].style.opacity = 1;
    for (var i = 0; i < words.length; i++) {
        splitLetters(words[i]);
    }

    function changeWord() {
        var cw = wordArray[currentWord];
        var nw = currentWord == words.length - 1 ? wordArray[0] : wordArray[currentWord + 1];
        for (var i = 0; i < cw.length; i++) {
            animateLetterOut(cw, i);
        }
");
            WriteLiteral(@"
        for (var i = 0; i < nw.length; i++) {
            nw[i].className = 'letter behind';
            nw[0].parentElement.style.opacity = 1;
            animateLetterIn(nw, i);
        }

        currentWord = (currentWord == wordArray.length - 1) ? 0 : currentWord + 1;
    }

    function animateLetterOut(cw, i) {
        setTimeout(function () {
            cw[i].className = 'letter out';
        }, i * 80);
    }

    function animateLetterIn(nw, i) {
        setTimeout(function () {
            nw[i].className = 'letter in';
        }, 340 + (i * 80));
    }

    function splitLetters(word) {
        var content = word.innerHTML;
        word.innerHTML = '';
        var letters = [];
        for (var i = 0; i < content.length; i++) {
            var letter = document.createElement('span');
            letter.className = 'letter';
            letter.innerHTML = content.charAt(i);
            word.appendChild(letter);
            letters.push(letter);
        }

        ");
            WriteLiteral("wordArray.push(letters);\r\n    }\r\n\r\n    changeWord();\r\n    setInterval(changeWord, 4000);\r\n\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<System.Collections.Generic.ICollection<HomeMaintance.Models.Slide>> Html { get; private set; }
    }
}
#pragma warning restore 1591
