#pragma checksum "C:\Users\samaritan\Documents\VPM\VPM\Views\Admin\Artisans.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0798e95b7d392aff42aea8a44f24f74d9d287f5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Artisans), @"mvc.1.0.view", @"/Views/Admin/Artisans.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/Artisans.cshtml", typeof(AspNetCore.Views_Admin_Artisans))]
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
#line 3 "C:\Users\samaritan\Documents\VPM\VPM\Views\Admin\Artisans.cshtml"
using PagedList.Core;

#line default
#line hidden
#line 4 "C:\Users\samaritan\Documents\VPM\VPM\Views\Admin\Artisans.cshtml"
using PagedList;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0798e95b7d392aff42aea8a44f24f74d9d287f5", @"/Views/Admin/Artisans.cshtml")]
    public class Views_Admin_Artisans : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/libs/rating/jquery.barrating.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/libs/rating/themes/fontawesome-stars.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "notregistered", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "registered", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("pager-container"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Artisans", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-keyword", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Admin/Artisans"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::PagedList.Core.Mvc.PagerTagHelper __PagedList_Core_Mvc_PagerTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\samaritan\Documents\VPM\VPM\Views\Admin\Artisans.cshtml"
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(24, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(69, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(162, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 9 "C:\Users\samaritan\Documents\VPM\VPM\Views\Admin\Artisans.cshtml"
   var artisans = (IPagedList<VPM.Models.mArtisan>)ViewBag.artisans;

#line default
#line hidden
            BeginContext(235, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(255, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b059129fe3445019b7ff2bcd802bbfd", async() => {
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
            BeginContext(323, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(325, 82, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "539b0db7a5ec48cb8b8f1aa623f43124", async() => {
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
            BeginContext(407, 139, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        <div class=\"card bshadow\">\r\n            <div class=\"card-header _active\">Result (");
            EndContext();
            BeginContext(547, 14, false);
#line 18 "C:\Users\samaritan\Documents\VPM\VPM\Views\Admin\Artisans.cshtml"
                                                Write(artisans.Count);

#line default
#line hidden
            EndContext();
            BeginContext(561, 62, true);
            WriteLiteral(")</div>\r\n            <div class=\"card-body\">\r\n                ");
            EndContext();
            BeginContext(623, 3357, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e1b91cbbb547457790d0b370f3f36cd4", async() => {
                BeginContext(668, 280, true);
                WriteLiteral(@"
                    <table class=""table tblsm"">
                        <thead>
                            <tr>
                                <th>
                                    <select style=""width:100%;"" name=""registered"">
                                        ");
                EndContext();
                BeginContext(948, 103, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f3ad6f61762d4c519bddbd07c7337578", async() => {
                    BeginContext(1028, 14, true);
                    WriteLiteral("not registered");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "selected", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 26 "C:\Users\samaritan\Documents\VPM\VPM\Views\Admin\Artisans.cshtml"
AddHtmlAttributeValue("", 966, ViewBag.registered=="notregistered", 966, 38, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1051, 42, true);
                WriteLiteral("\r\n                                        ");
                EndContext();
                BeginContext(1093, 93, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e3266fcc2fd458fa1a5b3744c3c2ba3", async() => {
                    BeginContext(1167, 10, true);
                    WriteLiteral("registered");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "selected", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 27 "C:\Users\samaritan\Documents\VPM\VPM\Views\Admin\Artisans.cshtml"
AddHtmlAttributeValue("", 1111, ViewBag.registered=="registered", 1111, 35, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1186, 173, true);
                WriteLiteral("\r\n                                    </select>\r\n                                </th>\r\n                                <th><input placeholder=\"name\" type=\"text\" name=\"name\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1359, "\"", 1380, 1);
#line 30 "C:\Users\samaritan\Documents\VPM\VPM\Views\Admin\Artisans.cshtml"
WriteAttributeValue("", 1367, ViewBag.name, 1367, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1381, 101, true);
                WriteLiteral(" /></th>\r\n                                <th><input placeholder=\"surname\" type=\"text\" name=\"surname\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1482, "\"", 1506, 1);
#line 31 "C:\Users\samaritan\Documents\VPM\VPM\Views\Admin\Artisans.cshtml"
WriteAttributeValue("", 1490, ViewBag.surname, 1490, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1507, 99, true);
                WriteLiteral(" /></th>\r\n                                <th><input placeholder=\"mobile\" type=\"text\" name=\"mobile\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1606, "\"", 1629, 1);
#line 32 "C:\Users\samaritan\Documents\VPM\VPM\Views\Admin\Artisans.cshtml"
WriteAttributeValue("", 1614, ViewBag.mobile, 1614, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1630, 95, true);
                WriteLiteral(" /></th>\r\n                                <th><input placeholder=\"city\" type=\"text\" name=\"city\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1725, "\"", 1746, 1);
#line 33 "C:\Users\samaritan\Documents\VPM\VPM\Views\Admin\Artisans.cshtml"
WriteAttributeValue("", 1733, ViewBag.city, 1733, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1747, 617, true);
                WriteLiteral(@" /></th>
                                <th><button value=""search"" type=""submit"" style=""height:20px""> &nbsp;&nbsp; search &nbsp;&nbsp;</button></th>
                            </tr>

                            <tr>
                                <th>Enabled</th>
                                <th>Name</th>
                                <th>Surname</th>
                                <th>Mobile</th>
                                <th>City</th>
                                <th>Action</th>
                            </tr>
                        </thead>
                        <tbody>
");
                EndContext();
#line 47 "C:\Users\samaritan\Documents\VPM\VPM\Views\Admin\Artisans.cshtml"
                             foreach (var a in artisans)
                            {

#line default
#line hidden
                BeginContext(2453, 77, true);
                WriteLiteral("                                <tr>\r\n                                    <td");
                EndContext();
                BeginWriteAttribute("title", " title=\"", 2530, "\"", 2551, 1);
#line 50 "C:\Users\samaritan\Documents\VPM\VPM\Views\Admin\Artisans.cshtml"
WriteAttributeValue("", 2538, a.registered, 2538, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2552, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(2554, 12, false);
#line 50 "C:\Users\samaritan\Documents\VPM\VPM\Views\Admin\Artisans.cshtml"
                                                         Write(a.registered);

#line default
#line hidden
                EndContext();
                BeginContext(2566, 46, true);
                WriteLiteral("</td>\r\n                                    <td");
                EndContext();
                BeginWriteAttribute("title", " title=\"", 2612, "\"", 2627, 1);
#line 51 "C:\Users\samaritan\Documents\VPM\VPM\Views\Admin\Artisans.cshtml"
WriteAttributeValue("", 2620, a.name, 2620, 7, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2628, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(2630, 6, false);
#line 51 "C:\Users\samaritan\Documents\VPM\VPM\Views\Admin\Artisans.cshtml"
                                                   Write(a.name);

#line default
#line hidden
                EndContext();
                BeginContext(2636, 46, true);
                WriteLiteral("</td>\r\n                                    <td");
                EndContext();
                BeginWriteAttribute("title", " title=\"", 2682, "\"", 2700, 1);
#line 52 "C:\Users\samaritan\Documents\VPM\VPM\Views\Admin\Artisans.cshtml"
WriteAttributeValue("", 2690, a.surname, 2690, 10, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2701, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(2703, 9, false);
#line 52 "C:\Users\samaritan\Documents\VPM\VPM\Views\Admin\Artisans.cshtml"
                                                      Write(a.surname);

#line default
#line hidden
                EndContext();
                BeginContext(2712, 46, true);
                WriteLiteral("</td>\r\n                                    <td");
                EndContext();
                BeginWriteAttribute("title", " title=\"", 2758, "\"", 2775, 1);
#line 53 "C:\Users\samaritan\Documents\VPM\VPM\Views\Admin\Artisans.cshtml"
WriteAttributeValue("", 2766, a.mobile, 2766, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2776, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(2778, 8, false);
#line 53 "C:\Users\samaritan\Documents\VPM\VPM\Views\Admin\Artisans.cshtml"
                                                     Write(a.mobile);

#line default
#line hidden
                EndContext();
                BeginContext(2786, 46, true);
                WriteLiteral("</td>\r\n                                    <td");
                EndContext();
                BeginWriteAttribute("title", " title=\"", 2832, "\"", 2853, 1);
#line 54 "C:\Users\samaritan\Documents\VPM\VPM\Views\Admin\Artisans.cshtml"
WriteAttributeValue("", 2840, a.cityOrTown, 2840, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2854, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(2856, 12, false);
#line 54 "C:\Users\samaritan\Documents\VPM\VPM\Views\Admin\Artisans.cshtml"
                                                         Write(a.cityOrTown);

#line default
#line hidden
                EndContext();
                BeginContext(2868, 91, true);
                WriteLiteral("</td>\r\n                                    <td>\r\n                                        <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2959, "\"", 3006, 2);
                WriteAttributeValue("", 2966, "/Admin/ViewArtisanFullProfile?aid=", 2966, 34, true);
#line 56 "C:\Users\samaritan\Documents\VPM\VPM\Views\Admin\Artisans.cshtml"
WriteAttributeValue("", 3000, a._id, 3000, 6, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3007, 101, true);
                WriteLiteral(">View Profile</a>\r\n                                    </td>\r\n                                </tr>\r\n");
                EndContext();
#line 59 "C:\Users\samaritan\Documents\VPM\VPM\Views\Admin\Artisans.cshtml"
                            }

#line default
#line hidden
                BeginContext(3139, 66, true);
                WriteLiteral("                        </tbody>\r\n                    </table>\r\n\r\n");
                EndContext();
#line 63 "C:\Users\samaritan\Documents\VPM\VPM\Views\Admin\Artisans.cshtml"
                      
                        var dic = new Dictionary<string, string>();
                        dic.Add("name", ViewBag.name);
                        dic.Add("surname", ViewBag.surname);
                        dic.Add("mobile", ViewBag.mobile);
                        dic.Add("city", ViewBag.city);
                    

#line default
#line hidden
                BeginContext(3555, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(3577, 378, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("pager", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2b59f3b6e04b4c589324c9fa7b38f548", async() => {
                }
                );
                __PagedList_Core_Mvc_PagerTagHelper = CreateTagHelper<global::PagedList.Core.Mvc.PagerTagHelper>();
                __tagHelperExecutionContext.Add(__PagedList_Core_Mvc_PagerTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
#line 72 "C:\Users\samaritan\Documents\VPM\VPM\Views\Admin\Artisans.cshtml"
__PagedList_Core_Mvc_PagerTagHelper.List = artisans;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("list", __PagedList_Core_Mvc_PagerTagHelper.List, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 73 "C:\Users\samaritan\Documents\VPM\VPM\Views\Admin\Artisans.cshtml"
__PagedList_Core_Mvc_PagerTagHelper.Options = PagedList.Core.Mvc.PagedListRenderOptions.PageNumbersOnly;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("options", __PagedList_Core_Mvc_PagerTagHelper.Options, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __PagedList_Core_Mvc_PagerTagHelper.AspAction = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __PagedList_Core_Mvc_PagerTagHelper.AspController = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
#line 76 "C:\Users\samaritan\Documents\VPM\VPM\Views\Admin\Artisans.cshtml"
__PagedList_Core_Mvc_PagerTagHelper.RouteValues = dic;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-all-route-data", __PagedList_Core_Mvc_PagerTagHelper.RouteValues, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
                BeginContext(3955, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3980, 70, true);
            WriteLiteral("\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n");
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
