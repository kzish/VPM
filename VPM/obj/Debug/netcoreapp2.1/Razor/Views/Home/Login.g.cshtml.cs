#pragma checksum "C:\Users\samaritan\Documents\VPM\VPM\Views\Home\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6683381bd99647ed2defa076a0f95baf6d588169"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Login), @"mvc.1.0.view", @"/Views/Home/Login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Login.cshtml", typeof(AspNetCore.Views_Home_Login))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6683381bd99647ed2defa076a0f95baf6d588169", @"/Views/Home/Login.cshtml")]
    public class Views_Home_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/jquery.backstretch.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/libs/validate/jquery_validator/jquery.validate.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/libs/validate/jquery_validator/additional-methods.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/viewmodels/login/login.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\samaritan\Documents\VPM\VPM\Views\Home\Login.cshtml"
   Layout = "_Layout";

#line default
#line hidden
            BeginContext(40, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(42, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f7ad7f5e9733461d826b1ee64498541e", async() => {
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
            BeginContext(103, 3573, true);
            WriteLiteral(@"

<style>

   .login-page {
        width: 50%;
        padding: 8% 0 0;
        margin: auto;
        height: auto;

    }

    .form {
        position: relative;
        z-index: 1;
        background: #FFFFFF;
        max-width: 460px;
        margin: 0 auto 100px;
        padding: 45px;
        text-align: center;
        box-shadow: 0 0 20px 0 rgba(0, 0, 0, 0.2), 0 5px 5px 0 rgba(0, 0, 0, 0.24);
    }

        .form input {
            font-family: ""Roboto"", sans-serif;
            outline: 0;
            background: #f2f2f2;
            width: 100%;
            border: 0;
            margin: 0 0 15px;
            padding: 15px;
            box-sizing: border-box;
            font-size: 14px;
        }

        .form button {
            font-family: ""Roboto"", sans-serif;
            text-transform: uppercase;
            outline: 0;
            background: #4CAF50;
            width: 100%;
            border: 0;
            padding: 15px;
            color: #F");
            WriteLiteral(@"FFFFF;
            font-size: 14px;
            -webkit-transition: all 0.3 ease;
            transition: all 0.3 ease;
            cursor: pointer;
        }

            .form button:hover, .form button:active, .form button:focus {
                background: #43A047;
            }

        .form .message {
            margin: 15px 0 0;
            color: #b3b3b3;
            font-size: 12px;
        }

            .form .message a {
                color: #4CAF50;
                text-decoration: none;
            }

        .form .register-form {
            display: none;
        }

    ._container {
        position: relative;
        z-index: 1;
        max-width: 300px;
        margin: 0 auto;
    }

        ._container:before, ._container:after {
            content: """";
            display: block;
            clear: both;
        }

        ._container .info {
            margin: 50px auto;
            text-align: center;
        }

            ._container");
            WriteLiteral(@" .info h1 {
                margin: 0 0 15px;
                padding: 0;
                font-size: 36px;
                font-weight: 300;
                color: #1a1a1a;
            }

            ._container .info span {
                color: #4d4d4d;
                font-size: 12px;
            }

                ._container .info span a {
                    color: #000000;
                    text-decoration: none;
                }

                ._container .info span .fa {
                    color: #EF3B3A;
                }

    body {
        background: #fff; /* fallback for old browsers */
        background: -webkit-linear-gradient(right, #fff, #8DC26F);
        background: -moz-linear-gradient(right, #fff, #8DC26F);
        background: -o-linear-gradient(right, #76b852, #8DC26F);
        background: linear-gradient(to left, #76b852, #8DC26F);
        font-family: ""Roboto"", sans-serif;
        -webkit-font-smoothing: antialiased;
        -moz-osx-font-smoothing");
            WriteLiteral(@": grayscale;
        
        background-image: url(""/assets/img/lagos.jpg"");
        background-size:cover;
        height:100vh!important;
        width:100%!important;
    }

    label {
        color: red !important;
    }
    .hold {
        background-image: url('~assets/img/lagos3.jpg') !important;
        background-position: center !important;
        background-size: cover !important;
        height:100vh!important;
        width:100%!important;    
    
</style>


");
            EndContext();
            BeginContext(3694, 82, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d9ccd14660b542f4aa91a8c68d731dce", async() => {
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
            BeginContext(3776, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(3778, 85, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "098a8db1f95348ba96c2e063e0dacd2f", async() => {
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
            BeginContext(3863, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(3882, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fa0dca72c2364955a4577d70345cd861", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3933, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
#line 148 "C:\Users\samaritan\Documents\VPM\VPM\Views\Home\Login.cshtml"
 if (ViewBag.msg != null)
{

#line default
#line hidden
            BeginContext(3969, 90, true);
            WriteLiteral("    <script>\r\n        $.alert({\r\n            title: \"Information\",\r\n            content: \"");
            EndContext();
            BeginContext(4060, 11, false);
#line 153 "C:\Users\samaritan\Documents\VPM\VPM\Views\Home\Login.cshtml"
                 Write(ViewBag.msg);

#line default
#line hidden
            EndContext();
            BeginContext(4071, 22, true);
            WriteLiteral("\",\r\n            type:\"");
            EndContext();
            BeginContext(4094, 12, false);
#line 154 "C:\Users\samaritan\Documents\VPM\VPM\Views\Home\Login.cshtml"
             Write(ViewBag.type);

#line default
#line hidden
            EndContext();
            BeginContext(4106, 33, true);
            WriteLiteral("\"\r\n\r\n        });\r\n    </script>\r\n");
            EndContext();
#line 158 "C:\Users\samaritan\Documents\VPM\VPM\Views\Home\Login.cshtml"
}

#line default
#line hidden
            BeginContext(4142, 2022, true);
            WriteLiteral(@"
<div class=""hold"">
    <div class=""login-page"">
        <div class=""row"" style=""height:100px!important;"">
            <div class=""col-md-6"" style=""border-right: 0px solid #000000;"">

                <div class=""form"">
                    <form class=""login-form"" method=""post"" action=""/home/login"" id=""flog0"">
                        <h4>LandLord Login</h4>
                        <input type=""email"" placeholder=""email"" name=""email"" id=""email0"" required class=""black"" value=""zishumbak@gmail.com"" />
                        <input type=""password"" placeholder=""password"" name=""password"" id=""password0"" required class=""black"" value=""12345"" />
                        <button type=""submit"">login</button>
                        <p class=""message""><a href=""/home/forgotpassword1"">Forgot Password</a></p>
                        <p class=""message tlink"">Not registered? <a href=""/home/RegisterProperty"">Create an account</a></p>
                    </form>
                </div>


            </div>



");
            WriteLiteral(@"
            <div class=""col-md-6"">

                <div class=""form"">
                    <form class=""login-form"" method=""post"" action=""/home/Artisanlogin"" id=""flog1"">
                        <h4>Artisan Login</h4>
                        <input type=""email"" placeholder=""email"" name=""email"" id=""email1"" required class=""black"" value=""zishumbak@gmail.com"" />
                        <input type=""password"" placeholder=""password"" name=""password"" id=""password1"" required class=""black"" value=""12345"" />
                        <button type=""submit"">login</button>
                        <p class=""message""><a href=""/home/forgotpassword2"">Forgot Password</a></p>
                        <p class=""message tlink"">Not registered? <a href=""/home/RegisterSkills"">Create an account</a></p>
                    </form>
                </div>


            </div>



        </div>

    </div>
</div>
<br />
<script>
        //$.backstretch(""~/assets/img/lagos3.jpg"");
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
