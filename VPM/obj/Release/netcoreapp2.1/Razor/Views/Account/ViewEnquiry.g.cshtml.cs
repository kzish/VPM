#pragma checksum "C:\samaritan\documents\Visual Studio 2017\Projects\VPM\VPM\Views\Account\ViewEnquiry.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c4696d24da01880416e7e588504520162045f59f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_ViewEnquiry), @"mvc.1.0.view", @"/Views/Account/ViewEnquiry.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/ViewEnquiry.cshtml", typeof(AspNetCore.Views_Account_ViewEnquiry))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4696d24da01880416e7e588504520162045f59f", @"/Views/Account/ViewEnquiry.cshtml")]
    public class Views_Account_ViewEnquiry : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\samaritan\documents\Visual Studio 2017\Projects\VPM\VPM\Views\Account\ViewEnquiry.cshtml"
   Layout = "_Layout";

#line default
#line hidden
#line 2 "C:\samaritan\documents\Visual Studio 2017\Projects\VPM\VPM\Views\Account\ViewEnquiry.cshtml"
  var en = (VPM.Models.mEnquiry)ViewBag.enq;

#line default
#line hidden
            BeginContext(72, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 5 "C:\samaritan\documents\Visual Studio 2017\Projects\VPM\VPM\Views\Account\ViewEnquiry.cshtml"
 if(ViewBag.msg!=null)
{

#line default
#line hidden
            BeginContext(103, 109, true);
            WriteLiteral("    <script>\r\n        $.alert({\r\n            title: \"Info\",\r\n            type: \"blue\",\r\n            content:\"");
            EndContext();
            BeginContext(213, 11, false);
#line 11 "C:\samaritan\documents\Visual Studio 2017\Projects\VPM\VPM\Views\Account\ViewEnquiry.cshtml"
                Write(ViewBag.msg);

#line default
#line hidden
            EndContext();
            BeginContext(224, 31, true);
            WriteLiteral("\"\r\n        });\r\n    </script>\r\n");
            EndContext();
#line 14 "C:\samaritan\documents\Visual Studio 2017\Projects\VPM\VPM\Views\Account\ViewEnquiry.cshtml"

}

#line default
#line hidden
            BeginContext(260, 250, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        <h3>View Enquiry</h3>\r\n        <br />\r\n    </div>\r\n</div>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        <table class=\"table table-striped\">\r\n            <tr>\r\n                <td>");
            EndContext();
            BeginContext(511, 7, false);
#line 28 "C:\samaritan\documents\Visual Studio 2017\Projects\VPM\VPM\Views\Account\ViewEnquiry.cshtml"
               Write(en.name);

#line default
#line hidden
            EndContext();
            BeginContext(518, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(546, 30, false);
#line 29 "C:\samaritan\documents\Visual Studio 2017\Projects\VPM\VPM\Views\Account\ViewEnquiry.cshtml"
               Write(en.date.ToString("d MMM yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(576, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(604, 8, false);
#line 30 "C:\samaritan\documents\Visual Studio 2017\Projects\VPM\VPM\Views\Account\ViewEnquiry.cshtml"
               Write(en.email);

#line default
#line hidden
            EndContext();
            BeginContext(612, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(640, 9, false);
#line 31 "C:\samaritan\documents\Visual Studio 2017\Projects\VPM\VPM\Views\Account\ViewEnquiry.cshtml"
               Write(en.mobile);

#line default
#line hidden
            EndContext();
            BeginContext(649, 76, true);
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td colspan=\"4\">");
            EndContext();
            BeginContext(726, 10, false);
#line 34 "C:\samaritan\documents\Visual Studio 2017\Projects\VPM\VPM\Views\Account\ViewEnquiry.cshtml"
                           Write(en.enquiry);

#line default
#line hidden
            EndContext();
            BeginContext(736, 92, true);
            WriteLiteral("</td>\r\n            </tr>\r\n\r\n\r\n            <tr>\r\n                <td colspan=\"4\">property :<a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 828, "\"", 878, 2);
            WriteAttributeValue("", 835, "/Account/CreateProperty?pid=", 835, 28, true);
#line 39 "C:\samaritan\documents\Visual Studio 2017\Projects\VPM\VPM\Views\Account\ViewEnquiry.cshtml"
WriteAttributeValue("", 863, en.property_id, 863, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(879, 350, true);
            WriteLiteral(@">click to open</a></td>
            </tr>

            <tr>
                <td>
                    <form method=""post"" action=""/Account/setEnquiryStatus"" class=""form-inline"">
                        status:
                        <select class=""form-control"" name=""enqStatus"">
                            <option value=""Under Admin Review""");
            EndContext();
            BeginWriteAttribute("selected", " selected=\"", 1229, "\"", 1279, 1);
#line 47 "C:\samaritan\documents\Visual Studio 2017\Projects\VPM\VPM\Views\Account\ViewEnquiry.cshtml"
WriteAttributeValue("", 1240, en.getStatus()=="Under Admin Review", 1240, 39, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1280, 82, true);
            WriteLiteral(">Under Admin Review</option>\r\n                            <option value=\"accepted\"");
            EndContext();
            BeginWriteAttribute("selected", " selected=\"", 1362, "\"", 1402, 1);
#line 48 "C:\samaritan\documents\Visual Studio 2017\Projects\VPM\VPM\Views\Account\ViewEnquiry.cshtml"
WriteAttributeValue("", 1373, en.getStatus()=="accepted", 1373, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1403, 72, true);
            WriteLiteral(">Accepted</option>\r\n                            <option value=\"rejected\"");
            EndContext();
            BeginWriteAttribute("selected", " selected=\"", 1475, "\"", 1515, 1);
#line 49 "C:\samaritan\documents\Visual Studio 2017\Projects\VPM\VPM\Views\Account\ViewEnquiry.cshtml"
WriteAttributeValue("", 1486, en.getStatus()=="rejected", 1486, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1516, 119, true);
            WriteLiteral(">Rejected</option>\r\n                        </select>\r\n                        <input type=\"hidden\" name=\"eid\" id=\"eid\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1635, "\"", 1650, 1);
#line 51 "C:\samaritan\documents\Visual Studio 2017\Projects\VPM\VPM\Views\Account\ViewEnquiry.cshtml"
WriteAttributeValue("", 1643, en._id, 1643, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1651, 210, true);
            WriteLiteral(" />&nbsp;\r\n                        <button class=\"btn btn-primary\" type=\"submit\">Save Status</button>\r\n                    </form>\r\n                </td>\r\n            </tr>\r\n        </table>\r\n    </div>\r\n</div>");
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
