#pragma checksum "D:\Coding\ASP.NET\HomeMaintance\HomeMaintance\Areas\Admin\Views\Appointments\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9bf260ce2c4fa75f77cc2957f4486196c302d6b1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Appointments_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Appointments/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Appointments/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Appointments_Index))]
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
#line 1 "D:\Coding\ASP.NET\HomeMaintance\HomeMaintance\Areas\Admin\Views\_ViewImports.cshtml"
using HomeMaintance;

#line default
#line hidden
#line 2 "D:\Coding\ASP.NET\HomeMaintance\HomeMaintance\Areas\Admin\Views\_ViewImports.cshtml"
using HomeMaintance.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9bf260ce2c4fa75f77cc2957f4486196c302d6b1", @"/Areas/Admin/Views/Appointments/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5f6aeb9979061b40e00ceea01da9755c2c3efc0", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Appointments_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<HomeMaintance.Models.Appointments>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "~/Views/Admin/_TableButtonPartial.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Coding\ASP.NET\HomeMaintance\HomeMaintance\Areas\Admin\Views\Appointments\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Admin/_LayoutAdmin.cshtml";
    string text = "";
    string[] listTimeMark = null;

#line default
#line hidden
            BeginContext(198, 1049, true);
            WriteLiteral(@"
    <section class=""contact py-lg-5 py-md-4 py-md-3 py-2"">
        <div class="" container-fluid py-lg-5 py-md-4 py-md-3 py-2"">
            <div class=""w3_mg"">
                <h3>Danh sách cuộc hẹn</h3>
            </div>
            <br />
            <br />
            <div class=""row"">
                <table class=""table table-striped"">
                        <tr class=""table-primary"">
                            <th>Mã cuộc hẹn</th>                           
                            <th>Nội dung cuộc hẹn</th>
                            <th>Ngày gặp</th>
                            <th>Thời gian</th>
                            <th>Khách hàng</th>
                            <th>Số điện thoại</th>
                            <th>Tin nhắn của khách hàng</th>
                            <th>Ngày tạo</th>
                            <th>Nhân viên</th>
                            <th>Trạng thái</th>
                            <th></th>
                            <th></th>
      ");
            WriteLiteral("                  </tr>\r\n");
            EndContext();
#line 32 "D:\Coding\ASP.NET\HomeMaintance\HomeMaintance\Areas\Admin\Views\Appointments\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
            BeginContext(1328, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(1375, 43, false);
#line 35 "D:\Coding\ASP.NET\HomeMaintance\HomeMaintance\Areas\Admin\Views\Appointments\Index.cshtml"
                   Write(Html.DisplayFor(m => item.AppointmentsName));

#line default
#line hidden
            EndContext();
            BeginContext(1418, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1450, 45, false);
#line 36 "D:\Coding\ASP.NET\HomeMaintance\HomeMaintance\Areas\Admin\Views\Appointments\Index.cshtml"
                   Write(Html.DisplayFor(m => item.AppointmentContent));

#line default
#line hidden
            EndContext();
            BeginContext(1495, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 37 "D:\Coding\ASP.NET\HomeMaintance\HomeMaintance\Areas\Admin\Views\Appointments\Index.cshtml"
                     if (item.AppointmentDate != null)
                    {
                        text = item.AppointmentDate.Value.ToString();
                        listTimeMark = text.Split(' ');

                        

#line default
#line hidden
            BeginContext(1844, 28, true);
            WriteLiteral("                        <td>");
            EndContext();
            BeginContext(1873, 15, false);
#line 43 "D:\Coding\ASP.NET\HomeMaintance\HomeMaintance\Areas\Admin\Views\Appointments\Index.cshtml"
                       Write(listTimeMark[0]);

#line default
#line hidden
            EndContext();
            BeginContext(1888, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 44 "D:\Coding\ASP.NET\HomeMaintance\HomeMaintance\Areas\Admin\Views\Appointments\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(1967, 52, true);
            WriteLiteral("                        <td>Chưa đặt ngày hẹn</td>\r\n");
            EndContext();
#line 48 "D:\Coding\ASP.NET\HomeMaintance\HomeMaintance\Areas\Admin\Views\Appointments\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(2042, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 49 "D:\Coding\ASP.NET\HomeMaintance\HomeMaintance\Areas\Admin\Views\Appointments\Index.cshtml"
                     if (item.AppointmentDate != null)
                    {

                        

#line default
#line hidden
#line 52 "D:\Coding\ASP.NET\HomeMaintance\HomeMaintance\Areas\Admin\Views\Appointments\Index.cshtml"
                                                                                                                                   
                        listTimeMark[1] = listTimeMark[1].Substring(0, 5);
                        

#line default
#line hidden
            BeginContext(2358, 28, true);
            WriteLiteral("                        <td>");
            EndContext();
            BeginContext(2387, 15, false);
#line 55 "D:\Coding\ASP.NET\HomeMaintance\HomeMaintance\Areas\Admin\Views\Appointments\Index.cshtml"
                       Write(listTimeMark[1]);

#line default
#line hidden
            EndContext();
            BeginContext(2402, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(2404, 15, false);
#line 55 "D:\Coding\ASP.NET\HomeMaintance\HomeMaintance\Areas\Admin\Views\Appointments\Index.cshtml"
                                        Write(listTimeMark[2]);

#line default
#line hidden
            EndContext();
            BeginContext(2419, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 56 "D:\Coding\ASP.NET\HomeMaintance\HomeMaintance\Areas\Admin\Views\Appointments\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(2498, 51, true);
            WriteLiteral("                        <td>Chưa đặt giờ hẹn</td>\r\n");
            EndContext();
#line 60 "D:\Coding\ASP.NET\HomeMaintance\HomeMaintance\Areas\Admin\Views\Appointments\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(2572, 24, true);
            WriteLiteral("                    <td>");
            EndContext();
            BeginContext(2597, 39, false);
#line 61 "D:\Coding\ASP.NET\HomeMaintance\HomeMaintance\Areas\Admin\Views\Appointments\Index.cshtml"
                   Write(Html.DisplayFor(m => item.CustomerName));

#line default
#line hidden
            EndContext();
            BeginContext(2636, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(2668, 40, false);
#line 62 "D:\Coding\ASP.NET\HomeMaintance\HomeMaintance\Areas\Admin\Views\Appointments\Index.cshtml"
                   Write(Html.DisplayFor(m => item.CustomerPhone));

#line default
#line hidden
            EndContext();
            BeginContext(2708, 9, true);
            WriteLiteral("</td>\r\n\r\n");
            EndContext();
#line 64 "D:\Coding\ASP.NET\HomeMaintance\HomeMaintance\Areas\Admin\Views\Appointments\Index.cshtml"
                     if (item.CustomerMessage != null)
                    {
                        

#line default
#line hidden
#line 66 "D:\Coding\ASP.NET\HomeMaintance\HomeMaintance\Areas\Admin\Views\Appointments\Index.cshtml"
                         if (item.CustomerMessage.Length <= 15)
                        {

#line default
#line hidden
            BeginContext(2888, 32, true);
            WriteLiteral("                            <td>");
            EndContext();
            BeginContext(2921, 42, false);
#line 68 "D:\Coding\ASP.NET\HomeMaintance\HomeMaintance\Areas\Admin\Views\Appointments\Index.cshtml"
                           Write(Html.DisplayFor(m => item.CustomerMessage));

#line default
#line hidden
            EndContext();
            BeginContext(2963, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 69 "D:\Coding\ASP.NET\HomeMaintance\HomeMaintance\Areas\Admin\Views\Appointments\Index.cshtml"
                        }
                        else
                        {
                            string temp = item.CustomerMessage.Substring(0, 15) + "...";

#line default
#line hidden
            BeginContext(3144, 32, true);
            WriteLiteral("                            <td>");
            EndContext();
            BeginContext(3177, 26, false);
#line 73 "D:\Coding\ASP.NET\HomeMaintance\HomeMaintance\Areas\Admin\Views\Appointments\Index.cshtml"
                           Write(Html.DisplayFor(m => temp));

#line default
#line hidden
            EndContext();
            BeginContext(3203, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 74 "D:\Coding\ASP.NET\HomeMaintance\HomeMaintance\Areas\Admin\Views\Appointments\Index.cshtml"
                        }

#line default
#line hidden
#line 74 "D:\Coding\ASP.NET\HomeMaintance\HomeMaintance\Areas\Admin\Views\Appointments\Index.cshtml"
                         
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(3309, 43, true);
            WriteLiteral("                        <td>Không có</td>\r\n");
            EndContext();
#line 79 "D:\Coding\ASP.NET\HomeMaintance\HomeMaintance\Areas\Admin\Views\Appointments\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(3375, 24, true);
            WriteLiteral("                    <td>");
            EndContext();
            BeginContext(3400, 38, false);
#line 80 "D:\Coding\ASP.NET\HomeMaintance\HomeMaintance\Areas\Admin\Views\Appointments\Index.cshtml"
                   Write(Html.DisplayFor(m => item.CreatedDate));

#line default
#line hidden
            EndContext();
            BeginContext(3438, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(3470, 49, false);
#line 81 "D:\Coding\ASP.NET\HomeMaintance\HomeMaintance\Areas\Admin\Views\Appointments\Index.cshtml"
                   Write(Html.DisplayFor(m => item.SalePerson.DisplayName));

#line default
#line hidden
            EndContext();
            BeginContext(3519, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 82 "D:\Coding\ASP.NET\HomeMaintance\HomeMaintance\Areas\Admin\Views\Appointments\Index.cshtml"
                     if (item.isConfirm)
                    {

#line default
#line hidden
            BeginContext(3591, 41, true);
            WriteLiteral("                        <td>Đã gặp</td>\r\n");
            EndContext();
#line 85 "D:\Coding\ASP.NET\HomeMaintance\HomeMaintance\Areas\Admin\Views\Appointments\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(3704, 43, true);
            WriteLiteral("                        <td>Chưa gặp</td>\r\n");
            EndContext();
#line 89 "D:\Coding\ASP.NET\HomeMaintance\HomeMaintance\Areas\Admin\Views\Appointments\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(3770, 52, true);
            WriteLiteral("\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(3822, 76, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2d13ce8c04f7410e9bdce2dc34a060c7", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
#line 92 "D:\Coding\ASP.NET\HomeMaintance\HomeMaintance\Areas\Admin\Views\Appointments\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = item.Id;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3898, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 95 "D:\Coding\ASP.NET\HomeMaintance\HomeMaintance\Areas\Admin\Views\Appointments\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(3977, 80, true);
            WriteLiteral("                </table>\r\n            </div>\r\n\r\n        </div>\r\n    </section>\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(4074, 789, true);
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
                var appointmentTime = document.getElementById('date').value;
                var splitData = """";
                if (appointmentTime.indexOf("" "") > 0) {
                    splitData = appointmentTime.Split("" "");
                } else {
                    splitData = appointmentTime.Split(""T"");
                }

                var time = splitData[1].substring(0, 5);
                if (time.slice(-1) == "":"") {
                    time = time.substring(0, time.length - 1);
                }
                var amPmTime = splitData[2];

                $(""#date"").attr('value', splitData[0]);
                $(""#time"").attr('value', time + ' ' + amPmTime);
            });
    </script>
 ");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<HomeMaintance.Models.Appointments>> Html { get; private set; }
    }
}
#pragma warning restore 1591
