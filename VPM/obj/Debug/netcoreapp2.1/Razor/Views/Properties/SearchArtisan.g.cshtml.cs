#pragma checksum "C:\Users\samaritan\Documents\VPM\VPM\Views\Properties\SearchArtisan.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "46be6c88e6acb167b2a821433e38e143ddd0448f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Properties_SearchArtisan), @"mvc.1.0.view", @"/Views/Properties/SearchArtisan.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Properties/SearchArtisan.cshtml", typeof(AspNetCore.Views_Properties_SearchArtisan))]
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
#line 2 "C:\Users\samaritan\Documents\VPM\VPM\Views\Properties\SearchArtisan.cshtml"
using PagedList.Core;

#line default
#line hidden
#line 3 "C:\Users\samaritan\Documents\VPM\VPM\Views\Properties\SearchArtisan.cshtml"
using PagedList;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46be6c88e6acb167b2a821433e38e143ddd0448f", @"/Views/Properties/SearchArtisan.cshtml")]
    public class Views_Properties_SearchArtisan : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/css/pagination.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/libs/rating/themes/fontawesome-stars.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/libs/rating/jquery.barrating.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("fid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Properties/SearchArtisan"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/user-profile.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height: 200px; width: 100%; display: block;object-fit:cover;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("pager-container"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SearchArtisan", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Properties", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-keyword", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::PagedList.Core.Mvc.PagerTagHelper __PagedList_Core_Mvc_PagerTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\samaritan\Documents\VPM\VPM\Views\Properties\SearchArtisan.cshtml"
   Layout = "../Home/_Layout";

#line default
#line hidden
            BeginContext(76, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(169, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 8 "C:\Users\samaritan\Documents\VPM\VPM\Views\Properties\SearchArtisan.cshtml"
   var artisans = (IPagedList<VPM.Models.mArtisan>)ViewBag.artisans;

#line default
#line hidden
            BeginContext(258, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5eef5f160e2846e99c992bcd4b5df2bf", async() => {
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
            BeginContext(318, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(338, 82, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0cc483f175444dd6a453fa3db2341207", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(420, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(422, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "86f57b17a244419692660c6279470128", async() => {
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
            BeginContext(490, 115, true);
            WriteLiteral("\r\n\r\n\r\n<br />\r\n<br />\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-md-12\">\r\n            ");
            EndContext();
            BeginContext(605, 549, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87067ad135b84707b8d053c11c494a89", async() => {
                BeginContext(668, 237, true);
                WriteLiteral("\r\n                <div class=\"input-group mb-3\" style=\"margin-top:10px!important;\">\r\n                    <input style=\"\" type=\"text\" class=\"form-control sbox\" placeholder=\"Need something fixed? eg. window fitting\" name=\"param\" id=\"param\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 905, "\"", 927, 1);
#line 24 "C:\Users\samaritan\Documents\VPM\VPM\Views\Properties\SearchArtisan.cshtml"
WriteAttributeValue("", 913, ViewBag.param, 913, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(928, 219, true);
                WriteLiteral(">\r\n                    <div class=\"input-group-append\">\r\n                        <button class=\"btn btn-success btn_center\" type=\"submit\">Search</button>\r\n                    </div>\r\n                </div>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1154, 61, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n\r\n\r\n    <div class=\"row\">\r\n\r\n");
            EndContext();
#line 37 "C:\Users\samaritan\Documents\VPM\VPM\Views\Properties\SearchArtisan.cshtml"
         if(artisans.Count==0)
        {

#line default
#line hidden
            BeginContext(1258, 372, true);
            WriteLiteral(@"            <div style=""width:500px;margin:auto;"">
                <center>
                    We could not find any matches for ypur search<br />
                    Login or <a href=""/Home/Join"">sign up</a> under <b>Client option</b> and specify the work that you want done, you will be notified when a match is found
                </center>
            </div>
");
            EndContext();
#line 45 "C:\Users\samaritan\Documents\VPM\VPM\Views\Properties\SearchArtisan.cshtml"

        }

#line default
#line hidden
            BeginContext(1643, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 49 "C:\Users\samaritan\Documents\VPM\VPM\Views\Properties\SearchArtisan.cshtml"
         foreach (var a in artisans)
        {

#line default
#line hidden
            BeginContext(1696, 54, true);
            WriteLiteral("            <div class=\"col-md-4\">\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1750, "\"", 1802, 2);
            WriteAttributeValue("", 1757, "/Properties/ViewArtisanFullProfile?aid=", 1757, 39, true);
#line 52 "C:\Users\samaritan\Documents\VPM\VPM\Views\Properties\SearchArtisan.cshtml"
WriteAttributeValue("", 1796, a._id, 1796, 6, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1803, 125, true);
            WriteLiteral(" style=\"text-decoration:none;\">\r\n                    <div class=\"card mb-3\">\r\n                        <h3 class=\"card-header\"");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 1928, "\"", 1963, 1);
#line 54 "C:\Users\samaritan\Documents\VPM\VPM\Views\Properties\SearchArtisan.cshtml"
WriteAttributeValue("", 1936, a.name  +" "+  a.surname, 1936, 27, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1964, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1967, 52, false);
#line 54 "C:\Users\samaritan\Documents\VPM\VPM\Views\Properties\SearchArtisan.cshtml"
                                                                                Write(globals.trimString( a.name  +" "+  a.surname , 25 ) );

#line default
#line hidden
            EndContext();
            BeginContext(2020, 470, true);
            WriteLiteral(@"</h3>
                        <div class=""card-body."">
                            <div style=""width:100%;padding:15px!important;background:rgba(0,0,0,0.5);width:100%;position:absolute;bottom:0;left:0;color:#fff;"">
                                <table style=""width:100%;height:100%;"" class="""">
                                    <tr>
                                        <td colspan=""2"">
                                            <select class=""brating"">
");
            EndContext();
#line 61 "C:\Users\samaritan\Documents\VPM\VPM\Views\Properties\SearchArtisan.cshtml"
                                                 for (var i = 0; i < a.getRating(); i++)
                                                {

#line default
#line hidden
            BeginContext(2631, 52, true);
            WriteLiteral("                                                    ");
            EndContext();
            BeginContext(2683, 28, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "877862454eca4285be4b9b4b54d76cce", async() => {
                BeginContext(2701, 1, true);
                WriteLiteral("1");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2711, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 64 "C:\Users\samaritan\Documents\VPM\VPM\Views\Properties\SearchArtisan.cshtml"
                                                }

#line default
#line hidden
            BeginContext(2764, 286, true);
            WriteLiteral(@"                                            </select>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Jobs</td>
                                        <td>");
            EndContext();
            BeginContext(3051, 9, false);
#line 70 "C:\Users\samaritan\Documents\VPM\VPM\Views\Properties\SearchArtisan.cshtml"
                                       Write(a.numJobs);

#line default
#line hidden
            EndContext();
            BeginContext(3060, 198, true);
            WriteLiteral("</td>\r\n                                    </tr>\r\n                                    <tr>\r\n                                        <td>Rate / Hour</td>\r\n                                        <td>");
            EndContext();
            BeginContext(3260, 41, false);
#line 74 "C:\Users\samaritan\Documents\VPM\VPM\Views\Properties\SearchArtisan.cshtml"
                                        Write(globals.getLocalCurrencyNG(a.hourlyRate) );

#line default
#line hidden
            EndContext();
            BeginContext(3302, 147, true);
            WriteLiteral("</td>\r\n                                    </tr>\r\n                                    <tr>\r\n                                        <td colspan=\"2\"");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 3449, "\"", 3477, 3);
#line 77 "C:\Users\samaritan\Documents\VPM\VPM\Views\Properties\SearchArtisan.cshtml"
WriteAttributeValue("", 3457, a.mobile, 3457, 9, false);

#line default
#line hidden
            WriteAttributeValue(" ", 3466, "|", 3467, 2, true);
#line 77 "C:\Users\samaritan\Documents\VPM\VPM\Views\Properties\SearchArtisan.cshtml"
WriteAttributeValue(" ", 3468, a.email, 3469, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3478, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(3480, 8, false);
#line 77 "C:\Users\samaritan\Documents\VPM\VPM\Views\Properties\SearchArtisan.cshtml"
                                                                                Write(a.mobile);

#line default
#line hidden
            EndContext();
            BeginContext(3488, 3, true);
            WriteLiteral(" | ");
            EndContext();
            BeginContext(3492, 7, false);
#line 77 "C:\Users\samaritan\Documents\VPM\VPM\Views\Properties\SearchArtisan.cshtml"
                                                                                            Write(a.email);

#line default
#line hidden
            EndContext();
            BeginContext(3499, 148, true);
            WriteLiteral(" </td>\r\n                                    </tr>\r\n                                    <tr>\r\n                                        <td colspan=\"2\"");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 3647, "\"", 3671, 1);
#line 80 "C:\Users\samaritan\Documents\VPM\VPM\Views\Properties\SearchArtisan.cshtml"
WriteAttributeValue("", 3655, a.streetAddress, 3655, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3672, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(3675, 41, false);
#line 80 "C:\Users\samaritan\Documents\VPM\VPM\Views\Properties\SearchArtisan.cshtml"
                                                                             Write( globals.trimString(a.streetAddress, 25) );

#line default
#line hidden
            EndContext();
            BeginContext(3717, 162, true);
            WriteLiteral("</td>\r\n                                    </tr>\r\n\r\n                                </table>\r\n                            </div>\r\n                        </div>\r\n");
            EndContext();
#line 86 "C:\Users\samaritan\Documents\VPM\VPM\Views\Properties\SearchArtisan.cshtml"
                         if (a.image != "" && a.image != null)
                        {

#line default
#line hidden
            BeginContext(3970, 97, true);
            WriteLiteral("                        <img style=\"height: 200px; width: 100%; display: block;object-fit:cover;\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 4067, "\"", 4081, 1);
#line 88 "C:\Users\samaritan\Documents\VPM\VPM\Views\Properties\SearchArtisan.cshtml"
WriteAttributeValue("", 4073, a.image, 4073, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4082, 3, true);
            WriteLiteral(">\r\n");
            EndContext();
#line 89 "C:\Users\samaritan\Documents\VPM\VPM\Views\Properties\SearchArtisan.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(4169, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(4197, 112, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d515b9b1d4c841eaac41006dc0f9ae86", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4309, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 93 "C:\Users\samaritan\Documents\VPM\VPM\Views\Properties\SearchArtisan.cshtml"
                        }

#line default
#line hidden
            BeginContext(4338, 96, true);
            WriteLiteral("                        \r\n                    </div>\r\n                </a>\r\n            </div>\r\n");
            EndContext();
#line 98 "C:\Users\samaritan\Documents\VPM\VPM\Views\Properties\SearchArtisan.cshtml"
        }

#line default
#line hidden
            BeginContext(4445, 10, true);
            WriteLiteral("    </div>");
            EndContext();
            BeginContext(4462, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 100 "C:\Users\samaritan\Documents\VPM\VPM\Views\Properties\SearchArtisan.cshtml"
      
        var rd = new Dictionary<string, string>();
        rd.Add("param", ViewBag.param);
     

#line default
#line hidden
            BeginContext(4573, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(4579, 291, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("pager", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "deec9446469f457f87ca314709ba182d", async() => {
            }
            );
            __PagedList_Core_Mvc_PagerTagHelper = CreateTagHelper<global::PagedList.Core.Mvc.PagerTagHelper>();
            __tagHelperExecutionContext.Add(__PagedList_Core_Mvc_PagerTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
#line 106 "C:\Users\samaritan\Documents\VPM\VPM\Views\Properties\SearchArtisan.cshtml"
__PagedList_Core_Mvc_PagerTagHelper.List = artisans;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("list", __PagedList_Core_Mvc_PagerTagHelper.List, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 107 "C:\Users\samaritan\Documents\VPM\VPM\Views\Properties\SearchArtisan.cshtml"
__PagedList_Core_Mvc_PagerTagHelper.Options = PagedList.Core.Mvc.PagedListRenderOptions.PageNumbersOnly;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("options", __PagedList_Core_Mvc_PagerTagHelper.Options, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __PagedList_Core_Mvc_PagerTagHelper.AspAction = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            __PagedList_Core_Mvc_PagerTagHelper.AspController = (string)__tagHelperAttribute_12.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
#line 110 "C:\Users\samaritan\Documents\VPM\VPM\Views\Properties\SearchArtisan.cshtml"
__PagedList_Core_Mvc_PagerTagHelper.RouteValues = rd;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-all-route-data", __PagedList_Core_Mvc_PagerTagHelper.RouteValues, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            if (__PagedList_Core_Mvc_PagerTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-keyword", "PagedList.Core.Mvc.PagerTagHelper", "RouteValues"));
            }
            __PagedList_Core_Mvc_PagerTagHelper.RouteValues["keyword"] = (string)__tagHelperAttribute_13.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_13);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4870, 10, true);
            WriteLiteral("\r\n\r\n</div>");
            EndContext();
            BeginContext(4893, 515, true);
            WriteLiteral(@"

<script>
     $(""#param"").autocomplete({
        serviceUrl: '/Properties/SearchArtisans_Ajax',
        onSelect: function (suggestion) {
            // alert('You selected: ' + suggestion.value + ', ' + suggestion.data);
            window.location = suggestion.data;
        }
    });


    $(""#fid"").on(""submit"", function (e) {
            $.busyLoadFull(""show"");
    });



    $('.brating').barrating({
        theme: 'fontawesome-stars',
        readonly:true
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
