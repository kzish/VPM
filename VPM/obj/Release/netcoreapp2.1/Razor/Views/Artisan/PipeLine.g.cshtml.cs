#pragma checksum "C:\Users\samaritan\Documents\VPM\VPM\Views\Artisan\PipeLine.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c45bb5753c240b6a1bb08b006b91e511679f7ed9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Artisan_PipeLine), @"mvc.1.0.view", @"/Views/Artisan/PipeLine.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Artisan/PipeLine.cshtml", typeof(AspNetCore.Views_Artisan_PipeLine))]
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
#line 5 "C:\Users\samaritan\Documents\VPM\VPM\Views\Artisan\PipeLine.cshtml"
using PagedList.Core;

#line default
#line hidden
#line 6 "C:\Users\samaritan\Documents\VPM\VPM\Views\Artisan\PipeLine.cshtml"
using PagedList;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c45bb5753c240b6a1bb08b006b91e511679f7ed9", @"/Views/Artisan/PipeLine.cshtml")]
    public class Views_Artisan_PipeLine : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/libs/selectize/js/standalone/selectize.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/libs/highcharts/css/themes/grid-light.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/libs/highcharts/js/highcharts.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/css/timeline.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("pager-container"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Pipeline", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Artisan", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-keyword", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::PagedList.Core.Mvc.PagerTagHelper __PagedList_Core_Mvc_PagerTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\samaritan\Documents\VPM\VPM\Views\Artisan\PipeLine.cshtml"
  Layout = "_Layout";

#line default
#line hidden
#line 2 "C:\Users\samaritan\Documents\VPM\VPM\Views\Artisan\PipeLine.cshtml"
  var ass = (IPagedList<VPM.Models.mAssignments>)ViewBag.ass;

#line default
#line hidden
#line 3 "C:\Users\samaritan\Documents\VPM\VPM\Views\Artisan\PipeLine.cshtml"
  var user = (VPM.Models.mArtisan)ViewBag.u;

#line default
#line hidden
            BeginContext(135, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(180, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(273, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(292, 74, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d03b001c85444999972447b59a029d4b", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(366, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(384, 83, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0070ea6ec54b49599b094c6dde3955a5", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(467, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(469, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "28d7f4472bbe434098860ba325f45449", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(534, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(552, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0a18e6abfb9e44a5bba7fcc444c5af51", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(610, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 21 "C:\Users\samaritan\Documents\VPM\VPM\Views\Artisan\PipeLine.cshtml"
 if (ass.Count > 0)
{

#line default
#line hidden
            BeginContext(638, 505, true);
            WriteLiteral(@"    <div class=""row"">
        <div class=""col-md-12"">
            <h6 style=""margin:0px!important;"">Pipeline</h6>
            <table class=""table tblsm table-striped"" style=""margin-bottom:0px!important;"">
                <thead>
                    <tr>
                        <th>Date</th>
                        <th>Description</th>
                        <th>Status</th>
                        <th>Action</th>
                    </tr>
                </thead>
                <tbody>
");
            EndContext();
#line 36 "C:\Users\samaritan\Documents\VPM\VPM\Views\Artisan\PipeLine.cshtml"
                     foreach (var n in ass)
                    {

#line default
#line hidden
            BeginContext(1211, 62, true);
            WriteLiteral("                        <tr>\r\n                            <td>");
            EndContext();
            BeginContext(1274, 30, false);
#line 39 "C:\Users\samaritan\Documents\VPM\VPM\Views\Artisan\PipeLine.cshtml"
                           Write(n.date.ToString("dd MMM yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(1304, 38, true);
            WriteLiteral("</td>\r\n                            <td");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 1342, "\"", 1364, 1);
#line 40 "C:\Users\samaritan\Documents\VPM\VPM\Views\Artisan\PipeLine.cshtml"
WriteAttributeValue("", 1350, n.description, 1350, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1365, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1367, 13, false);
#line 40 "C:\Users\samaritan\Documents\VPM\VPM\Views\Artisan\PipeLine.cshtml"
                                                  Write(n.description);

#line default
#line hidden
            EndContext();
            BeginContext(1380, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1420, 23, false);
#line 41 "C:\Users\samaritan\Documents\VPM\VPM\Views\Artisan\PipeLine.cshtml"
                           Write(n.getAssignmentStatus());

#line default
#line hidden
            EndContext();
            BeginContext(1443, 41, true);
            WriteLiteral("</td>\r\n                            <td>\r\n");
            EndContext();
#line 43 "C:\Users\samaritan\Documents\VPM\VPM\Views\Artisan\PipeLine.cshtml"
                                 if (n.assignmentStatus == VPM.Models.AssignmentStatus.signedOff)
                                {

#line default
#line hidden
            BeginContext(1618, 84, true);
            WriteLiteral("                                    <b style=\"color:lightseagreen;\">Signed off</b>\r\n");
            EndContext();
#line 46 "C:\Users\samaritan\Documents\VPM\VPM\Views\Artisan\PipeLine.cshtml"
                                }
                                else if (n.assignmentStatus == VPM.Models.AssignmentStatus.dispute)
                                {

#line default
#line hidden
            BeginContext(1873, 72, true);
            WriteLiteral("                                    <b style=\"color:red;\">Disputed</b>\r\n");
            EndContext();
#line 50 "C:\Users\samaritan\Documents\VPM\VPM\Views\Artisan\PipeLine.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(2053, 38, true);
            WriteLiteral("                                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2091, "\"", 2135, 2);
            WriteAttributeValue("", 2098, "/Artisan/AssignmentDetails?aid=", 2098, 31, true);
#line 53 "C:\Users\samaritan\Documents\VPM\VPM\Views\Artisan\PipeLine.cshtml"
WriteAttributeValue("", 2129, n._id, 2129, 6, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2136, 189, true);
            WriteLiteral(">\r\n                                        <span class=\"fa fa-envelope-open-o\" title=\"open\"></span>\r\n                                        Open\r\n                                    </a>\r\n");
            EndContext();
#line 57 "C:\Users\samaritan\Documents\VPM\VPM\Views\Artisan\PipeLine.cshtml"
                                }

#line default
#line hidden
            BeginContext(2360, 66, true);
            WriteLiteral("                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 60 "C:\Users\samaritan\Documents\VPM\VPM\Views\Artisan\PipeLine.cshtml"
                    }

#line default
#line hidden
            BeginContext(2449, 60, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n            ");
            EndContext();
            BeginContext(2509, 282, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("pager", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3f47c28b2f9a4dcfa3d29da933c82dbd", async() => {
            }
            );
            __PagedList_Core_Mvc_PagerTagHelper = CreateTagHelper<global::PagedList.Core.Mvc.PagerTagHelper>();
            __tagHelperExecutionContext.Add(__PagedList_Core_Mvc_PagerTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
#line 64 "C:\Users\samaritan\Documents\VPM\VPM\Views\Artisan\PipeLine.cshtml"
__PagedList_Core_Mvc_PagerTagHelper.List = ass;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("list", __PagedList_Core_Mvc_PagerTagHelper.List, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 65 "C:\Users\samaritan\Documents\VPM\VPM\Views\Artisan\PipeLine.cshtml"
__PagedList_Core_Mvc_PagerTagHelper.Options = PagedList.Core.Mvc.PagedListRenderOptions.PageNumbersOnly;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("options", __PagedList_Core_Mvc_PagerTagHelper.Options, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __PagedList_Core_Mvc_PagerTagHelper.AspAction = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __PagedList_Core_Mvc_PagerTagHelper.AspController = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__PagedList_Core_Mvc_PagerTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-keyword", "PagedList.Core.Mvc.PagerTagHelper", "RouteValues"));
            }
            __PagedList_Core_Mvc_PagerTagHelper.RouteValues["keyword"] = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2791, 20, true);
            WriteLiteral("\r\n\r\n\r\n        </div>");
            EndContext();
            BeginContext(2823, 14, true);
            WriteLiteral("\r\n\r\n    </div>");
            EndContext();
#line 73 "C:\Users\samaritan\Documents\VPM\VPM\Views\Artisan\PipeLine.cshtml"
                 
}
else
{

#line default
#line hidden
            BeginContext(2858, 60, true);
            WriteLiteral("    <center>\r\n        <h1>No Tasks Yet</h1>\r\n    </center>\r\n");
            EndContext();
#line 80 "C:\Users\samaritan\Documents\VPM\VPM\Views\Artisan\PipeLine.cshtml"
}

#line default
#line hidden
            BeginContext(2921, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
