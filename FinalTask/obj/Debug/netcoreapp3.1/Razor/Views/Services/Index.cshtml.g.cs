#pragma checksum "C:\Users\user\OneDrive\Masaüstü\FinalTask\FinalTask\Views\Services\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63b88cf249741b8974d77f48732b45eae984ba2c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Services_Index), @"mvc.1.0.view", @"/Views/Services/Index.cshtml")]
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
#line 1 "C:\Users\user\OneDrive\Masaüstü\FinalTask\FinalTask\Views\Services\Index.cshtml"
using FinalTask.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\OneDrive\Masaüstü\FinalTask\FinalTask\Views\Services\Index.cshtml"
using FinalTask.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63b88cf249741b8974d77f48732b45eae984ba2c", @"/Views/Services/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d141eeb755af7c508716a7ef3136a75ee85b695", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Services_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ServicesVM>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\user\OneDrive\Masaüstü\FinalTask\FinalTask\Views\Services\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n  <main id=\"home\">\r\n        <div class=\"container\">\r\n            <div class=\"row\">\r\n                <div class=\"col-lg-3 logo\">\r\n                    <h6 class=\"mt-2\"><a");
            BeginWriteAttribute("href", " href=\"", 284, "\"", 291, 0);
            EndWriteAttribute();
            WriteLiteral(@">Home</a> / Services</h6>
                    <h2>Services</h2>
                </div>
                
            </div>
            

        </div>
        
    </main>
    <main id=""cards"">
        <div class=""container"">
            <div class=""row mt-5"">
");
#nullable restore
#line 25 "C:\Users\user\OneDrive\Masaüstü\FinalTask\FinalTask\Views\Services\Index.cshtml"
                 foreach (Card card in Model.Cards)
               {

#line default
#line hidden
#nullable disable
            WriteLiteral("                   <div class=\"col-lg-4 col-md-6 col-sm-12  text-center maincard\">\r\n                    <div class=\"box\">\r\n                        <div class=\"basket mt-5\">\r\n                            <div class=\"icon\">\r\n                            <i");
            BeginWriteAttribute("class", " class=\"", 888, "\"", 906, 1);
#nullable restore
#line 31 "C:\Users\user\OneDrive\Masaüstü\FinalTask\FinalTask\Views\Services\Index.cshtml"
WriteAttributeValue("", 896, card.Icon, 896, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"title mt-2\">\r\n                            <h4>");
#nullable restore
#line 35 "C:\Users\user\OneDrive\Masaüstü\FinalTask\FinalTask\Views\Services\Index.cshtml"
                           Write(card.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                        </div>\r\n                        <div class=\"text mt-2\">\r\n                        <p>");
#nullable restore
#line 38 "C:\Users\user\OneDrive\Masaüstü\FinalTask\FinalTask\Views\Services\Index.cshtml"
                      Write(card.Info);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n                </div>\n");
#nullable restore
#line 42 "C:\Users\user\OneDrive\Masaüstü\FinalTask\FinalTask\Views\Services\Index.cshtml"
               }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                
            </div>
            
        </div>
        <div class=""container"">
            <div class=""row text-center"">
                <div class=""skills mt-5"">
                    <h2 >Our skills</h2>
                </div>
                <div class=""magnam mt-4"">
                    <p>Magnam dolores commodi suscipit. Necessitatibus eius consequatur ex aliquid fuga eum quidem. Sit sint consectetur velit. Quisquam quos quisquam cupiditate. Et nemo qui impedit suscipit alias ea. Quia fugiat sit in iste officiis commodi quidem hic quas.</p>
                </div>
            </div>  

        </div>
        <div class=""container mt-2"">
            <div class=""row"">
                <div class=""col-lg-6""><img class=""w-100""");
            BeginWriteAttribute("src", " src=\"", 2072, "\"", 2112, 2);
            WriteAttributeValue("", 2078, "./assets/image/", 2078, 15, true);
#nullable restore
#line 60 "C:\Users\user\OneDrive\Masaüstü\FinalTask\FinalTask\Views\Services\Index.cshtml"
WriteAttributeValue("", 2093, Model.Skills.Image, 2093, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2113, "\"", 2119, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                <div class=\"col-lg-6\">\r\n                    <h1>");
#nullable restore
#line 62 "C:\Users\user\OneDrive\Masaüstü\FinalTask\FinalTask\Views\Services\Index.cshtml"
                   Write(Model.Skills.StatisticaTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                    <p>");
#nullable restore
#line 63 "C:\Users\user\OneDrive\Masaüstü\FinalTask\FinalTask\Views\Services\Index.cshtml"
                  Write(Model.Skills.StatisticaInfo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    \r\n");
#nullable restore
#line 65 "C:\Users\user\OneDrive\Masaüstü\FinalTask\FinalTask\Views\Services\Index.cshtml"
                     foreach (Statistica statistica in Model.Statisticas)
                   {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"progress\">\r\n                        <div");
            BeginWriteAttribute("class", " class=\"", 2479, "\"", 2504, 1);
#nullable restore
#line 68 "C:\Users\user\OneDrive\Masaüstü\FinalTask\FinalTask\Views\Services\Index.cshtml"
WriteAttributeValue("", 2487, statistica.Color, 2487, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"progressbar\"");
            BeginWriteAttribute("style", " style=\"", 2524, "\"", 2549, 1);
#nullable restore
#line 68 "C:\Users\user\OneDrive\Masaüstü\FinalTask\FinalTask\Views\Services\Index.cshtml"
WriteAttributeValue("", 2532, statistica.Width, 2532, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("aria-valuenow", " aria-valuenow=\"", 2550, "\"", 2583, 1);
#nullable restore
#line 68 "C:\Users\user\OneDrive\Masaüstü\FinalTask\FinalTask\Views\Services\Index.cshtml"
WriteAttributeValue("", 2566, statistica.Value, 2566, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-valuemin=\"0\" aria-valuemax=\"100\">");
#nullable restore
#line 68 "C:\Users\user\OneDrive\Masaüstü\FinalTask\FinalTask\Views\Services\Index.cshtml"
                                                                                                                                                                       Write(statistica.Volume);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                      </div>\n");
#nullable restore
#line 70 "C:\Users\user\OneDrive\Masaüstü\FinalTask\FinalTask\Views\Services\Index.cshtml"
                   }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n        \r\n    </main>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public FinalTask.Services.LayoutServices layoutservis { get; private set; } = default!;
        #nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ServicesVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
