#pragma checksum "C:\Users\samaritan\Documents\VPM\VPM\Views\Admin\ChangePassword.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7804bd54da33d7d5f6004ed8a8211c0df486411b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ChangePassword), @"mvc.1.0.view", @"/Views/Admin/ChangePassword.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/ChangePassword.cshtml", typeof(AspNetCore.Views_Admin_ChangePassword))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7804bd54da33d7d5f6004ed8a8211c0df486411b", @"/Views/Admin/ChangePassword.cshtml")]
    public class Views_Admin_ChangePassword : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "C:\Users\samaritan\Documents\VPM\VPM\Views\Admin\ChangePassword.cshtml"
  Layout = "_Layout";

#line default
#line hidden
#line 2 "C:\Users\samaritan\Documents\VPM\VPM\Views\Admin\ChangePassword.cshtml"
   var user = (VPM.Models.mUser)ViewBag.user;

#line default
#line hidden
            BeginContext(72, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(88, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f3528a2959d54f9686fe1e53278f69f8", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83c66d098ef042768a51867d47b73b83", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f542ce75999a4d4dac232f434e744949", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a1cf77fb071f474ba8c5d0c34177b7b0", async() => {
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
#line 14 "C:\Users\samaritan\Documents\VPM\VPM\Views\Admin\ChangePassword.cshtml"
 if (ViewBag.msg != null && ViewBag.msg != "")
{

#line default
#line hidden
            BeginContext(471, 90, true);
            WriteLiteral("    <script>\r\n        $.alert({\r\n            title: \"Information\",\r\n            content: \"");
            EndContext();
            BeginContext(562, 11, false);
#line 19 "C:\Users\samaritan\Documents\VPM\VPM\Views\Admin\ChangePassword.cshtml"
                 Write(ViewBag.msg);

#line default
#line hidden
            EndContext();
            BeginContext(573, 22, true);
            WriteLiteral("\",\r\n            type:\"");
            EndContext();
            BeginContext(596, 12, false);
#line 20 "C:\Users\samaritan\Documents\VPM\VPM\Views\Admin\ChangePassword.cshtml"
             Write(ViewBag.type);

#line default
#line hidden
            EndContext();
            BeginContext(608, 31, true);
            WriteLiteral("\"\r\n        });\r\n    </script>\r\n");
            EndContext();
#line 23 "C:\Users\samaritan\Documents\VPM\VPM\Views\Admin\ChangePassword.cshtml"

}

#line default
#line hidden
            BeginContext(644, 255, true);
            WriteLiteral("\r\n<form id=\"fpassword\" action=\"/Admin/ChangePassword\" method=\"POST\" style=\"color:red;\">\r\n    <div class=\"row\">\r\n        <div class=\"col-md-12\">\r\n            <div class=\"card bshadow\">\r\n                <div class=\"card-header _active\">Change Password</div>");
            EndContext();
            BeginContext(916, 865, true);
            WriteLiteral(@"
                <div class=""card-body"">

                    <div class=""row"">
                        <div class=""col-md-6"">
                            <div class=""form-group"">
                                <label class=""black"">New Password</label>
                                <input type=""password"" name=""password"" id=""password"" class=""form-control"" required />
                            </div>
                        </div>

                        <div class=""col-md-6"">
                            <div class=""form-group"">
                                <label class=""black"">Confirm</label>
                                <input type=""password"" name=""password2"" id=""password2"" class=""form-control"" required />
                            </div>
                        </div>
                    </div>


                </div>");
            EndContext();
            BeginContext(1798, 163, true);
            WriteLiteral("\r\n                <div class=\"card-footer\">\r\n                    <button type=\"submit\" class=\"btn btn-outline-danger _active\">SAVE</button>\r\n                </div>");
            EndContext();
            BeginContext(1977, 20, true);
            WriteLiteral("\r\n            </div>");
            EndContext();
            BeginContext(2006, 16, true);
            WriteLiteral("\r\n        </div>");
            EndContext();
            BeginContext(2035, 12, true);
            WriteLiteral("\r\n    </div>");
            EndContext();
            BeginContext(2054, 303, true);
            WriteLiteral(@"
</form>

<script>
    $(document).ready(function () { 

        $(""#fpassword"").validate({
            rules: {
                password: ""required"",
                password2: {
                    equalTo: ""#password""
                }
            }
        });
    });
    
</script>");
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
