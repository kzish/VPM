#pragma checksum "C:\Users\samaritan\Documents\Visual Studio 2017\Projects\VPM\VPM\Views\Account\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bdc043686e191981670fbcc5892de100d0c7749b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Dashboard), @"mvc.1.0.view", @"/Views/Account/Dashboard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Dashboard.cshtml", typeof(AspNetCore.Views_Account_Dashboard))]
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
#line 7 "C:\Users\samaritan\Documents\Visual Studio 2017\Projects\VPM\VPM\Views\Account\Dashboard.cshtml"
using PagedList.Core;

#line default
#line hidden
#line 8 "C:\Users\samaritan\Documents\Visual Studio 2017\Projects\VPM\VPM\Views\Account\Dashboard.cshtml"
using PagedList;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bdc043686e191981670fbcc5892de100d0c7749b", @"/Views/Account/Dashboard.cshtml")]
    public class Views_Account_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/css/dashCards.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("pager-container"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Properties", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-keyword", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\samaritan\Documents\Visual Studio 2017\Projects\VPM\VPM\Views\Account\Dashboard.cshtml"
   Layout = "_Layout";

#line default
#line hidden
            BeginContext(25, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\samaritan\Documents\Visual Studio 2017\Projects\VPM\VPM\Views\Account\Dashboard.cshtml"
  var en = (IPagedList<VPM.Models.mEnquiry>)ViewBag.enqs;

#line default
#line hidden
#line 4 "C:\Users\samaritan\Documents\Visual Studio 2017\Projects\VPM\VPM\Views\Account\Dashboard.cshtml"
  var p = (List<VPM.Models.mProperty>)ViewBag.propertys;

#line default
#line hidden
#line 5 "C:\Users\samaritan\Documents\Visual Studio 2017\Projects\VPM\VPM\Views\Account\Dashboard.cshtml"
  var m = (List<VPM.Models.mMessages>)ViewBag.msgs;

#line default
#line hidden
            BeginContext(200, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(245, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(387, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2c1204e8aa7e4901a02a00304d7c617e", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
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
            BeginContext(446, 144, true);
            WriteLiteral("\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        <div class=\"card bshadow\">\r\n            <div class=\"card-header _active\">Enquiries (");
            EndContext();
            BeginContext(591, 8, false);
#line 18 "C:\Users\samaritan\Documents\Visual Studio 2017\Projects\VPM\VPM\Views\Account\Dashboard.cshtml"
                                                   Write(en.Count);

#line default
#line hidden
            EndContext();
            BeginContext(599, 508, true);
            WriteLiteral(@")</div>
            <div class=""card-body"" style=""margin:0px!important;padding:0px!important;"">
                <table class=""table table-condensed tblsm table-striped"">
                    <tr>
                        <td>name</td>
                        <td>mobile</td>
                        <td>email</td>
                        <td>date</td>
                        <td>enquiry</td>
                        <td>state</td>
                        <td>action</td>
                    </tr>
");
            EndContext();
#line 30 "C:\Users\samaritan\Documents\Visual Studio 2017\Projects\VPM\VPM\Views\Account\Dashboard.cshtml"
                     foreach (var e in en)
                    {

#line default
#line hidden
            BeginContext(1174, 62, true);
            WriteLiteral("                        <tr>\r\n                            <td>");
            EndContext();
            BeginContext(1237, 6, false);
#line 33 "C:\Users\samaritan\Documents\Visual Studio 2017\Projects\VPM\VPM\Views\Account\Dashboard.cshtml"
                           Write(e.name);

#line default
#line hidden
            EndContext();
            BeginContext(1243, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1283, 8, false);
#line 34 "C:\Users\samaritan\Documents\Visual Studio 2017\Projects\VPM\VPM\Views\Account\Dashboard.cshtml"
                           Write(e.mobile);

#line default
#line hidden
            EndContext();
            BeginContext(1291, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1331, 7, false);
#line 35 "C:\Users\samaritan\Documents\Visual Studio 2017\Projects\VPM\VPM\Views\Account\Dashboard.cshtml"
                           Write(e.email);

#line default
#line hidden
            EndContext();
            BeginContext(1338, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1378, 29, false);
#line 36 "C:\Users\samaritan\Documents\Visual Studio 2017\Projects\VPM\VPM\Views\Account\Dashboard.cshtml"
                           Write(e.date.ToString("d MMM yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(1407, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1447, 13, false);
#line 37 "C:\Users\samaritan\Documents\Visual Studio 2017\Projects\VPM\VPM\Views\Account\Dashboard.cshtml"
                           Write(e.getStatus());

#line default
#line hidden
            EndContext();
            BeginContext(1460, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1500, 9, false);
#line 38 "C:\Users\samaritan\Documents\Visual Studio 2017\Projects\VPM\VPM\Views\Account\Dashboard.cshtml"
                           Write(e.enquiry);

#line default
#line hidden
            EndContext();
            BeginContext(1509, 41, true);
            WriteLiteral("</td>\r\n                            <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1550, "\"", 1588, 2);
            WriteAttributeValue("", 1557, "/Account/ViewEnquiry?eid=", 1557, 25, true);
#line 39 "C:\Users\samaritan\Documents\Visual Studio 2017\Projects\VPM\VPM\Views\Account\Dashboard.cshtml"
WriteAttributeValue("", 1582, e._id, 1582, 6, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1589, 47, true);
            WriteLiteral(">open</a></td>\r\n                        </tr>\r\n");
            EndContext();
#line 41 "C:\Users\samaritan\Documents\Visual Studio 2017\Projects\VPM\VPM\Views\Account\Dashboard.cshtml"
                    }

#line default
#line hidden
            BeginContext(1659, 50, true);
            WriteLiteral("                </table>\r\n\r\n\r\n            </div>\r\n");
            EndContext();
            BeginContext(1737, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(1749, 281, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("pager", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e6cf652ac5ff4a9aa940f5d3d15e3917", async() => {
            }
            );
            __PagedList_Core_Mvc_PagerTagHelper = CreateTagHelper<global::PagedList.Core.Mvc.PagerTagHelper>();
            __tagHelperExecutionContext.Add(__PagedList_Core_Mvc_PagerTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#line 48 "C:\Users\samaritan\Documents\Visual Studio 2017\Projects\VPM\VPM\Views\Account\Dashboard.cshtml"
__PagedList_Core_Mvc_PagerTagHelper.List = en;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("list", __PagedList_Core_Mvc_PagerTagHelper.List, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 49 "C:\Users\samaritan\Documents\Visual Studio 2017\Projects\VPM\VPM\Views\Account\Dashboard.cshtml"
__PagedList_Core_Mvc_PagerTagHelper.Options = PagedList.Core.Mvc.PagedListRenderOptions.PageNumbersOnly;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("options", __PagedList_Core_Mvc_PagerTagHelper.Options, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __PagedList_Core_Mvc_PagerTagHelper.AspAction = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __PagedList_Core_Mvc_PagerTagHelper.AspController = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__PagedList_Core_Mvc_PagerTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-keyword", "PagedList.Core.Mvc.PagerTagHelper", "RouteValues"));
            }
            __PagedList_Core_Mvc_PagerTagHelper.RouteValues["keyword"] = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2030, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(2061, 26, true);
            WriteLiteral("        </div>\r\n    </div>");
            EndContext();
            BeginContext(2100, 8, true);
            WriteLiteral("\r\n</div>");
            EndContext();
            BeginContext(2115, 270, true);
            WriteLiteral(@"

<br />
<br />

<div class=""row"">
    <div class=""col-md-3"">
        <div class=""card bshadow"" style=""min-height:300px!important;"">
            <div class=""card-header _active"">Properties</div>
            <div class=""card-body"" style=""text-align:center;""><h3>");
            EndContext();
            BeginContext(2386, 7, false);
#line 65 "C:\Users\samaritan\Documents\Visual Studio 2017\Projects\VPM\VPM\Views\Account\Dashboard.cshtml"
                                                             Write(p.Count);

#line default
#line hidden
            EndContext();
            BeginContext(2393, 152, true);
            WriteLiteral("</h3></div>\r\n            <div class=\"card-footer\">\r\n                <ul style=\"text-decoration:none;list-style:none;\">\r\n                    <li><strong>");
            EndContext();
            BeginContext(2546, 37, false);
#line 68 "C:\Users\samaritan\Documents\Visual Studio 2017\Projects\VPM\VPM\Views\Account\Dashboard.cshtml"
                           Write(p.Where(x => x.adminApproved).Count());

#line default
#line hidden
            EndContext();
            BeginContext(2583, 57, true);
            WriteLiteral("</strong> Approved</li>\r\n                    <li><strong>");
            EndContext();
            BeginContext(2641, 46, false);
#line 69 "C:\Users\samaritan\Documents\Visual Studio 2017\Projects\VPM\VPM\Views\Account\Dashboard.cshtml"
                           Write(p.Where(x => x.adminApproved == false).Count());

#line default
#line hidden
            EndContext();
            BeginContext(2687, 56, true);
            WriteLiteral("</strong> Pending</li>\r\n                    <li><strong>");
            EndContext();
            BeginContext(2744, 72, false);
#line 70 "C:\Users\samaritan\Documents\Visual Studio 2017\Projects\VPM\VPM\Views\Account\Dashboard.cshtml"
                           Write(p.Where(x => x.PropertyStatus == "Available" && x.adminApproved).Count());

#line default
#line hidden
            EndContext();
            BeginContext(2816, 55, true);
            WriteLiteral("</strong> Vacant</li>\r\n                    <li><strong>");
            EndContext();
            BeginContext(2872, 53, false);
#line 71 "C:\Users\samaritan\Documents\Visual Studio 2017\Projects\VPM\VPM\Views\Account\Dashboard.cshtml"
                           Write(p.Where(x => x.PropertyStatus != "Available").Count());

#line default
#line hidden
            EndContext();
            BeginContext(2925, 361, true);
            WriteLiteral(@"</strong> Not Vacant</li>
                </ul>
            </div>
        </div>
    </div>

    <div class=""col-md-9"">
        <div class=""card bshadow"" style=""min-height:300px!important;"">
            <div class=""card-header _active"">Expected revenue</div>
            <div class=""card-body"">
                <h1 style=""font-size:100px!important;"">");
            EndContext();
            BeginContext(3287, 29, false);
#line 81 "C:\Users\samaritan\Documents\Visual Studio 2017\Projects\VPM\VPM\Views\Account\Dashboard.cshtml"
                                                  Write(globals.getLocalCurrencyNG(0));

#line default
#line hidden
            EndContext();
            BeginContext(3316, 67, true);
            WriteLiteral("</h1>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n\r\n</div>\r\n");
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
