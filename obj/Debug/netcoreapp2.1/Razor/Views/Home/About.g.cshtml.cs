#pragma checksum "Z:\Repo\Github\verywon\BaseT-Identity-Server\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d61b533e817629203142834d7e11ed2dc4539fa4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/About.cshtml", typeof(AspNetCore.Views_Home_About))]
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
#line 1 "Z:\Repo\Github\verywon\BaseT-Identity-Server\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "Z:\Repo\Github\verywon\BaseT-Identity-Server\Views\_ViewImports.cshtml"
using IdentityServerWithAspNetIdentity;

#line default
#line hidden
#line 3 "Z:\Repo\Github\verywon\BaseT-Identity-Server\Views\_ViewImports.cshtml"
using IdentityServerWithAspNetIdentity.Models;

#line default
#line hidden
#line 4 "Z:\Repo\Github\verywon\BaseT-Identity-Server\Views\_ViewImports.cshtml"
using IdentityServerWithAspNetIdentity.Models.AccountViewModels;

#line default
#line hidden
#line 5 "Z:\Repo\Github\verywon\BaseT-Identity-Server\Views\_ViewImports.cshtml"
using IdentityServerWithAspNetIdentity.Models.ManageViewModels;

#line default
#line hidden
#line 7 "Z:\Repo\Github\verywon\BaseT-Identity-Server\Views\_ViewImports.cshtml"
using IdentityServer4.Quickstart.UI;

#line default
#line hidden
#line 1 "Z:\Repo\Github\verywon\BaseT-Identity-Server\Views\Home\About.cshtml"
using Microsoft.AspNetCore.Authentication;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d61b533e817629203142834d7e11ed2dc4539fa4", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e4682ade7b0fb6e6a361ec10cd3ef52676e4744", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "Z:\Repo\Github\verywon\BaseT-Identity-Server\Views\Home\About.cshtml"
  
    ViewData["Title"] = "About";

#line default
#line hidden
            BeginContext(86, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(91, 17, false);
#line 5 "Z:\Repo\Github\verywon\BaseT-Identity-Server\Views\Home\About.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(108, 11, true);
            WriteLiteral("</h2>\r\n<h3>");
            EndContext();
            BeginContext(120, 19, false);
#line 6 "Z:\Repo\Github\verywon\BaseT-Identity-Server\Views\Home\About.cshtml"
Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(139, 39, true);
            WriteLiteral("</h3>\r\n\r\n<h3>User claims</h3>\r\n\r\n<dl>\r\n");
            EndContext();
#line 11 "Z:\Repo\Github\verywon\BaseT-Identity-Server\Views\Home\About.cshtml"
     foreach (var claim in User.Claims)
    {

#line default
#line hidden
            BeginContext(226, 12, true);
            WriteLiteral("        <dt>");
            EndContext();
            BeginContext(239, 10, false);
#line 13 "Z:\Repo\Github\verywon\BaseT-Identity-Server\Views\Home\About.cshtml"
       Write(claim.Type);

#line default
#line hidden
            EndContext();
            BeginContext(249, 19, true);
            WriteLiteral("</dt>\r\n        <dd>");
            EndContext();
            BeginContext(269, 11, false);
#line 14 "Z:\Repo\Github\verywon\BaseT-Identity-Server\Views\Home\About.cshtml"
       Write(claim.Value);

#line default
#line hidden
            EndContext();
            BeginContext(280, 7, true);
            WriteLiteral("</dd>\r\n");
            EndContext();
#line 15 "Z:\Repo\Github\verywon\BaseT-Identity-Server\Views\Home\About.cshtml"

    }

#line default
#line hidden
            BeginContext(296, 31, true);
            WriteLiteral("    <dt>id token</dt>\r\n    <dd>");
            EndContext();
            BeginContext(328, 55, false);
#line 18 "Z:\Repo\Github\verywon\BaseT-Identity-Server\Views\Home\About.cshtml"
   Write(await ViewContext.HttpContext.GetTokenAsync("id_token"));

#line default
#line hidden
            EndContext();
            BeginContext(383, 14, true);
            WriteLiteral("</dd>\r\n</dl>\r\n");
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
