#pragma checksum "/Users/assyasellak/IP PROJ/Totally-Reel-Movie-Review/GIT2/Totally-Reel-Movie-Review/TRMR/Pages/Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7556f4867460bea89d3922bf770bcb563631738a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(TRMR.Pages.Pages_Error), @"mvc.1.0.razor-page", @"/Pages/Error.cshtml")]
namespace TRMR.Pages
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
#line 1 "/Users/assyasellak/IP PROJ/Totally-Reel-Movie-Review/GIT2/Totally-Reel-Movie-Review/TRMR/Pages/_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/assyasellak/IP PROJ/Totally-Reel-Movie-Review/GIT2/Totally-Reel-Movie-Review/TRMR/Pages/_ViewImports.cshtml"
using TRMR;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/assyasellak/IP PROJ/Totally-Reel-Movie-Review/GIT2/Totally-Reel-Movie-Review/TRMR/Pages/_ViewImports.cshtml"
using TRMR.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/assyasellak/IP PROJ/Totally-Reel-Movie-Review/GIT2/Totally-Reel-Movie-Review/TRMR/Pages/_ViewImports.cshtml"
using TRMR.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7556f4867460bea89d3922bf770bcb563631738a", @"/Pages/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9d955fd7e8ecdc9278170b6dcb71143be6eee19", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Error : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/Users/assyasellak/IP PROJ/Totally-Reel-Movie-Review/GIT2/Totally-Reel-Movie-Review/TRMR/Pages/Error.cshtml"
  
    ViewData["Title"] = "Error";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h1 class=\"text-danger\">Error.</h1>\r\n<h2 class=\"text-danger\">An error occurred while processing your request.</h2>\r\n\r\n");
#nullable restore
#line 11 "/Users/assyasellak/IP PROJ/Totally-Reel-Movie-Review/GIT2/Totally-Reel-Movie-Review/TRMR/Pages/Error.cshtml"
 if (Model.ShowRequestId)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\r\n        <strong>Request ID:</strong> <code>");
#nullable restore
#line 14 "/Users/assyasellak/IP PROJ/Totally-Reel-Movie-Review/GIT2/Totally-Reel-Movie-Review/TRMR/Pages/Error.cshtml"
                                      Write(Model.RequestId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</code>\r\n    </p>\r\n");
#nullable restore
#line 16 "/Users/assyasellak/IP PROJ/Totally-Reel-Movie-Review/GIT2/Totally-Reel-Movie-Review/TRMR/Pages/Error.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h3>Development Mode</h3>
<p>
    Swapping to the <strong>Development</strong> environment displays detailed information about the error that occurred.
</p>
<p>
    <strong>The Development environment shouldn't be enabled for deployed applications.</strong>
    It can result in displaying sensitive information from exceptions to end users.
    For local debugging, enable the <strong>Development</strong> environment by setting the <strong>ASPNETCORE_ENVIRONMENT</strong> environment variable to <strong>Development</strong>
    and restarting the app.
</p>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ErrorModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ErrorModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ErrorModel>)PageContext?.ViewData;
        public ErrorModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
