#pragma checksum "C:\Users\samaritan\Documents\VPM\VPM\Views\Client\ReportIssue.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62b93ab6700ecfaf2bf0732e22acd8e8c8bf5b7f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Client_ReportIssue), @"mvc.1.0.view", @"/Views/Client/ReportIssue.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Client/ReportIssue.cshtml", typeof(AspNetCore.Views_Client_ReportIssue))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62b93ab6700ecfaf2bf0732e22acd8e8c8bf5b7f", @"/Views/Client/ReportIssue.cshtml")]
    public class Views_Client_ReportIssue : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/account/assets/img/img_add_more.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\samaritan\Documents\VPM\VPM\Views\Client\ReportIssue.cshtml"
   Layout = "_Layout";

#line default
#line hidden
#line 2 "C:\Users\samaritan\Documents\VPM\VPM\Views\Client\ReportIssue.cshtml"
  var ass = (VPM.Models.mAssignments)ViewBag.ass;

#line default
#line hidden
            BeginContext(77, 1155, true);
            WriteLiteral(@"

<div class=""container"">

    <div class=""row"">
        <div class=""col-md-12"">
            <div class=""panel panel-default"">
                <div class=""panel-heading"" style=""background:#000;color:#fff"">Report Issue</div>
                <div class=""panel-body"">

                    <div class=""row"">
                        <div class=""col-md-12"">
                            <div class=""input-group"">
                                <label>TenantID</label>
                                <input id=""tenantID"" name=""tenantID"" type=""text"" class=""form-control"" placeholder="""" />
                            </div>
                        </div>
                    </div>


                    <div class=""row"">
                        <div class=""col-md-12"">
                            <div class=""input-group"">
                                <label>Issue</label>
                                <textarea class=""form-control"" placeholder=""...""></textarea>
                            </div>
");
            WriteLiteral("                        </div>\r\n                    </div>\r\n\r\n                    <hr />\r\n\r\n                    <div class=\"row\">\r\n");
            EndContext();
            BeginContext(1287, 454, true);
            WriteLiteral(@"                        <div class=""col-md-6"" style=""border-right: 1px solid #000000;"">
                            <div class=""row"">
                                <div class=""col-md-12"">
                                    Upload Property Images
                                    <input id=""fimages"" type=""file"" accept=""image/*"" multiple style=""visibility:hidden;"" />
                                </div>
                            </div>
");
            EndContext();
            BeginContext(1789, 414, true);
            WriteLiteral(@"                            <div class=""row"" id=""pimages"">

                                <div class=""col-md-4"">
                                    <div class=""divImageHolder"">
                                        <a href=""javascript:void(0);"" onclick=""openFimages();"">
                                            <div class=""divImageItem firstProduct"">
                                                ");
            EndContext();
            BeginContext(2203, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e3723fd72dc7449ca1fac89526f8c4ce", async() => {
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
            BeginContext(2254, 312, true);
            WriteLiteral(@"
                                                <span class=""text-content""><span>CLICK TO UPLOAD <br />IMAGE</span></span>
                                            </div>
                                        </a>
                                    </div>
                                </div>


");
            EndContext();
#line 58 "C:\Users\samaritan\Documents\VPM\VPM\Views\Client\ReportIssue.cshtml"
                                 foreach (var i in ass.images)
                                {

#line default
#line hidden
            BeginContext(2665, 57, true);
            WriteLiteral("                                    <div class=\"col-md-4\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2722, "\"", 2729, 1);
#line 60 "C:\Users\samaritan\Documents\VPM\VPM\Views\Client\ReportIssue.cshtml"
WriteAttributeValue("", 2727, i, 2727, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2730, 294, true);
            WriteLiteral(@">
                                        <div class=""divImageHolder"">
                                            <a href=""javascript:void(0);"">
                                                <div class=""divImageItem firstProduct"">
                                                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 3024, "\"", 3032, 1);
#line 64 "C:\Users\samaritan\Documents\VPM\VPM\Views\Client\ReportIssue.cshtml"
WriteAttributeValue("", 3030, i, 3030, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3033, 272, true);
            WriteLiteral(@" style=""object-fit:cover"" />
                                                    <span class=""text-content"">
                                                        <span>
                                                            <i class=""fa fa-trash"" title=""delete""");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 3305, "\"", 3353, 5);
            WriteAttributeValue("", 3315, "removeAssignmentImage(\'", 3315, 23, true);
#line 67 "C:\Users\samaritan\Documents\VPM\VPM\Views\Client\ReportIssue.cshtml"
WriteAttributeValue("", 3338, ass._id, 3338, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 3346, "\',\'", 3346, 3, true);
#line 67 "C:\Users\samaritan\Documents\VPM\VPM\Views\Client\ReportIssue.cshtml"
WriteAttributeValue("", 3349, i, 3349, 2, false);

#line default
#line hidden
            WriteAttributeValue("", 3351, "\')", 3351, 2, true);
            EndWriteAttribute();
            BeginContext(3354, 331, true);
            WriteLiteral(@"></i>
                                                        </span>
                                                    </span>
                                                </div>
                                            </a>
                                        </div>
                                    </div>
");
            EndContext();
#line 74 "C:\Users\samaritan\Documents\VPM\VPM\Views\Client\ReportIssue.cshtml"
                                }

#line default
#line hidden
            BeginContext(3720, 84, true);
            WriteLiteral("\r\n                            </div><!-- /.row -->\r\n                        </div>\r\n");
            EndContext();
            BeginContext(3854, 112, true);
            WriteLiteral("                    </div>\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n");
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
