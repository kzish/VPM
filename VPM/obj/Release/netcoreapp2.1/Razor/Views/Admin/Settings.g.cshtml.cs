#pragma checksum "C:\Users\samaritan\Documents\VPM\VPM\Views\Admin\Settings.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e2b478395da489ec0cf88ae859bf4755579e244b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Settings), @"mvc.1.0.view", @"/Views/Admin/Settings.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/Settings.cshtml", typeof(AspNetCore.Views_Admin_Settings))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2b478395da489ec0cf88ae859bf4755579e244b", @"/Views/Admin/Settings.cshtml")]
    public class Views_Admin_Settings : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/css/switch.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/libs/jquery_alerts/jquery-confirm.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/libs/jquery_alerts/jquery-confirm.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\samaritan\Documents\VPM\VPM\Views\Admin\Settings.cshtml"
  Layout = "_Layout";

#line default
#line hidden
#line 2 "C:\Users\samaritan\Documents\VPM\VPM\Views\Admin\Settings.cshtml"
   var user = (VPM.Models.mUser)ViewBag.user;

#line default
#line hidden
            BeginContext(72, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(88, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "dfb5af100bfc4ce49ee29b05dd0bcdb8", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d222ef0919ba41eca07691ba59b30e9a", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "09bc5738499b4aa4ace7728e7e691f1e", async() => {
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
            BeginContext(316, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
#line 12 "C:\Users\samaritan\Documents\VPM\VPM\Views\Admin\Settings.cshtml"
 if(ViewBag.msg!=null&&ViewBag.msg!="")
{

#line default
#line hidden
            BeginContext(366, 90, true);
            WriteLiteral("    <script>\r\n        $.alert({\r\n            title: \"Information\",\r\n            content: \"");
            EndContext();
            BeginContext(457, 11, false);
#line 17 "C:\Users\samaritan\Documents\VPM\VPM\Views\Admin\Settings.cshtml"
                 Write(ViewBag.msg);

#line default
#line hidden
            EndContext();
            BeginContext(468, 22, true);
            WriteLiteral("\",\r\n            type:\"");
            EndContext();
            BeginContext(491, 12, false);
#line 18 "C:\Users\samaritan\Documents\VPM\VPM\Views\Admin\Settings.cshtml"
             Write(ViewBag.type);

#line default
#line hidden
            EndContext();
            BeginContext(503, 31, true);
            WriteLiteral("\"\r\n        });\r\n    </script>\r\n");
            EndContext();
#line 21 "C:\Users\samaritan\Documents\VPM\VPM\Views\Admin\Settings.cshtml"

}

#line default
#line hidden
            BeginContext(539, 260, true);
            WriteLiteral(@"
<form id=""fsettings"" action=""/Admin/Settings"" method=""POST"">
    <div class=""row"">
        <div class=""col-md-12"">
            <div class=""panel panel-danger"">
                <div class=""panel-heading""  style=""background:#000;color:#fff;"">Settings</div>");
            EndContext();
            BeginContext(816, 459, true);
            WriteLiteral(@"
                <div class=""panel-body"">

                    <div class=""row"">
                        <div class=""col-md-6"">
                            <div class=""form-group"">
                                <label>Email Notifications</label>
                                <br />
                                <label class=""switch"">
                                    <input type=""checkbox"" name=""emialNotifications"" id=""emialNotifications""");
            EndContext();
            BeginWriteAttribute("checked", " checked=\"", 1275, "\"", 1320, 1);
#line 37 "C:\Users\samaritan\Documents\VPM\VPM\Views\Admin\Settings.cshtml"
WriteAttributeValue("", 1285, user.settings.emialNotifications, 1285, 35, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1321, 235, true);
            WriteLiteral(">\r\n                                    <span class=\"slider round\"></span>\r\n                                </label>\r\n                                <br />\r\n                                <small><a href=\"/Admin/Profile\">change email? ");
            EndContext();
            BeginContext(1557, 10, false);
#line 41 "C:\Users\samaritan\Documents\VPM\VPM\Views\Admin\Settings.cshtml"
                                                                         Write(user.email);

#line default
#line hidden
            EndContext();
            BeginContext(1567, 452, true);
            WriteLiteral(@"</a></small>
                            </div>
                        </div>

                        <div class=""col-md-6"">
                            <div class=""form-group"">
                                <label>SMS Notifications</label>
                                <br />
                                <label class=""switch"">
                                    <input type=""checkbox"" name=""smsNotifications"" id=""smsNotifications""");
            EndContext();
            BeginWriteAttribute("checked", " checked=\"", 2019, "\"", 2062, 1);
#line 50 "C:\Users\samaritan\Documents\VPM\VPM\Views\Admin\Settings.cshtml"
WriteAttributeValue("", 2029, user.settings.smsNotifications, 2029, 33, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2063, 236, true);
            WriteLiteral(">\r\n                                    <span class=\"slider round\"></span>\r\n                                </label>\r\n                                <br />\r\n                                <small><a href=\"/Admin/Profile\">change mobile? ");
            EndContext();
            BeginContext(2300, 11, false);
#line 54 "C:\Users\samaritan\Documents\VPM\VPM\Views\Admin\Settings.cshtml"
                                                                          Write(user.mobile);

#line default
#line hidden
            EndContext();
            BeginContext(2311, 536, true);
            WriteLiteral(@"</a></small>
                            </div>
                        </div>

                    </div>

                    <hr />

                    <div class=""row"">
                        <div class=""col-md-6"">
                            <div class=""form-group"">
                                <label>Notify me when I get a new enquiry</label>
                                <label class=""switch"">
                                    <input type=""checkbox"" name=""notifyWhenNewEnquiry"" id=""notifyWhenNewEnquiry""");
            EndContext();
            BeginWriteAttribute("checked", " checked=\"", 2847, "\"", 2894, 1);
#line 67 "C:\Users\samaritan\Documents\VPM\VPM\Views\Admin\Settings.cshtml"
WriteAttributeValue("", 2857, user.settings.notifyWhenNewEnquiry, 2857, 37, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2895, 654, true);
            WriteLiteral(@">
                                    <span class=""slider round""></span>
                                </label>
                            </div>
                        </div>
                    </div>


                    <div class=""row"">
                        <div class=""col-md-6"">
                            <div class=""form-group"">
                                <label>Notify Me when I get an applicant on the waiting list</label>
                                <label class=""switch"">
                                    <input type=""checkbox"" name=""notifyWhenNewWaitingListApplicant"" id=""notifyWhenNewWaitingListApplicant""");
            EndContext();
            BeginWriteAttribute("checked", " checked=\"", 3549, "\"", 3609, 1);
#line 80 "C:\Users\samaritan\Documents\VPM\VPM\Views\Admin\Settings.cshtml"
WriteAttributeValue("", 3559, user.settings.notifyWhenNewWaitingListApplicant, 3559, 50, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3610, 622, true);
            WriteLiteral(@">
                                    <span class=""slider round""></span>
                                </label>
                            </div>
                        </div>
                    </div>


                    <div class=""row"">
                        <div class=""col-md-6"">
                            <div class=""form-group"">
                                <label>Notify Me When I get new messages</label>
                                <label class=""switch"">
                                    <input type=""checkbox"" name=""notifyWhenNewMessageArrives"" id=""notifyWhenNewMessageArrives""");
            EndContext();
            BeginWriteAttribute("checked", " checked=\"", 4232, "\"", 4286, 1);
#line 93 "C:\Users\samaritan\Documents\VPM\VPM\Views\Admin\Settings.cshtml"
WriteAttributeValue("", 4242, user.settings.notifyWhenNewMessageArrives, 4242, 44, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4287, 241, true);
            WriteLiteral(">\r\n                                    <span class=\"slider round\"></span>\r\n                                </label>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n\r\n\r\n\r\n                </div>");
            EndContext();
            BeginContext(4545, 149, true);
            WriteLiteral("\r\n                <div class=\"panel-footer\">\r\n                    <button type=\"submit\" class=\"btn btn-primary\">SAVE</button>\r\n                </div>");
            EndContext();
            BeginContext(4710, 20, true);
            WriteLiteral("\r\n            </div>");
            EndContext();
            BeginContext(4739, 16, true);
            WriteLiteral("\r\n        </div>");
            EndContext();
            BeginContext(4768, 12, true);
            WriteLiteral("\r\n    </div>");
            EndContext();
            BeginContext(4787, 9, true);
            WriteLiteral("\r\n</form>");
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
