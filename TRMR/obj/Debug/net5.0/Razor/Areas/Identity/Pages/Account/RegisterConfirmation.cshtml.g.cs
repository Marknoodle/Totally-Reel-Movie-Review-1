#pragma checksum "/Users/assyasellak/IP PROJ/Totally-Reel-Movie-Review/GIT2/Totally-Reel-Movie-Review/TRMR/Areas/Identity/Pages/Account/RegisterConfirmation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c352f73e22b093a43e53f8dc802dd162d0c9870"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account_RegisterConfirmation), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/RegisterConfirmation.cshtml")]
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
#nullable restore
#line 1 "/Users/assyasellak/IP PROJ/Totally-Reel-Movie-Review/GIT2/Totally-Reel-Movie-Review/TRMR/Areas/Identity/Pages/_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/assyasellak/IP PROJ/Totally-Reel-Movie-Review/GIT2/Totally-Reel-Movie-Review/TRMR/Areas/Identity/Pages/_ViewImports.cshtml"
using TRMR.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/assyasellak/IP PROJ/Totally-Reel-Movie-Review/GIT2/Totally-Reel-Movie-Review/TRMR/Areas/Identity/Pages/_ViewImports.cshtml"
using TRMR.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/assyasellak/IP PROJ/Totally-Reel-Movie-Review/GIT2/Totally-Reel-Movie-Review/TRMR/Areas/Identity/Pages/_ViewImports.cshtml"
using TRMR.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/Users/assyasellak/IP PROJ/Totally-Reel-Movie-Review/GIT2/Totally-Reel-Movie-Review/TRMR/Areas/Identity/Pages/Account/_ViewImports.cshtml"
using TRMR.Areas.Identity.Pages.Account;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c352f73e22b093a43e53f8dc802dd162d0c9870", @"/Areas/Identity/Pages/Account/RegisterConfirmation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1e2c2f0058c5bb8425447f8bbcebf14684326a1", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"196464e7d0a246eaafbbe3288e981dd350f096b6", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_RegisterConfirmation : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/Users/assyasellak/IP PROJ/Totally-Reel-Movie-Review/GIT2/Totally-Reel-Movie-Review/TRMR/Areas/Identity/Pages/Account/RegisterConfirmation.cshtml"
  
    ViewData["Title"] = "Register confirmation";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>");
#nullable restore
#line 7 "/Users/assyasellak/IP PROJ/Totally-Reel-Movie-Review/GIT2/Totally-Reel-Movie-Review/TRMR/Areas/Identity/Pages/Account/RegisterConfirmation.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n");
#nullable restore
#line 8 "/Users/assyasellak/IP PROJ/Totally-Reel-Movie-Review/GIT2/Totally-Reel-Movie-Review/TRMR/Areas/Identity/Pages/Account/RegisterConfirmation.cshtml"
  
    if (@Model.DisplayConfirmAccountLink)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<p>
    Welcome to Totally Reel Movie Reviews! Please visit our website&#8217;s about page to become familiar with our rules here at TRMR. Non-compliance with these rules may result in 
    deletion of your TRMR account so make sure to follow them. You can also customize your own profile page with some fun facts about yourself that other TRMR users can see. To 
    update your profile page, click on the &#8217;Login/Register&#8217; tab at the top of the website once you are logged in and select &#8217;Update Information/Profile Page&#8217;.
    <a id=""confirm-link""");
            BeginWriteAttribute("href", " href=\"", 1061, "\"", 1095, 1);
#nullable restore
#line 20 "/Users/assyasellak/IP PROJ/Totally-Reel-Movie-Review/GIT2/Totally-Reel-Movie-Review/TRMR/Areas/Identity/Pages/Account/RegisterConfirmation.cshtml"
WriteAttributeValue("", 1068, Model.EmailConfirmationUrl, 1068, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"color:red;\"> Click here to confirm your TRMR account and begin writing Reel Reviews today!</a> \n</p>\n");
#nullable restore
#line 22 "/Users/assyasellak/IP PROJ/Totally-Reel-Movie-Review/GIT2/Totally-Reel-Movie-Review/TRMR/Areas/Identity/Pages/Account/RegisterConfirmation.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>\n        Please check your email to confirm your account.\n</p>\n");
#nullable restore
#line 28 "/Users/assyasellak/IP PROJ/Totally-Reel-Movie-Review/GIT2/Totally-Reel-Movie-Review/TRMR/Areas/Identity/Pages/Account/RegisterConfirmation.cshtml"
    }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RegisterConfirmationModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RegisterConfirmationModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RegisterConfirmationModel>)PageContext?.ViewData;
        public RegisterConfirmationModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
