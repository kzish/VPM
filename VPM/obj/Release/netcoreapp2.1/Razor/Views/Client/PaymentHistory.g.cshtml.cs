#pragma checksum "C:\Users\samaritan\Documents\VPM\VPM\Views\Client\PaymentHistory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4c1a00f70ff7e9360a747092546855e19af79f0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Client_PaymentHistory), @"mvc.1.0.view", @"/Views/Client/PaymentHistory.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Client/PaymentHistory.cshtml", typeof(AspNetCore.Views_Client_PaymentHistory))]
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
#line 2 "C:\Users\samaritan\Documents\VPM\VPM\Views\Client\PaymentHistory.cshtml"
using PagedList.Core;

#line default
#line hidden
#line 3 "C:\Users\samaritan\Documents\VPM\VPM\Views\Client\PaymentHistory.cshtml"
using PagedList;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4c1a00f70ff7e9360a747092546855e19af79f0", @"/Views/Client/PaymentHistory.cshtml")]
    public class Views_Client_PaymentHistory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Client/PaymentHistory"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("pager-container"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PaymentHistory", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Client", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-keyword", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::PagedList.Core.Mvc.PagerTagHelper __PagedList_Core_Mvc_PagerTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\samaritan\Documents\VPM\VPM\Views\Client\PaymentHistory.cshtml"
   Layout = "_Layout";

