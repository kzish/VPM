#pragma checksum "C:\Users\samaritan\Documents\VPM\VPM\Views\Client\Account.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9121501db0693a5fcef252ea37a4f93d99e8098e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Client_Account), @"mvc.1.0.view", @"/Views/Client/Account.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Client/Account.cshtml", typeof(AspNetCore.Views_Client_Account))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9121501db0693a5fcef252ea37a4f93d99e8098e", @"/Views/Client/Account.cshtml")]
    public class Views_Client_Account : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/libs/validate/jquery_validator/jquery.validate.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/libs/validate/jquery_validator/additional-methods.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\samaritan\Documents\VPM\VPM\Views\Client\Account.cshtml"
   Layout = "_Layout";

#line default
#line hidden
#line 2 "C:\Users\samaritan\Documents\VPM\VPM\Views\Client\Account.cshtml"
   var user = (VPM.Models.mClient)ViewBag.user;

#line default
#line hidden
            BeginContext(91, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(93, 82, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ca0eddd80f84f85a3e836cb926d99a4", async() => {
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
            BeginContext(175, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(177, 85, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e5a9c577f7b34b9a9f71919373341a52", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(262, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(281, 596, true);
            WriteLiteral(@"
<form class=""login-form"" method=""post"" action=""/Client/ClientUpdateDetails"" id=""flog0"">
    
    <div class=""row"">
        <div class=""col-md-12"">
            <div class=""card bshadow"">
                <div class=""card-header _active"">Basic Details</div>
                <div class=""card-body"">
                    <div class=""row"">
                        <div class=""col-md-4"">
                            <div class=""form-group"">
                                <label class=""black"">Name<span style=""color:red;""> *</span></label>
                                <input type=""text""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 877, "\"", 895, 1);
#line 19 "C:\Users\samaritan\Documents\VPM\VPM\Views\Client\Account.cshtml"
WriteAttributeValue("", 885, user.name, 885, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(896, 408, true);
            WriteLiteral(@" placeholder=""name"" name=""name"" id=""name"" required class=""black form-control"" />
                            </div>
                        </div>

                        <div class=""col-md-4"">
                            <div class=""form-group"">
                                <label class=""black"">Surname<span style=""color:red;""> *</span></label>
                                <input type=""text""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1304, "\"", 1325, 1);
#line 26 "C:\Users\samaritan\Documents\VPM\VPM\Views\Client\Account.cshtml"
WriteAttributeValue("", 1312, user.surname, 1312, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1326, 418, true);
            WriteLiteral(@" placeholder=""surname"" name=""surname"" id=""surname"" required class=""black form-control"" />
                            </div>
                        </div>

                        <div class=""col-md-4"">
                            <div class=""form-group"">
                                <label class=""black"">mobile<span style=""color:red;""> *</span></label>
                                <input type=""number""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1744, "\"", 1764, 1);
#line 33 "C:\Users\samaritan\Documents\VPM\VPM\Views\Client\Account.cshtml"
WriteAttributeValue("", 1752, user.mobile, 1752, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1765, 791, true);
            WriteLiteral(@" placeholder=""mobile"" name=""mobile"" id=""mobile"" required class=""black form-control"" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <br />
    <br />

    <div class=""row"">
        <div class=""col-md-12"">
            <div class=""card bshadow"">
                <div class=""card-header _active"">Email & Next of Kin</div>
                <div class=""card-body"">
                    <div class=""row"">
                        <div class=""col-md-12"">
                            <div class=""form-group"">
                                <label class=""black"">Email<span style=""color:red;""> </span></label>
                                <input type=""email""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2556, "\"", 2575, 1);
#line 54 "C:\Users\samaritan\Documents\VPM\VPM\Views\Client\Account.cshtml"
WriteAttributeValue("", 2564, user.email, 2564, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2576, 471, true);
            WriteLiteral(@" placeholder=""email"" name=""email"" id=""emial"" class=""black form-control"" />
                            </div>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-md-6"">
                            <div class=""form-group"">
                                <label class=""black"">Next of Kin<span style=""color:red;""> *</span></label>
                                <input type=""text""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3047, "\"", 3070, 1);
#line 62 "C:\Users\samaritan\Documents\VPM\VPM\Views\Client\Account.cshtml"
WriteAttributeValue("", 3055, user.nextOfKin, 3055, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3071, 440, true);
            WriteLiteral(@" placeholder=""next of kin"" name=""nextOfKin"" id=""nextOfKin"" required class=""black form-control"" />
                            </div>
                        </div>


                        <div class=""col-md-6"">
                            <div class=""form-group"">
                                <label class=""black"">Next of Kin Mobile<span style=""color:red;""> *</span></label>
                                <input type=""number""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3511, "\"", 3540, 1);
#line 70 "C:\Users\samaritan\Documents\VPM\VPM\Views\Client\Account.cshtml"
WriteAttributeValue("", 3519, user.nextOfKinMobile, 3519, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3541, 827, true);
            WriteLiteral(@" placeholder=""next of kin mobile"" name=""nextOfKinMobile"" id=""nextOfKin"" required class=""black form-control"" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <br />
    <br />
    
    <div class=""row"">
        <div class=""col-md-12"">
            <div class=""card bshadow"">
                <div class=""card-header _active"">Occupation & Address</div>
                <div class=""card-body"">

                    <div class=""row"">
                        <div class=""col-md-12"">
                            <div class=""form-group"">
                                <label class=""black"">Occupation<span style=""color:red;""> *</span></label>
                                <input type=""text""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 4368, "\"", 4392, 1);
#line 92 "C:\Users\samaritan\Documents\VPM\VPM\Views\Client\Account.cshtml"
WriteAttributeValue("", 4376, user.occupation, 4376, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4393, 589, true);
            WriteLiteral(@" placeholder=""occupation"" name=""occupation"" id=""occupation"" required class=""black form-control"" />
                            </div>
                        </div>
                    </div>

                    <div class=""row"">
                        <div class=""col-md-12"">
                            <div class=""form-group"">
                                <label class=""black"">Your Address<span style=""color:red;""> *</span></label>
                                <textarea type=""text"" placeholder=""address"" name=""address"" id=""address"" required class=""black form-control"">");
            EndContext();
            BeginContext(4983, 12, false);
#line 101 "C:\Users\samaritan\Documents\VPM\VPM\Views\Client\Account.cshtml"
                                                                                                                                       Write(user.address);

#line default
#line hidden
            EndContext();
            BeginContext(4995, 885, true);
            WriteLiteral(@"</textarea>
                            </div>
                        </div>
                    </div>


                    <div class=""row"">
                        <div class=""col-md-12"">
                            <a href=""/Client/ChangePassword"">Change password >></a>
                        </div>
                    </div>


                </div>
                <div class=""card-footer"">
                    <button type=""submit"" class=""btn btn-outline-success btn-block"">SAVE</button>
                </div>
            </div>
        </div>
    </div>

</form>

<br />
<br />
<br />
<br />
<br />





<script>

    $(""#flog0"").validate({

    });


    $(""#flog0"").on(""submit"", function (e) {
        var valid = $(""#flog0"").valid();
        if (valid) {
            $.busyLoadFull(""show"");
        }
    });

</script>
");
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
