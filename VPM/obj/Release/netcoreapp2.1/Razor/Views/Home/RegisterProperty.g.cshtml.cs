#pragma checksum "C:\samaritan\documents\Visual Studio 2017\Projects\VPM\VPM\Views\Home\RegisterProperty.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77a2cd2a6aaeca3546dafa26acec8d54a3cc55e1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_RegisterProperty), @"mvc.1.0.view", @"/Views/Home/RegisterProperty.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/RegisterProperty.cshtml", typeof(AspNetCore.Views_Home_RegisterProperty))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77a2cd2a6aaeca3546dafa26acec8d54a3cc55e1", @"/Views/Home/RegisterProperty.cshtml")]
    public class Views_Home_RegisterProperty : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\samaritan\documents\Visual Studio 2017\Projects\VPM\VPM\Views\Home\RegisterProperty.cshtml"
   Layout = "_Layout";

#line default
#line hidden
#line 2 "C:\samaritan\documents\Visual Studio 2017\Projects\VPM\VPM\Views\Home\RegisterProperty.cshtml"
   var user = (VPM.Models.mUser)ViewBag.user;

#line default
#line hidden
            BeginContext(73, 555, true);
            WriteLiteral(@"

<br />
<div id=""bg"" style=""min-width:100%!important;min-height:100vh!important;"">
    <div class=""container"" style=""max-width:500px!important;margin:auto;"">
        <div class=""card mb-3"">
            <h3 class=""card-header"">Property Owner Sign up</h3>
            <div class=""card-body"">
                <div class=""row"">
                    <div class=""col-md-12"">
                        <form class=""login-form"" action=""/home/RegisterProperty"" method=""post"" id=""freg"" style=""color:red;"">
                            <b style=""color:red;"">");
            EndContext();
            BeginContext(629, 11, false);
#line 14 "C:\samaritan\documents\Visual Studio 2017\Projects\VPM\VPM\Views\Home\RegisterProperty.cshtml"
                                             Write(ViewBag.msg);

#line default
#line hidden
            EndContext();
            BeginContext(640, 258, true);
            WriteLiteral(@"</b>
                            <div class=""form-group"">
                                <label class=""black"">Mobile <span style=""color:red"">*</span></label>
                                <input type=""number"" name=""mobile"" class=""form-control"" required");
            EndContext();
            BeginWriteAttribute("value", "  value=\"", 898, "\"", 919, 1);
#line 17 "C:\samaritan\documents\Visual Studio 2017\Projects\VPM\VPM\Views\Home\RegisterProperty.cshtml"
WriteAttributeValue("", 907, user.mobile, 907, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(920, 2450, true);
            WriteLiteral(@"/>
                            </div>

                            <div class=""form-group"">
                                <label class=""black"">Email <span style=""color:red""></span></label>
                                <input type=""email"" name=""email"" class=""form-control""/>
                            </div>
                            <div class=""form-group"">
                                <label class=""black"">Password <span style=""color:red"">*</span></label>
                                <input type=""password"" name=""password"" id=""password"" class=""form-control"" required />
                            </div>

                            <div class=""form-group"">
                                <label class=""black"">Confirm Password <span style=""color:red"">*</span></label>
                                <input type=""password"" name=""password_again"" id=""password_again"" class=""form-control"" required />
                            </div>

                            <div class=""row"">
      ");
            WriteLiteral(@"                          <div class=""col-md-12"">
                                    <input type=""checkbox"" id=""chk_terms"" onclick=""enable_disable_registration(this)"" /><b style=""color:#000;""> I agree to the <a href=""/ArtisanPolicy"">Terms and Conditions</a></b>
                                </div>
                            </div>
                            <br />

                            <button type=""submit"" class=""btn btn-primary btn-sm btn-block"" style=""height:30px!important;"" id=""btnsignup"">Sign up</button>
                            <br /><small id=""lbl_info_1"" style=""color:red"">First agree to <a href=""/ArtisanPolicy"">terms and conditions</a></small>
                        </form>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<script>


    //check if agreed
    function enable_disable_registration(cbox)
    {
        if (cbox.checked) {
            $(""#btnsignup"").removeAttr(""disabled"");
            $(""#lbl_info");
            WriteLiteral(@"_1"").hide();
        }
        else {
            $(""#btnsignup"").attr(""disabled"", true);
            $(""#lbl_info_1"").show();
        }
    }



    $(""#freg"").validate({
        rules: {
            password: ""required"",
            password_again: {
                equalTo: ""#password""
            }
        }
    });
    $(""#bg"").backstretch(""/assets/img/blur.jpg"");
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