#line default
#line hidden
            BeginContext(68, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(161, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
#line 10 "C:\Users\samaritan\Documents\VPM\VPM\Views\Client\PaymentHistory.cshtml"
   var payments = (IPagedList<VPM.Models.mPayments>)ViewBag.payments;

#line default
#line hidden
#line 11 "C:\Users\samaritan\Documents\VPM\VPM\Views\Client\PaymentHistory.cshtml"
   var index = 1;

#line default
#line hidden
            BeginContext(259, 97, true);
            WriteLiteral("<div class=\"container\">\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col-md-12\">\r\n\r\n            ");
            EndContext();
            BeginContext(356, 1127, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef601284ca3a4085a9366fbf66322f8a", async() => {
                BeginContext(416, 274, true);
                WriteLiteral(@"
                <div class=""row"">
                    <div class=""col-md-4"">
                        <div class=""form-group"">
                            <label>Date From</label>
                            <input type=""text"" class=""form-control"" name=""from"" id=""from""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 690, "\"", 711, 1);
#line 22 "C:\Users\samaritan\Documents\VPM\VPM\Views\Client\PaymentHistory.cshtml"
WriteAttributeValue("", 698, ViewBag.from, 698, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(712, 295, true);
                WriteLiteral(@"/>
                        </div>
                    </div>
                    <div class=""col-md-4"">
                        <div class=""form-group"">
                            <label>Date To</label>
                            <input type=""text"" class=""form-control"" name=""to"" id=""to""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1007, "\"", 1026, 1);
#line 28 "C:\Users\samaritan\Documents\VPM\VPM\Views\Client\PaymentHistory.cshtml"
WriteAttributeValue("", 1015, ViewBag.to, 1015, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1027, 449, true);
                WriteLiteral(@" />
                        </div>
                    </div>
                    <div class=""col-md-4"">
                        <div class=""form-group"">
                            <label>&nbsp;</label>
                            <input id=""Submit1"" type=""submit"" value=""submit"" class=""btn btn-outline-secondary _active btn-sm form-control"" />
                        </div>
                    </div>
                </div>
            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1483, 44, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <br />\r\n\r\n");
            EndContext();
#line 43 "C:\Users\samaritan\Documents\VPM\VPM\Views\Client\PaymentHistory.cshtml"
     if (payments.Count > 0)
    {


#line default
#line hidden
            BeginContext(1566, 440, true);
            WriteLiteral(@"    <div class=""row"">
        <div class=""col-md-12"">

            <table class=""table tblsm"">
                <tr>
                    <th>ID</th>
                    <th>DATE</th>
                    <th>REFERENCE</th>
                    <th>ARTISAN/PROPERTY</th>
                    <th>PAYMENT TYPE</th>
                    <th>AMOUNT</th>
                    <th>TXREF</th>
                </tr>
                <tbody>
");
            EndContext();
#line 60 "C:\Users\samaritan\Documents\VPM\VPM\Views\Client\PaymentHistory.cshtml"
                     foreach (var p in payments)
                    {

#line default
#line hidden
            BeginContext(2079, 61, true);
            WriteLiteral("                        <tr>\r\n                            <td");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 2140, "\"", 2154, 1);
#line 63 "C:\Users\samaritan\Documents\VPM\VPM\Views\Client\PaymentHistory.cshtml"
WriteAttributeValue("", 2148, index, 2148, 6, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2155, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(2157, 5, false);
#line 63 "C:\Users\samaritan\Documents\VPM\VPM\Views\Client\PaymentHistory.cshtml"
                                          Write(index);

#line default
#line hidden
            EndContext();
            BeginContext(2162, 38, true);
            WriteLiteral("</td>\r\n                            <td");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 2200, "\"", 2235, 1);
#line 64 "C:\Users\samaritan\Documents\VPM\VPM\Views\Client\PaymentHistory.cshtml"
WriteAttributeValue("", 2208, p.date.ToShortDateString(), 2208, 27, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2236, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(2238, 26, false);
#line 64 "C:\Users\samaritan\Documents\VPM\VPM\Views\Client\PaymentHistory.cshtml"
                                                               Write(p.date.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(2264, 38, true);
            WriteLiteral("</td>\r\n                            <td");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 2302, "\"", 2322, 1);
#line 65 "C:\Users\samaritan\Documents\VPM\VPM\Views\Client\PaymentHistory.cshtml"
WriteAttributeValue("", 2310, p.reference, 2310, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2323, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(2325, 11, false);
#line 65 "C:\Users\samaritan\Documents\VPM\VPM\Views\Client\PaymentHistory.cshtml"
                                                Write(p.reference);

#line default
#line hidden
            EndContext();
            BeginContext(2336, 38, true);
            WriteLiteral("</td>\r\n                            <td");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 2374, "\"", 2407, 2);
#line 66 "C:\Users\samaritan\Documents\VPM\VPM\Views\Client\PaymentHistory.cshtml"
WriteAttributeValue("", 2382, p.artisanID, 2382, 12, false);

#line default
#line hidden
#line 66 "C:\Users\samaritan\Documents\VPM\VPM\Views\Client\PaymentHistory.cshtml"
WriteAttributeValue("", 2394, p.propertyID, 2394, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2408, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(2410, 11, false);
#line 66 "C:\Users\samaritan\Documents\VPM\VPM\Views\Client\PaymentHistory.cshtml"
                                                             Write(p.artisanID);

#line default
#line hidden
            EndContext();
            BeginContext(2422, 12, false);
#line 66 "C:\Users\samaritan\Documents\VPM\VPM\Views\Client\PaymentHistory.cshtml"
                                                                         Write(p.propertyID);

#line default
#line hidden
            EndContext();
            BeginContext(2434, 5, true);
            WriteLiteral("</td>");
            EndContext();
            BeginContext(2473, 33, true);
            WriteLiteral("\r\n                            <td");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 2506, "\"", 2533, 1);
#line 67 "C:\Users\samaritan\Documents\VPM\VPM\Views\Client\PaymentHistory.cshtml"
WriteAttributeValue("", 2514, p.getpaymentType(), 2514, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2534, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(2536, 18, false);
#line 67 "C:\Users\samaritan\Documents\VPM\VPM\Views\Client\PaymentHistory.cshtml"
                                                       Write(p.getpaymentType());

#line default
#line hidden
            EndContext();
            BeginContext(2554, 38, true);
            WriteLiteral("</td>\r\n                            <td");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 2592, "\"", 2609, 1);
#line 68 "C:\Users\samaritan\Documents\VPM\VPM\Views\Client\PaymentHistory.cshtml"
WriteAttributeValue("", 2600, p.amount, 2600, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2610, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(2612, 8, false);
#line 68 "C:\Users\samaritan\Documents\VPM\VPM\Views\Client\PaymentHistory.cshtml"
                                             Write(p.amount);

#line default
#line hidden
            EndContext();
            BeginContext(2620, 38, true);
            WriteLiteral("</td>\r\n                            <td");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 2658, "\"", 2675, 1);
#line 69 "C:\Users\samaritan\Documents\VPM\VPM\Views\Client\PaymentHistory.cshtml"
WriteAttributeValue("", 2666, p.flwRef, 2666, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2676, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(2678, 8, false);
#line 69 "C:\Users\samaritan\Documents\VPM\VPM\Views\Client\PaymentHistory.cshtml"
                                             Write(p.flwRef);

#line default
#line hidden
            EndContext();
            BeginContext(2686, 38, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n");
            EndContext();
#line 71 "C:\Users\samaritan\Documents\VPM\VPM\Views\Client\PaymentHistory.cshtml"
                        index++;
                    }

#line default
#line hidden
            BeginContext(2781, 64, true);
            WriteLiteral("\r\n                </tbody>\r\n            </table>\r\n\r\n            ");
            EndContext();
            BeginContext(2845, 292, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("pager", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d291e5ee1812459699111800c6b310d8", async() => {
            }
            );
            __PagedList_Core_Mvc_PagerTagHelper = CreateTagHelper<global::PagedList.Core.Mvc.PagerTagHelper>();
            __tagHelperExecutionContext.Add(__PagedList_Core_Mvc_PagerTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#line 78 "C:\Users\samaritan\Documents\VPM\VPM\Views\Client\PaymentHistory.cshtml"
__PagedList_Core_Mvc_PagerTagHelper.List = payments;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("list", __PagedList_Core_Mvc_PagerTagHelper.List, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 79 "C:\Users\samaritan\Documents\VPM\VPM\Views\Client\PaymentHistory.cshtml"
__PagedList_Core_Mvc_PagerTagHelper.Options = PagedList.Core.Mvc.PagedListRenderOptions.PageNumbersOnly;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("options", __PagedList_Core_Mvc_PagerTagHelper.Options, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __PagedList_Core_Mvc_PagerTagHelper.AspAction = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __PagedList_Core_Mvc_PagerTagHelper.AspController = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__PagedList_Core_Mvc_PagerTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-keyword", "PagedList.Core.Mvc.PagerTagHelper", "RouteValues"));
            }
            __PagedList_Core_Mvc_PagerTagHelper.RouteValues["keyword"] = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3137, 30, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 85 "C:\Users\samaritan\Documents\VPM\VPM\Views\Client\PaymentHistory.cshtml"

    }
    else
    {

#line default
#line hidden
            BeginContext(3193, 102, true);
            WriteLiteral("        <center>\r\n            <h2>No Payment Data<br />In the Selected Range</h2>\r\n        </center>\r\n");
            EndContext();
#line 92 "C:\Users\samaritan\Documents\VPM\VPM\Views\Client\PaymentHistory.cshtml"

    }

#line default
#line hidden
            BeginContext(3304, 197, true);
            WriteLiteral("\r\n</div>\r\n\r\n<script>\r\n    $(\"#from\").Zebra_DatePicker({\r\n        direction: false,\r\n    });\r\n    $(\"#to\").Zebra_DatePicker({\r\n        direction: false,\r\n        pair: $(\'#from\')\r\n    });\r\n</script>");
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
