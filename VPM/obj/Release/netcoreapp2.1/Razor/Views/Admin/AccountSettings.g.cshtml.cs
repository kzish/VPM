#pragma checksum "C:\Users\samaritan\Documents\VPM\VPM\Views\Admin\AccountSettings.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb46896054f8aa3f8cbf1d9ebb9b8c89f43e9449"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_AccountSettings), @"mvc.1.0.view", @"/Views/Admin/AccountSettings.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/AccountSettings.cshtml", typeof(AspNetCore.Views_Admin_AccountSettings))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb46896054f8aa3f8cbf1d9ebb9b8c89f43e9449", @"/Views/Admin/AccountSettings.cshtml")]
    public class Views_Admin_AccountSettings : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/css/switch.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/libs/jquery_alerts/jquery-confirm.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/libs/jquery_alerts/jquery-confirm.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/libs/validate/jquery_validator/jquery.validate.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\samaritan\Documents\VPM\VPM\Views\Admin\AccountSettings.cshtml"
  Layout = "_Layout";

#line default
#line hidden
#line 2 "C:\Users\samaritan\Documents\VPM\VPM\Views\Admin\AccountSettings.cshtml"
   var user = (VPM.Models.mUser)ViewBag.user;

#line default
#line hidden
            BeginContext(72, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(88, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "36a32f29703d45e389bc3cdcf5697ab0", async() => {
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
            BeginContext(144, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(158, 73, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83a1ca8da4f340b6a37a299a3d7b48aa", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(231, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(233, 83, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "12a86ec71cb44c478ae453ae687d3068", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(316, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(332, 82, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "432023113a7c4c3d849a566d6ec8926c", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(414, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
#line 14 "C:\Users\samaritan\Documents\VPM\VPM\Views\Admin\AccountSettings.cshtml"
 if (ViewBag.msg != null && ViewBag.msg != "")
{

#line default
#line hidden
            BeginContext(471, 90, true);
            WriteLiteral("    <script>\r\n        $.alert({\r\n            title: \"Information\",\r\n            content: \"");
            EndContext();
            BeginContext(562, 11, false);
#line 19 "C:\Users\samaritan\Documents\VPM\VPM\Views\Admin\AccountSettings.cshtml"
                 Write(ViewBag.msg);

#line default
#line hidden
            EndContext();
            BeginContext(573, 22, true);
            WriteLiteral("\",\r\n            type:\"");
            EndContext();
            BeginContext(596, 12, false);
#line 20 "C:\Users\samaritan\Documents\VPM\VPM\Views\Admin\AccountSettings.cshtml"
             Write(ViewBag.type);

#line default
#line hidden
            EndContext();
            BeginContext(608, 31, true);
            WriteLiteral("\"\r\n        });\r\n    </script>\r\n");
            EndContext();
#line 23 "C:\Users\samaritan\Documents\VPM\VPM\Views\Admin\AccountSettings.cshtml"

}

#line default
#line hidden
            BeginContext(644, 292, true);
            WriteLiteral(@"
<form id=""faccount"" action=""/Admin/AccountSettings"" method=""POST"" style=""color:red;"">
    <div class=""row"">
        <div class=""col-md-12"">
            <div class=""card bshadow"">
                <div class=""card-header _active"" style=""background:#000;color:#fff;"">Account Settings</div>");
            EndContext();
            BeginContext(953, 349, true);
            WriteLiteral(@"
                <div class=""card-body"">

                    <div class=""row"">
                        <div class=""col-md-6"">
                            <div class=""form-group"">
                                <label class=""black"">Email</label>
                               <input type=""email"" name=""email"" id=""email"" class=""form-control""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1302, "\"", 1321, 1);
#line 37 "C:\Users\samaritan\Documents\VPM\VPM\Views\Admin\AccountSettings.cshtml"
WriteAttributeValue("", 1310, user.email, 1310, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1322, 354, true);
            WriteLiteral(@" required/>
                            </div>
                        </div>

                        <div class=""col-md-6"">
                            <div class=""form-group"">
                                <label  class=""black"">Mobile</label>
                                <input type=""number"" name=""mobile"" id=""mobile"" class=""form-control""");
            EndContext();
            BeginWriteAttribute("value", "  value=\"", 1676, "\"", 1697, 1);
#line 44 "C:\Users\samaritan\Documents\VPM\VPM\Views\Admin\AccountSettings.cshtml"
WriteAttributeValue("", 1685, user.mobile, 1685, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1698, 446, true);
            WriteLiteral(@" required />
                            </div>
                        </div>

                    </div>

                    <hr />

                    <div class=""row"">
                        <div class=""col-md-6"">
                            <div class=""form-group"">
                                <label  class=""black"">Name</label>
                                <input type=""text"" name=""name"" id=""name"" class=""form-control""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2144, "\"", 2162, 1);
#line 56 "C:\Users\samaritan\Documents\VPM\VPM\Views\Admin\AccountSettings.cshtml"
WriteAttributeValue("", 2152, user.name, 2152, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2163, 357, true);
            WriteLiteral(@" required/>
                            </div>
                        </div>


                        <div class=""col-md-6"">
                            <div class=""form-group"">
                                <label  class=""black"">Surname</label>
                                <input type=""text"" name=""surname"" id=""surname"" class=""form-control""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2520, "\"", 2541, 1);
#line 64 "C:\Users\samaritan\Documents\VPM\VPM\Views\Admin\AccountSettings.cshtml"
WriteAttributeValue("", 2528, user.surname, 2528, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2542, 479, true);
            WriteLiteral(@" required/>
                            </div>
                        </div>
                    </div>


                    <div class=""row"">
                        <div class=""col-md-6"">
                            <div class=""form-group"">
                               <a href=""/Admin/ChangePassword""><small>Change Password>></small></a>
                            </div>
                        </div>
                    </div>



                </div>");
            EndContext();
            BeginContext(3038, 163, true);
            WriteLiteral("\r\n                <div class=\"card-footer\">\r\n                    <button type=\"submit\" class=\"btn btn-outline-danger _active\">SAVE</button>\r\n                </div>");
            EndContext();
            BeginContext(3217, 20, true);
            WriteLiteral("\r\n            </div>");
            EndContext();
            BeginContext(3246, 16, true);
            WriteLiteral("\r\n        </div>");
            EndContext();
            BeginContext(3275, 12, true);
            WriteLiteral("\r\n    </div>");
            EndContext();
            BeginContext(3294, 64, true);
            WriteLiteral("\r\n</form>\r\n\r\n<script>\r\n    $(\"#faccount\").validate();\r\n</script>");
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
