#pragma checksum "C:\samaritan\documents\Visual Studio 2017\Projects\VPM\VPM\Views\Home\IndexRent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d2a1a61fc8acc267dc3f0b2ec8a1d45ef4e1656"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_IndexRent), @"mvc.1.0.view", @"/Views/Home/IndexRent.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/IndexRent.cshtml", typeof(AspNetCore.Views_Home_IndexRent))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d2a1a61fc8acc267dc3f0b2ec8a1d45ef4e1656", @"/Views/Home/IndexRent.cshtml")]
    public class Views_Home_IndexRent : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\samaritan\documents\Visual Studio 2017\Projects\VPM\VPM\Views\Home\IndexRent.cshtml"
  Layout = "_Layout";

#line default
#line hidden
#line 2 "C:\samaritan\documents\Visual Studio 2017\Projects\VPM\VPM\Views\Home\IndexRent.cshtml"
   var props = (List<VPM.Models.mProperty>)ViewBag.props;

#line default
#line hidden
            BeginContext(84, 2738, true);
            WriteLiteral(@"
    <div class=""row"" style=""height: 50%;margin:auto!important;"">
        <div class=""col-md-12"">
            <form action=""/Properties/SearchProperties?t=rent"" method=""get"" id=""fid"">
                <div class=""bg center-block"">
                    <h4 style=""text-align:center;color:#fff;font-weight:400;font-size:28px!important;background:rgba(0,0,0,0.2);padding:10px!important;"">Find a home to rent</h4>
                    <div class=""btn-group"">
                        <button onclick=""nav('/Home/IndexBuy')"" type=""button"" class=""btn btn-primary btn_center"">Buy</button>
                        <button onclick=""nav('/Home/IndexRent')"" type=""button"" class=""btn btn-primary btn_center"">Rent</button>
                        <button onclick=""nav('/Home/IndexFix')"" type=""button"" class=""btn btn-primary btn_center"">Fix</button>
                        <button onclick=""nav('/Home/IndexSell')"" type=""button"" class=""btn btn-primary btn_center"">Sell</button>
                    </div>
                    <br /");
            WriteLiteral(@">
                    <div class=""input-group mb-3"" style=""margin-top:10px!important;"">
                        <input type=""hidden"" name=""type1"" value=""1"" />
                        <input type=""hidden"" name=""type2"" value=""1"" />
                        <input type=""hidden"" name=""type3"" value=""1"" />
                        <input type=""hidden"" name=""type4"" value=""1"" />
                        <input type=""hidden"" name=""type5"" value=""1"" />
                        <input type=""hidden"" name=""t"" value=""rent"" />
                        <input type=""hidden"" name=""p"" value=""r"" />
                        <input style="""" type=""text"" class=""form-control sbox"" placeholder=""Enter an address, neighborhood, city or ZIP"" name=""location"" id=""param"">
                        <div class=""input-group-append"">
                            <button class=""btn btn-success btn_center"" type=""submit"">Search</button>
                        </div>
                    </div>
                </div>
            </form>
     ");
            WriteLiteral(@"   </div>
    </div>
<br />
<script>
    $(""#bg"").backstretch(""/assets/img/h_4.jpg"");
    $(""#param"").autocomplete({
        serviceUrl: '/Properties/SearchProperties_Ajax?t=rent',
        onSelect: function (suggestion) {
           // alert('You selected: ' + suggestion.value + ', ' + suggestion.data);
            window.location = suggestion.data;
        }
    });


    $(""#fid"").on(""submit"", function (e) {
        var param = $(""#param"").val();
        if (param != """") {
            $.busyLoadFull(""show"");
            $(""#fid"").submit();
        }
        else {
            //e.preventDefault();//dont submit if this is null
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
