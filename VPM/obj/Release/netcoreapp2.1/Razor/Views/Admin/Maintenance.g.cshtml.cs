#pragma checksum "C:\Users\samaritan\Documents\VPM\VPM\Views\Admin\Maintenance.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d0c5241d818d4beab21bc8b25520c9d54e098936"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Maintenance), @"mvc.1.0.view", @"/Views/Admin/Maintenance.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/Maintenance.cshtml", typeof(AspNetCore.Views_Admin_Maintenance))]
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
#line 5 "C:\Users\samaritan\Documents\VPM\VPM\Views\Admin\Maintenance.cshtml"
using PagedList.Core;

#line default
#line hidden
#line 6 "C:\Users\samaritan\Documents\VPM\VPM\Views\Admin\Maintenance.cshtml"
using PagedList;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0c5241d818d4beab21bc8b25520c9d54e098936", @"/Views/Admin/Maintenance.cshtml")]
    public class Views_Admin_Maintenance : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "pending", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "started", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "completed", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("dd"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Admin/Maintenance"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\samaritan\Documents\VPM\VPM\Views\Admin\Maintenance.cshtml"
  Layout = "_Layout";

#line default
#line hidden
#line 2 "C:\Users\samaritan\Documents\VPM\VPM\Views\Admin\Maintenance.cshtml"
   var props = (List<VPM.Models.mProperty>)ViewBag.props;

#line default
#line hidden
            BeginContext(84, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(131, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(224, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 11 "C:\Users\samaritan\Documents\VPM\VPM\Views\Admin\Maintenance.cshtml"
   var ass = (IPagedList<VPM.Models.mAssignments>)ViewBag.ass;

#line default
#line hidden
            BeginContext(291, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(609, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(611, 1740, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4f2083a229904dda89c1f73cb42dc29a", async() => {
                BeginContext(666, 220, true);
                WriteLiteral("\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col-md-4\">\r\n            <div class=\"input-group\">\r\n                <select id=\"Select1\" class=\"form-control\" style=\"height:40px!important;\" name=\"pid\">\r\n                    ");
                EndContext();
                BeginContext(886, 29, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31913cd8bab2476a853c180901fd7002", async() => {
                    BeginContext(903, 3, true);
                    WriteLiteral("All");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(915, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 33 "C:\Users\samaritan\Documents\VPM\VPM\Views\Admin\Maintenance.cshtml"
                     foreach (var p in props)
                    {

#line default
#line hidden
                BeginContext(987, 24, true);
                WriteLiteral("                        ");
                EndContext();
                BeginContext(1011, 130, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "717b3d5971e1423faad1f714d0ab93d6", async() => {
                    BeginContext(1068, 14, false);
#line 35 "C:\Users\samaritan\Documents\VPM\VPM\Views\Admin\Maintenance.cshtml"
                                                                           Write(p.propertyName);

#line default
#line hidden
                    EndContext();
                    BeginContext(1082, 2, true);
                    WriteLiteral(" (");
                    EndContext();
                    BeginContext(1085, 17, false);
#line 35 "C:\Users\samaritan\Documents\VPM\VPM\Views\Admin\Maintenance.cshtml"
                                                                                            Write(p.getOwner().name);

#line default
#line hidden
                    EndContext();
                    BeginContext(1102, 2, true);
                    WriteLiteral("  ");
                    EndContext();
                    BeginContext(1105, 20, false);
#line 35 "C:\Users\samaritan\Documents\VPM\VPM\Views\Admin\Maintenance.cshtml"
                                                                                                                Write(p.getOwner().surname);

#line default
#line hidden
                    EndContext();
                    BeginContext(1125, 7, true);
                    WriteLiteral("  )    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "selected", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 35 "C:\Users\samaritan\Documents\VPM\VPM\Views\Admin\Maintenance.cshtml"
AddHtmlAttributeValue("", 1029, ViewBag.pid==p._id, 1029, 21, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                BeginWriteTagHelperAttribute();
#line 35 "C:\Users\samaritan\Documents\VPM\VPM\Views\Admin\Maintenance.cshtml"
                                                            WriteLiteral(p._id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1141, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 36 "C:\Users\samaritan\Documents\VPM\VPM\Views\Admin\Maintenance.cshtml"
                    }

#line default
#line hidden
                BeginContext(1166, 485, true);
                WriteLiteral(@"                </select>
                <span class=""input-group-btn"">
                    <button type=""submit"" class=""btn btn-primary"">
                        <span>Select Property</span>
                    </button>
                </span>
            </div>
        </div>

        <div class=""col-md-4"">
            <div class=""input-group"">
                <select class=""form-control"" name=""AssignmentStatus""  style=""height:40px!important;"">
                    ");
                EndContext();
                BeginContext(1651, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a2dc85b19d040d7a9333f859362da40", async() => {
                    BeginContext(1675, 3, true);
                    WriteLiteral("All");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1687, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(1709, 90, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a6a13dceee1d4532b1bb391c4cbbc070", async() => {
                    BeginContext(1783, 7, true);
                    WriteLiteral("Pending");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "selected", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 50 "C:\Users\samaritan\Documents\VPM\VPM\Views\Admin\Maintenance.cshtml"
AddHtmlAttributeValue("", 1743, ViewBag.AssignmentStatus=="pending", 1743, 38, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1799, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(1821, 90, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2b001a95c43741578d832634b7fd442b", async() => {
                    BeginContext(1895, 7, true);
                    WriteLiteral("Started");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "selected", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 51 "C:\Users\samaritan\Documents\VPM\VPM\Views\Admin\Maintenance.cshtml"
AddHtmlAttributeValue("", 1855, ViewBag.AssignmentStatus=="started", 1855, 38, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1911, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(1933, 96, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ba2408137d54c78ab9d04bd092f1652", async() => {
                    BeginContext(2011, 9, true);
                    WriteLiteral("Completed");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "selected", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 52 "C:\Users\samaritan\Documents\VPM\VPM\Views\Admin\Maintenance.cshtml"
AddHtmlAttributeValue("", 1969, ViewBag.AssignmentStatus=="completed", 1969, 40, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2029, 306, true);
                WriteLiteral(@"
                </select>
                <span class=""input-group-btn"">
                    <button type=""submit"" class=""btn btn-primary"">
                        <span>Maintenance Status</span>
                    </button>
                </span>
            </div>
        </div>

    </div>");
                EndContext();
                BeginContext(2342, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2351, 24, true);
            WriteLiteral("\r\n\r\n\r\n<br />\r\n<br />\r\n\r\n");
            EndContext();
#line 69 "C:\Users\samaritan\Documents\VPM\VPM\Views\Admin\Maintenance.cshtml"
 if (ass.Count > 0)
{

#line default
#line hidden
            BeginContext(2397, 413, true);
            WriteLiteral(@"<div class=""row"">
        <div class=""col-md-12"">
            <table class=""table table-bordered tblsm"">
                <thead>
                    <tr>
                        <th>Date</th>
                        <th>Status</th>
                        <th>Description</th>
                        <th>Completion Date</th>
                    </tr>
                </thead>
                <tbody>
");
            EndContext();
#line 82 "C:\Users\samaritan\Documents\VPM\VPM\Views\Admin\Maintenance.cshtml"
                     foreach (var a in ass)
                    {

#line default
#line hidden
            BeginContext(2878, 96, true);
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2975, 30, false);
#line 86 "C:\Users\samaritan\Documents\VPM\VPM\Views\Admin\Maintenance.cshtml"
                           Write(a.date.ToString("dd MMM yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(3005, 106, true);
            WriteLiteral(";\r\n                            </td>\r\n\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(3112, 23, false);
#line 90 "C:\Users\samaritan\Documents\VPM\VPM\Views\Admin\Maintenance.cshtml"
                           Write(a.getAssignmentStatus());

#line default
#line hidden
            EndContext();
            BeginContext(3135, 71, true);
            WriteLiteral(";\r\n                            </td>\r\n\r\n                            <td");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 3206, "\"", 3228, 1);
#line 93 "C:\Users\samaritan\Documents\VPM\VPM\Views\Admin\Maintenance.cshtml"
WriteAttributeValue("", 3214, a.description, 3214, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3229, 35, true);
            WriteLiteral(">\r\n                                ");
            EndContext();
            BeginContext(3265, 13, false);
#line 94 "C:\Users\samaritan\Documents\VPM\VPM\Views\Admin\Maintenance.cshtml"
                           Write(a.description);

#line default
#line hidden
            EndContext();
            BeginContext(3278, 105, true);
            WriteLiteral("\r\n                            </td>\r\n\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(3384, 42, false);
#line 98 "C:\Users\samaritan\Documents\VPM\VPM\Views\Admin\Maintenance.cshtml"
                           Write(a.completetionDate.ToString("dd MMM yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(3426, 69, true);
            WriteLiteral(";\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 101 "C:\Users\samaritan\Documents\VPM\VPM\Views\Admin\Maintenance.cshtml"

                    }

#line default
#line hidden
            BeginContext(3520, 80, true);
            WriteLiteral("\r\n                </tbody>\r\n            </table>\r\n\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 109 "C:\Users\samaritan\Documents\VPM\VPM\Views\Admin\Maintenance.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(3612, 97, true);
            WriteLiteral("    <center>\r\n        <h3>\r\n            No Outstanding Maintenace\r\n        </h3>\r\n    </center>\r\n");
            EndContext();
#line 117 "C:\Users\samaritan\Documents\VPM\VPM\Views\Admin\Maintenance.cshtml"

}

#line default
#line hidden
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
