#pragma checksum "C:\Users\samaritan\Documents\Visual Studio 2017\Projects\VPM\VPM\Views\Home\IndexFix.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "78e4580b2835e363d5bade0305dcd5608b864343"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_IndexFix), @"mvc.1.0.view", @"/Views/Home/IndexFix.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/IndexFix.cshtml", typeof(AspNetCore.Views_Home_IndexFix))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78e4580b2835e363d5bade0305dcd5608b864343", @"/Views/Home/IndexFix.cshtml")]
    public class Views_Home_IndexFix : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\samaritan\Documents\Visual Studio 2017\Projects\VPM\VPM\Views\Home\IndexFix.cshtml"
  Layout = "_Layout";

#line default
#line hidden
#line 2 "C:\Users\samaritan\Documents\Visual Studio 2017\Projects\VPM\VPM\Views\Home\IndexFix.cshtml"
   var props = (List<VPM.Models.mProperty>)ViewBag.props;

#line default
#line hidden
            BeginContext(84, 2112, true);
            WriteLiteral(@"
<div class=""row"" style=""height: 50%;margin:auto!important;"">
    <div class=""col-md-12"">
        <form action="""" method=""get"" id=""fid"">
            <div class=""bg center-block"">
                <h4 style=""text-align:center;color:#fff;font-weight:400;font-size:28px!important;background:rgba(0,0,0,0.2);padding:10px!important;"">Need something fixed?</h4>
                <div class=""btn-group"">
                    <button onclick=""nav('/Home/IndexBuy')"" type=""button"" class=""btn btn-primary btn_center"">Buy</button>
                    <button onclick=""nav('/Home/IndexRent')"" type=""button"" class=""btn btn-primary btn_center"">Rent</button>
                    <button onclick=""nav('/Home/indexFix')"" type=""button"" class=""btn btn-primary btn_center"">Fix</button>
                    <button onclick=""nav('/Home/indexSell')"" type=""button"" class=""btn btn-primary btn_center"">Sell</button>
                </div>

                <br />
                <div class=""input-group mb-3"" style=""margin-top:10px!importa");
            WriteLiteral(@"nt;"">
                    <input style="""" type=""text"" class=""form-control sbox"" placeholder=""eg. window fitting"" name=""param"" id=""param"">
                    <div class=""input-group-append"">
                        <button class=""btn btn-success btn_center"" type=""submit"">Search</button>
                    </div>
                </div>
            </div>
        </form>
    </div>
</div>
<br />
<script>
    $(""#bg"").backstretch(""/assets/img/h_6.jpg"");
    $(""#param"").autocomplete({
        serviceUrl: '/Properties/SearchArtisans_Ajax',
        onSelect: function (suggestion) {
            // alert('You selected: ' + suggestion.value + ', ' + suggestion.data);
            navtoClientSupport();//  window.location = suggestion.data;
        }
    });

    function navtoClientSupport()
    {
        $.busyLoadFull(""show"");
        var param = $(""#param"").val();
        window.location = ""/SpecialRoute/ClientSearchItemToBeFixed?mtype='"" + param + ""'"";
    }

    $(""#fid"").on(""submit"", f");
            WriteLiteral("unction (e) {\r\n        e.preventDefault();\r\n    });\r\n</script>\r\n");
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
