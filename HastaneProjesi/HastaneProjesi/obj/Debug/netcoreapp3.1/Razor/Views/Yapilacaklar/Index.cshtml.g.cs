#pragma checksum "C:\Users\berat\OneDrive\Masaüstü\HastaneProjesi\HastaneProjesi\Views\Yapilacaklar\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "10e91526bfed81e71b81232075bcfeb421de8ecc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Yapilacaklar_Index), @"mvc.1.0.view", @"/Views/Yapilacaklar/Index.cshtml")]
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
#line 1 "C:\Users\berat\OneDrive\Masaüstü\HastaneProjesi\HastaneProjesi\Views\_ViewImports.cshtml"
using HastaneProjesi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\berat\OneDrive\Masaüstü\HastaneProjesi\HastaneProjesi\Views\_ViewImports.cshtml"
using HastaneProjesi.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10e91526bfed81e71b81232075bcfeb421de8ecc", @"/Views/Yapilacaklar/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ccd39e9748ada42ce1dd526c47c135a607730162", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Yapilacaklar_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AppUser>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\berat\OneDrive\Masaüstü\HastaneProjesi\HastaneProjesi\Views\Yapilacaklar\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/Kullanici.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"container-fluid\">\n    <div class=\"row\">\n        <div class=\"col-md-8\">\n            <table class=\"table table-hover table-sm\">\n                <tr>\n                    <th>İsim:</th>\n                    <td>");
#nullable restore
#line 13 "C:\Users\berat\OneDrive\Masaüstü\HastaneProjesi\HastaneProjesi\Views\Yapilacaklar\Index.cshtml"
                   Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                </tr>\n                <tr>\n                    <th>Soyisim:</th>\n                    <td>");
#nullable restore
#line 17 "C:\Users\berat\OneDrive\Masaüstü\HastaneProjesi\HastaneProjesi\Views\Yapilacaklar\Index.cshtml"
                   Write(Model.SurName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                </tr>\n                \n\n\n            </table>\n        </div>\n\n    </div>\n</div>\n\n\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AppUser> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591