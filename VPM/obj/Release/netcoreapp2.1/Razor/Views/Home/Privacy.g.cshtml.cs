#pragma checksum "C:\samaritan\documents\Visual Studio 2017\Projects\VPM\VPM\Views\Home\Privacy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2685f2050aebc7680fbcfebe28db9f3d0889f9ac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Privacy), @"mvc.1.0.view", @"/Views/Home/Privacy.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Privacy.cshtml", typeof(AspNetCore.Views_Home_Privacy))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2685f2050aebc7680fbcfebe28db9f3d0889f9ac", @"/Views/Home/Privacy.cshtml")]
    public class Views_Home_Privacy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/libs/print.js/print.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/libs/print.js/print.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\samaritan\documents\Visual Studio 2017\Projects\VPM\VPM\Views\Home\Privacy.cshtml"
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(24, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a83e439cea8c476a9aef30e068772f69", async() => {
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
            BeginContext(93, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(95, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5335550a83564c3a91f5c55780f6a81b", async() => {
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
            BeginContext(154, 20048, true);
            WriteLiteral(@"
<div style=""background:white;min-height:100vh!important;min-width:100%!important;"">
    <br />
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-2"">
                <button onclick=""printJS('content', 'html')"" class=""btn btn-primary btn-sm"">Print PDF</button>
            </div>
        </div>
    </div>
    <br />
    <div class=""container"" id=""content"">
        <div class=""row"">
            <div class=""col-md-12"" style=""text-align:justify;"">
                <h2>Privacy Policy</h2>
                Last Updated: 12/23/2018
                <br />

                At KVPM, we appreciate your use of and contributions to our websites, our mobile and desktop applications, our other properties and/or our related services (collectively known as the ""Services,"" or, each individually, a ""Service""). KVPM respects your privacy and is committed to protecting your personal information. We encourage you to read this privacy policy to understand the information we collect");
            WriteLiteral(@" and how we use and disclose it. This policy applies to all of our Services that link to it
                <h4>1. Information Collected by KVPM.</h4>

                When you use the Services, we collect a variety of information from and about you, your devices, and your interaction with the Services. Some of this information identifies you directly or can be used to identify you when combined with other data.

                <ul>
                    <li>
                        <b>Information you provide.</b>
                        When using the Services, you may be asked to provide personal information about yourself, such as your name, contact information, payment information, details about your home or properties you are interested in, financial information. This may occur, for example, when you register on the Services, claim a home, share or save a property, correspond with a real estate professional (such as a real estate agent or broker, mortgage lender or loan officer, property manager, ");
            WriteLiteral(@"investor, homebuilder, or others) via the Services, or complete other forms or transactions, such as a request for loan information or a rental housing and background check application. You may also provide information about a third party through the Services, for example, if you share a real estate listing with a recipient via email. We may combine this information with other information we collect from your interaction with the Services or from other companies. Some information you provide through the Services is collected and processed by third parties on our behalf. For example, when you order products or services through the Services, we may need to collect your credit or debit card information. This information is collected and processed by third-party payment processors. If you are a real estate professional, you may be able to connect your third-party email account (such as Gmail) to your KVPM account. If you enable that connection, KVPM will access your messages, contacts, and settings to provide the");
            WriteLiteral(@" requested Services to you.
                    </li>
                    <li>
                        <b>Cookies, web beacons, and other tracking technologies.</b>
                        We and our partners use various technologies to collect information automatically when you access and use the Services, including cookies, web beacons and other similar technologies. Cookies are bits of electronic information that can be transferred to your computer or other electronic device to uniquely identify your browser. When you use the Services, we and our partners may place one or more cookies on your computer or other electronic device or use other technologies that provide similar functionality. We and our partners may use cookies to connect your activity on the Services with other information we store about you in your account profile or your prior interactions on the Services to, for example, store your preferences. The use of cookies helps us improve the quality of the Services to you, by identifying infor");
            WriteLiteral(@"mation which is most interesting to you, tracking trends, measuring the effectiveness of advertising, or storing information you may want to retrieve on a regular basis, such as your favorite homes. At any time, you may adjust settings on your browser to refuse cookies according to the instructions related to your browser. However, if you choose to disable cookies, many of the free features of the Services will not operate properly. The pages on the Services may also include web beacons or pixels, which are electronic files to count users who have visited that page, to track activity over time and across different websites, to determine users’ interactions with emails we send, to identify certain cookies on the computer or other electronic device accessing that page, or to collect other related information, and this information may be associated with your unique browser, device identifier, or Internet Protocol address. We may, for example, implement a pixel on the pages of the Services where you view a certai");
            WriteLiteral(@"n advertisement so that we can track whether you visit a website associated with that advertisement at a later time.
                    </li>
                    <li>
                        <b>Third-party cookies, web beacons, and other tracking technologies.</b>
                        We work with service providers and advertising networks to track and manage cookie information and your activities while you're using the Services and your online activities over time and across different websites and devices. For example, third parties may use cookies to deliver advertisements to you based on your visit to the Services. For additional information, please refer to the section below entitled, ""Interest-Based Advertising."" You may opt-out of cookie tracking and analysis from any of these service providers and advertising networks by Opting out of Collection of Information by Third Parties, which is explained further below.
                    </li>
                    <li>
                        <b>Mob");
            WriteLiteral(@"ile device and mobile browser information.</b>
                        You may adjust settings on your mobile device and mobile browser regarding cookies and sharing of certain information, such as your mobile device model or the language your mobile device uses, by adjusting the privacy and security settings on your mobile device. Please refer to the instructions provided by your mobile service provider or mobile device manufacturer.
                    </li>
                    <li>
                        <b>Location Data.</b>
                        If you enable location services on your mobile device, KVPM may collect the location of your device, which we use to provide you with location-based information and advertising. If you wish to deactivate this feature, you can disable location services on your mobile device

                    </li>
                    <li>
                        <b>Usage logs.</b>
                        We collect information about your use of our Services, includ");
            WriteLiteral(@"ing the type of browser you use, access times, pages viewed, your IP address and the page you visited before navigating to our Services. We also collect information about the computer or mobile device you use to access our Services, such as the hardware model, operating system and version, unique device identifiers, mobile network information, and browsing behavior.
                    </li>
                    <li>
                        <b>Calls and text messages.</b>
                        Calls between you and KVPM, or between you and third parties made through KVPM (such as real estate agents you contact about a property through a form or link on our website, or using contact information found on our website), may be recorded or monitored for quality assurance and customer service purposes. You will be notified at the beginning of a call if it may be recorded or monitored. KVPM uses a third-party service provider to track phone calls and text messages between you and real estate professionals so th");
            WriteLiteral(@"at we and the real estate professional can access certain details about the contact. As part of this process, KVPM and its service provider will receive in real time and store data about your call or text message, including the date and time of the call or text message, your phone number, and the content of the text message.
                    </li>
                    <li>
                        <b>Public content.</b>
                        You may provide information publicly through the Services, such as when you leave a review for a real estate professional, or when you contribute to discussion forums.
                    </li>
                    <li>
                        <b>Social networks.</b>
                        If you use the social networking connection functions offered through the Services, we may access all of your social network profile information that you have made available to be shared and to use it in accordance with this privacy policy. Please refer to the instructions go");
            WriteLiteral(@"verning your social network account to manage the information that is shared through your account.
                    </li>
                </ul>
                <h4>
                    2. How KVPM Uses Your Information
                </h4>

                KVPM generally uses the information collected about you to provide and improve the Services, including
                <ul>
                    <li>
                        provide and deliver the Services, process transactions and send related information such as confirmations and invoices;
                    </li>
                    <li>
                        send you technical notices, updates, security alerts and support and administrative messages;
                    </li>
                    <li>
                        respond to your comments, questions and requests and provide customer service;
                    </li>
                    <li>
                        communicate with you about products, services, offers");
            WriteLiteral(@", promotions, rewards and events offered by KVPM and others, and provide news and information we think will be of interest to you;
                    </li>
                    <li>
                        monitor and analyze trends, usage and activities in connection with our Services;
                    </li>
                    revise, modify, and update existing Services and develop new Services;
                    <li>
                        detect, investigate and prevent fraudulent transactions and other illegal activities and protect the rights and property of KVPM and others;
                    </li>
                    personalize the Services and present you with advertising, content or features that we believe will be of interest or useful to you;
                    <li>
                        facilitate contests, sweepstakes and promotions and process and deliver entries and rewards;
                    </li>
                    link or combine with information we get from othe");
            WriteLiteral(@"rs to help understand your needs and provide you with better service; and
                    <li>
                        carry out any other purpose described to you at the time the information was collected.
                    </li>
                    <li>
                        Email Management. You may receive email from KVPM for a variety of reasons - for example, if you took an action through the Services, you signed up for a regular report, or you posted your home for sale and a buyer sent you a message. If you have an account with KVPM, you can select your preferences through your account settings. Also, you can manage your receipt of some types of communication by following the instructions included in the email we send you. Please note that, even if you unsubscribe from certain email correspondences, we may still need to email you with important transactional or administrative information.
                    </li>
                </ul>
                <h4>
                    3. When K");
            WriteLiteral(@"VPM Shares and Discloses Your Information
                </h4>
                Your privacy is important and we are committed to protecting your information that identifies you personally. We will only share personal information that you provide outside the public areas of the Services in the following circumstances:
                <ul>
                    <li>
                        <b>With your consent.</b> When you consent or direct KVPM to share the personal information. This happens when you submit your information through many of our Services. For example, if you choose to contact a real estate agent, mortgage lender, investor, builder, property manager, or other real estate professional through the Services, your name, phone number, email address, and message content will appear to the recipient of the message. Similarly, if you apply for rental housing through the Services, your application information will be sent to prospective landlords.
                    </li>
                    <li>");
            WriteLiteral(@"
                        <b> Service providers to KVPM.</b> When KVPM hires a service provider to help operate the Services or our business, KVPM may give access to personal information only as appropriate to perform the service for KVPM, and subject to the terms of this privacy policy. KVPM always remains responsible for the privacy of your personal information that is shared with service providers.
                    </li>
                    <li>

                        <b>Partners with whom we conduct business.</b> When KVPM partners with other businesses to offer products and services, we may share information with those business partners only as needed to provide those products and services and only subject to the terms of this privacy policy.
                    </li>
                    <li>
                        <b>Legal obligation or protection from harm.</b> When KVPM has a good faith belief that access, use, preservation or disclosure of information is reasonably necessary to (a) satisf");
            WriteLiteral(@"y any requirement of law, regulation, legal process, or enforceable governmental request, (b) enforce or investigate a potential violation of the Terms of Use, (c) detect, prevent, or otherwise respond to fraud, security or technical concerns, (d) support auditing and compliance functions, or (e) protect the rights, property, or safety of KVPM, its users, or the public against harm.
                    </li>
                    <li>
                        <b>Business transfers.</b> If and when KVPM is involved in a merger, acquisition, or any form of transfer or sale of some or all of its business, whether as a going concern or as part of bankruptcy, liquidation, or similar proceeding, we may share your personal information in connection with that transaction.
                    </li>
                </ul>
                KVPM may also share aggregated or de-identified information that cannot reasonably be used to identify you.

                <h4>
                    4. Interest-Based Advertising");
            WriteLiteral(@"
                </h4>

                We participate in interest-based advertising. This means that when you use the Services, we or third party service providers or advertisers may use cookies (that they collect or that we provide to them) or other similar technologies to collect information about your use of the Services (including mobile applications) or your online activities over time and across different websites and devices. Collected information may include the content you view, the date and time that you view this content, and the website that referred you to the Services, and this information may be associated with your unique browser, device identifier, or Internet Protocol (IP) address. These practices help tailor advertisements that are relevant and useful to you. These tailored advertisements may appear on the Services or on other websites, applications or properties.

                <br />
                In addition, if you have provided your email address to us, we may use a scramble");
            WriteLiteral(@"d, unreadable form (a hash) of your email address to deliver tailored advertisements to you on the Services or on other websites, including via Facebook’s Custom Audience Feature or other similar tools. Click here to learn about how you can control the ads you see on Facebook.

                <br />You may opt-out of cookie tracking and analysis as described in the section below entitled 'Opting Out of Collection of Information by Third Parties'. The Services do not otherwise respond to ‘do not track’ signals.

                <h4>
                    5. Opting Out of Collection of Information by Third Parties
                </h4>

                KVPM's third-party ad servers, ad network providers, third-party advertisers may provide you with advertisements that you may see on the Services or on other affiliated websites. To improve the relevancy and help measure the effectiveness of such advertisements, the KVPM Ad Providers may use cookies, web beacons, clear gifs or similar technologies. These a");
            WriteLiteral(@"re used to record users' activity, such as the pages visited, and to learn what types of information are of most interest to the users. For more information regarding the choices you have about these technologies (such as opting-out), visit the Network Advertising Initiative, Digital Advertising Alliance, Omniture, and PrivacyChoice.

                <h4>
                    6. Third-Party Links and Websites
                </h4>

                Throughout the Services, we may link to the websites of other companies and/or individuals. Further, certain functionalities on the Services may involve the distribution of your listing information to third-party websites. These third-party websites may collect information about users on those websites, and KVPM's privacy policy does not extend to these external websites and third parties. Please refer directly to these third parties and websites regarding their privacy policies.

                <h4>
                    7. Security and Retention of Informat");
            WriteLiteral(@"ion
                </h4>

                KVPM takes reasonable steps to protect the information users share with us from unauthorized use, access, and disclosure, both during transmission and at rest. However, no transmission of information via the Internet nor electronic storage solution can be entirely secure, so please be aware that we cannot guarantee absolute security.

                <br />You can access, update, and delete personal information you provide to KVPM in your account profile by logging into your account on the relevant KVPM Service. We may maintain a copy of the original version of your information in our records.

                <br />We will retain your information for as long as necessary to fulfill the purposes outlined in this Privacy Policy unless a longer retention period is required or permitted by law.

               
                <h4>
                    8. Government and Private Party Information Requests
                </h4>

                KVPM occasiona");
            WriteLiteral(@"lly receives various forms of legal process from government agencies and private parties requesting information about KVPM users. Before we produce information, we will attempt to notify affected users and give them an opportunity to object unless notification is prohibited by law or if we believe that notification would create a risk of harm or be otherwise counterproductive.

                <h4>
                    9. Contacting KVPM
                </h4>

                If you have any questions about this privacy policy, or the privacy practices of KVPM, please email us at ");
            EndContext();
            BeginContext(20204, 20, false);
#line 170 "C:\samaritan\documents\Visual Studio 2017\Projects\VPM\VPM\Views\Home\Privacy.cshtml"
                                                                                                                      Write(globals.privacyEmail);

#line default
#line hidden
            EndContext();
            BeginContext(20225, 554, true);
            WriteLiteral(@"

                <h4>10. Changes to this Privacy Policy</h4>

                Please note that this policy may be amended from time to time. You should check back for the most current version before relying on any of the provisions in this privacy policy. We will provide notice of material changes to the policy, either by posting a notice on our websites, by sending an email, or some other reasonable method.
                <br />
                <br />
            </div>
        </div>
        <br />
        <br />
    </div>
</div>
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
