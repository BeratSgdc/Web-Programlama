#pragma checksum "C:\Users\berat\OneDrive\Masaüstü\HastaneProjesi\HastaneProjesi\Views\HastaKabuls\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ffef6d2acec1b2b9a257d0714c8400460ece7a9f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HastaKabuls_Details), @"mvc.1.0.view", @"/Views/HastaKabuls/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ffef6d2acec1b2b9a257d0714c8400460ece7a9f", @"/Views/HastaKabuls/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ccd39e9748ada42ce1dd526c47c135a607730162", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_HastaKabuls_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HastaneProjesi.Models.HastaKabul>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\berat\OneDrive\Masaüstü\HastaneProjesi\HastaneProjesi\Views\HastaKabuls\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/Sablon.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<br />\n<div>\n    <h4>HastaKabul</h4>\n    <hr />\n    <dl class=\"row\">\n        <dt class=\"col-sm-2\">\n            Geliş Tarihi\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 17 "C:\Users\berat\OneDrive\Masaüstü\HastaneProjesi\HastaneProjesi\Views\HastaKabuls\Details.cshtml"
       Write(Html.DisplayFor(model => model.GelisTarihi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            Hasta Adı ve soyadı\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 23 "C:\Users\berat\OneDrive\Masaüstü\HastaneProjesi\HastaneProjesi\Views\HastaKabuls\Details.cshtml"
       Write(Html.DisplayFor(model => model.Hastalar.Ad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            ");
#nullable restore
#line 24 "C:\Users\berat\OneDrive\Masaüstü\HastaneProjesi\HastaneProjesi\Views\HastaKabuls\Details.cshtml"
       Write(Html.DisplayFor(model=>model.Hastalar.Soyad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n       \n        <dt class=\"col-sm-2\">\n            Doktor Adı ve soyad\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 31 "C:\Users\berat\OneDrive\Masaüstü\HastaneProjesi\HastaneProjesi\Views\HastaKabuls\Details.cshtml"
       Write(Html.DisplayFor(model => model.Doktorlar.Ad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            ");
#nullable restore
#line 32 "C:\Users\berat\OneDrive\Masaüstü\HastaneProjesi\HastaneProjesi\Views\HastaKabuls\Details.cshtml"
       Write(Html.DisplayFor(model => model.Doktorlar.Soyad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n        </dd>\n    </dl>\n</div>\n<div>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ffef6d2acec1b2b9a257d0714c8400460ece7a9f6073", async() => {
                WriteLiteral("Listeye Geri Dön");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HastaneProjesi.Models.HastaKabul> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
