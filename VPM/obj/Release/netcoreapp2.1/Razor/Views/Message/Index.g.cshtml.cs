#pragma checksum "C:\Users\samaritan\Documents\VPM\VPM\Views\Message\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef5fe16a763447cd79fc04e0ab12784c30cbb092"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Message_Index), @"mvc.1.0.view", @"/Views/Message/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Message/Index.cshtml", typeof(AspNetCore.Views_Message_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef5fe16a763447cd79fc04e0ab12784c30cbb092", @"/Views/Message/Index.cshtml")]
    public class Views_Message_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/account/assets/css/chat.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\samaritan\Documents\VPM\VPM\Views\Message\Index.cshtml"
   Layout = "../Account/_Layout";

#line default
#line hidden
#line 2 "C:\Users\samaritan\Documents\VPM\VPM\Views\Message\Index.cshtml"
  var user = (VPM.Models.mUser)ViewBag.user;

#line default
#line hidden
#line 3 "C:\Users\samaritan\Documents\VPM\VPM\Views\Message\Index.cshtml"
  var msgs = (List<VPM.Models.mMessages>)ViewBag.msgs;

#line default
#line hidden
#line 4 "C:\Users\samaritan\Documents\VPM\VPM\Views\Message\Index.cshtml"
  var chats = (List<VPM.Models.chat>)ViewBag.chats;

#line default
#line hidden
            BeginContext(194, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(220, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "23a413ffab464211a184e14da282e01b", async() => {
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
            BeginContext(282, 333, true);
            WriteLiteral(@"

<div class=""container"">
    <div class=""messaging."">
        <div class=""inbox_msg"" id=""inbox_msg"" style=""max-width:700px!important;margin:auto!important;padding:40px!important;height:450px!important;overflow-y:auto!important;"">
            <div class=""mesgs."" "">
                <div class=""msg_history."" id=""msg_history"">
");
            EndContext();
#line 14 "C:\Users\samaritan\Documents\VPM\VPM\Views\Message\Index.cshtml"
                     foreach (var c in chats)
                    {
                        if (c.to == user.email)
                        {

#line default
#line hidden
            BeginContext(761, 236, true);
            WriteLiteral("                            <div class=\"incoming_msg\">\r\n                                <div class=\"received_msg\">\r\n                                    <div class=\"received_withd_msg\">\r\n                                        <i><small>");
            EndContext();
            BeginContext(998, 20, false);
#line 21 "C:\Users\samaritan\Documents\VPM\VPM\Views\Message\Index.cshtml"
                                             Write(globals.supportEmail);

#line default
#line hidden
            EndContext();
            BeginContext(1018, 109, true);
            WriteLiteral("</small></i><br />\r\n                                        <p>\r\n                                            ");
            EndContext();
            BeginContext(1128, 9, false);
#line 23 "C:\Users\samaritan\Documents\VPM\VPM\Views\Message\Index.cshtml"
                                       Write(c.message);

#line default
#line hidden
            EndContext();
            BeginContext(1137, 113, true);
            WriteLiteral("\r\n                                        </p>\r\n                                        <span class=\"time_date\"> ");
            EndContext();
            BeginContext(1251, 27, false);
#line 25 "C:\Users\samaritan\Documents\VPM\VPM\Views\Message\Index.cshtml"
                                                            Write(c.date.ToString("HH:mm tt"));

#line default
#line hidden
            EndContext();
            BeginContext(1278, 9, true);
            WriteLiteral("    |    ");
            EndContext();
            BeginContext(1288, 25, false);
#line 25 "C:\Users\samaritan\Documents\VPM\VPM\Views\Message\Index.cshtml"
                                                                                                 Write(c.date.ToString("MMMM d"));

#line default
#line hidden
            EndContext();
            BeginContext(1313, 129, true);
            WriteLiteral("</span>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
            EndContext();
#line 29 "C:\Users\samaritan\Documents\VPM\VPM\Views\Message\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(1526, 193, true);
            WriteLiteral("                            <div class=\"outgoing_msg\">\r\n                                <div class=\"sent_msg\">\r\n                                    <p>\r\n                                        ");
            EndContext();
            BeginContext(1720, 9, false);
#line 35 "C:\Users\samaritan\Documents\VPM\VPM\Views\Message\Index.cshtml"
                                   Write(c.message);

#line default
#line hidden
            EndContext();
            BeginContext(1729, 105, true);
            WriteLiteral("\r\n                                    </p>\r\n                                    <span class=\"time_date\"> ");
            EndContext();
            BeginContext(1835, 27, false);
#line 37 "C:\Users\samaritan\Documents\VPM\VPM\Views\Message\Index.cshtml"
                                                        Write(c.date.ToString("HH:mm tt"));

#line default
#line hidden
            EndContext();
            BeginContext(1862, 9, true);
            WriteLiteral("    |    ");
            EndContext();
            BeginContext(1872, 25, false);
#line 37 "C:\Users\samaritan\Documents\VPM\VPM\Views\Message\Index.cshtml"
                                                                                             Write(c.date.ToString("MMMM d"));

#line default
#line hidden
            EndContext();
            BeginContext(1897, 85, true);
            WriteLiteral("</span>\r\n                                </div>\r\n                            </div>\r\n");
            EndContext();
#line 40 "C:\Users\samaritan\Documents\VPM\VPM\Views\Message\Index.cshtml"
                        }

                    }

#line default
#line hidden
            BeginContext(2034, 22, true);
            WriteLiteral("                </div>");
            EndContext();
            BeginContext(2065, 279, true);
            WriteLiteral(@"
            </div>

        </div>
        <div style=""padding:20px!important;max-width:700px!important;margin:auto;"">
            <div class=""type_msg"">
                <form method=""post"" id=""fmsg"" action=""/Message/postMessage"">
                    <input type=""hidden""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2344, "\"", 2371, 1);
#line 50 "C:\Users\samaritan\Documents\VPM\VPM\Views\Message\Index.cshtml"
WriteAttributeValue("", 2352, ViewBag.user.email, 2352, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2372, 57, true);
            WriteLiteral(" name=\"from\" />\r\n                    <input type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2429, "\"", 2460, 1);
#line 51 "C:\Users\samaritan\Documents\VPM\VPM\Views\Message\Index.cshtml"
WriteAttributeValue("", 2437, globals.supportEmail, 2437, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2461, 55, true);
            WriteLiteral(" name=\"to\" />\r\n                    <input type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2516, "\"", 2538, 1);
#line 52 "C:\Users\samaritan\Documents\VPM\VPM\Views\Message\Index.cshtml"
WriteAttributeValue("", 2524, ViewBag.msgId, 2524, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2539, 595, true);
            WriteLiteral(@" name=""msgId"" />
                    <div class=""input_msg_write"">
                        <input type=""text"" class=""write_msg"" placeholder=""Type a message"" name=""message"" id=""message"" required />
                        <button class=""msg_send_btn"" type=""submit""><i class=""fa fa-paper-plane-o"" aria-hidden=""true""></i></button>
                    </div>
                </form>
            </div>
        </div>
    </div>
</div>



<script>
    var objDiv = document.getElementById(""inbox_msg"");
    objDiv.scrollTop = objDiv.scrollHeight;
    $(""#message"").focus();
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
