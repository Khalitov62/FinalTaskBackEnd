#pragma checksum "C:\Users\user\source\repos\FinalTask\FinalTask\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20ad686c481a719c05d222cc9ba7fcf460fd3658"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20ad686c481a719c05d222cc9ba7fcf460fd3658", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d141eeb755af7c508716a7ef3136a75ee85b695", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/bootstrap/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/sass/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/script.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "20ad686c481a719c05d222cc9ba7fcf460fd36584550", async() => {
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "20ad686c481a719c05d222cc9ba7fcf460fd36584991", async() => {
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
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "20ad686c481a719c05d222cc9ba7fcf460fd36586170", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.1.1/css/all.min.css\">\r\n    <title>");
#nullable restore
#line 12 "C:\Users\user\source\repos\FinalTask\FinalTask\Views\Shared\_Layout.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "20ad686c481a719c05d222cc9ba7fcf460fd36588416", async() => {
                WriteLiteral(@"
    <header>
        <div class=""header-top"">  
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-lg-9 icons"">
                        <ul class=""d-flex list-unstyled mt-3"">
                            <li class=""gmail""><a");
                BeginWriteAttribute("href", " href=\"", 791, "\"", 798, 0);
                EndWriteAttribute();
                WriteLiteral("><i");
                BeginWriteAttribute("class", " class=\"", 802, "\"", 883, 1);
#nullable restore
#line 22 "C:\Users\user\source\repos\FinalTask\FinalTask\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 810, layoutservis.GetDatas().Result.FirstOrDefault(s=>s.Key=="email").IconUrl, 810, 73, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></i>");
#nullable restore
#line 22 "C:\Users\user\source\repos\FinalTask\FinalTask\Views\Shared\_Layout.cshtml"
                                                                                                                                             Write(layoutservis.GetDatas().Result.FirstOrDefault(e=>e.Key=="email").Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n                            </li>\r\n                            <li><a");
                BeginWriteAttribute("href", " href=\"", 1034, "\"", 1041, 0);
                EndWriteAttribute();
                WriteLiteral("><i");
                BeginWriteAttribute("class", " class=\"", 1045, "\"", 1126, 1);
#nullable restore
#line 24 "C:\Users\user\source\repos\FinalTask\FinalTask\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1053, layoutservis.GetDatas().Result.FirstOrDefault(s=>s.Key=="phone").IconUrl, 1053, 73, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></i>");
#nullable restore
#line 24 "C:\Users\user\source\repos\FinalTask\FinalTask\Views\Shared\_Layout.cshtml"
                                                                                                                               Write(layoutservis.GetDatas().Result.FirstOrDefault(p=>p.Key=="phone").Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></li>\r\n\r\n                        </ul>\r\n                    </div>\r\n                    <div class=\"col-lg-3 socialmedia\">\r\n                        <ul class=\"justify-content-end d-flex list-unstyled mt-3\">\r\n                            <li><a");
                BeginWriteAttribute("href", " href=\"", 1448, "\"", 1455, 0);
                EndWriteAttribute();
                WriteLiteral("><i");
                BeginWriteAttribute("class", " class=\"", 1459, "\"", 1542, 1);
#nullable restore
#line 30 "C:\Users\user\source\repos\FinalTask\FinalTask\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1467, layoutservis.GetDatas().Result.FirstOrDefault(s=>s.Key=="twitter").IconUrl, 1467, 75, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></i></a></li>\r\n                            <li><a");
                BeginWriteAttribute("href", " href=\"", 1593, "\"", 1600, 0);
                EndWriteAttribute();
                WriteLiteral("><i");
                BeginWriteAttribute("class", " class=\"", 1604, "\"", 1688, 1);
#nullable restore
#line 31 "C:\Users\user\source\repos\FinalTask\FinalTask\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1612, layoutservis.GetDatas().Result.FirstOrDefault(s=>s.Key=="facebook").IconUrl, 1612, 76, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></i></a></li>\r\n                            <li><a");
                BeginWriteAttribute("href", " href=\"", 1739, "\"", 1746, 0);
                EndWriteAttribute();
                WriteLiteral("><i");
                BeginWriteAttribute("class", " class=\"", 1750, "\"", 1835, 1);
#nullable restore
#line 32 "C:\Users\user\source\repos\FinalTask\FinalTask\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1758, layoutservis.GetDatas().Result.FirstOrDefault(s=>s.Key=="instagram").IconUrl, 1758, 77, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></i></a></li>\r\n                            <li><a");
                BeginWriteAttribute("href", " href=\"", 1886, "\"", 1893, 0);
                EndWriteAttribute();
                WriteLiteral("><i");
                BeginWriteAttribute("class", " class=\"", 1897, "\"", 1981, 1);
#nullable restore
#line 33 "C:\Users\user\source\repos\FinalTask\FinalTask\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1905, layoutservis.GetDatas().Result.FirstOrDefault(s=>s.Key=="linkedin").IconUrl, 1905, 76, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"></i></a></li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
        <div class=""header-bottom"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-lg-3 logo"">
                        <h2 class=""mt-2"">ETERNA</h2>
                    </div>
                    <div class=""col-lg-9 navbar"">
                        <ul class=""justify-content-end d-flex list-unstyled "">
                            <li class=""justify-content-between""><a");
                BeginWriteAttribute("href", " href=\"", 2554, "\"", 2561, 0);
                EndWriteAttribute();
                WriteLiteral(">Home</a></li>\r\n                            <li class=\"justify-content-between\"><a");
                BeginWriteAttribute("href", " href=\"", 2644, "\"", 2651, 0);
                EndWriteAttribute();
                WriteLiteral(">About</a></li>\r\n                            <li class=\"justify-content-between\"><a");
                BeginWriteAttribute("href", " href=\"", 2735, "\"", 2742, 0);
                EndWriteAttribute();
                WriteLiteral(">Services</a></li>\r\n                            <li class=\"justify-content-between\"><a");
                BeginWriteAttribute("href", " href=\"", 2829, "\"", 2836, 0);
                EndWriteAttribute();
                WriteLiteral(">Portfolio</a></li>\r\n                            <li class=\"justify-content-between\"><a");
                BeginWriteAttribute("href", " href=\"", 2924, "\"", 2931, 0);
                EndWriteAttribute();
                WriteLiteral(">Team</a></li>\r\n                            <li class=\"justify-content-between\"><a");
                BeginWriteAttribute("href", " href=\"", 3014, "\"", 3021, 0);
                EndWriteAttribute();
                WriteLiteral(">Pricing</a></li>\r\n                            <li class=\"justify-content-between\"><a");
                BeginWriteAttribute("href", " href=\"", 3107, "\"", 3114, 0);
                EndWriteAttribute();
                WriteLiteral(">Blog</a></li>\r\n                            <li class=\"justify-content-between\"><a");
                BeginWriteAttribute("href", " href=\"", 3197, "\"", 3204, 0);
                EndWriteAttribute();
                WriteLiteral(">Drop Down <i\r\n                                        class=\"fa-solid fa-angle-down\"></i></a></li>\r\n                            <li class=\"justify-content-between\"><a");
                BeginWriteAttribute("href", " href=\"", 3372, "\"", 3379, 0);
                EndWriteAttribute();
                WriteLiteral(">Contact</a></li>\r\n                        </ul>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </header>\r\n   ");
#nullable restore
#line 63 "C:\Users\user\source\repos\FinalTask\FinalTask\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    <footer id=""about"">
        <div class=""container mt-5 searcharea"">
            <div class=""row"">
                <div class=""col-lg-6 newsletter mt-3"">
                    <h3>Our Newsletter</h3>
                    <p>Tamen quem nulla quae legam multos aute sint culpa legam noster magna</p>
                </div>
                <div class=""col-lg-6 search mt-5 "">  
                    <form");
                BeginWriteAttribute("action", " action=\"", 3959, "\"", 3968, 0);
                EndWriteAttribute();
                WriteLiteral(@" method=""post""> 
                        <input class=""inp"">
                        <input class=""sub"" type=""submit"" value=""Subscribe"">
                    </form>
                </div>
            </div>
        </div>
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-3 links""> 
                    <h4>Useful Links</h4>
                    <p><a");
                BeginWriteAttribute("href", "  href=\"", 4377, "\"", 4385, 0);
                EndWriteAttribute();
                WriteLiteral("><i class=\"fa-solid fa-angle-right\"></i> Home</a></p>\r\n                    <p><a");
                BeginWriteAttribute("href", " href=\"", 4466, "\"", 4473, 0);
                EndWriteAttribute();
                WriteLiteral("><i class=\"fa-solid fa-angle-right\"></i> About us</a></p>\r\n                    <p><a");
                BeginWriteAttribute("href", " href=\"", 4558, "\"", 4565, 0);
                EndWriteAttribute();
                WriteLiteral("><i class=\"fa-solid fa-angle-right\"></i> Services</a></p>\r\n                    <p><a");
                BeginWriteAttribute("href", " href=\"", 4650, "\"", 4657, 0);
                EndWriteAttribute();
                WriteLiteral("><i class=\"fa-solid fa-angle-right\"></i> Terms of service</a></p>\r\n                    <p><a");
                BeginWriteAttribute("href", " href=\"", 4750, "\"", 4757, 0);
                EndWriteAttribute();
                WriteLiteral("><i class=\"fa-solid fa-angle-right\"></i> Privacy policy</a></p>\r\n                </div>\r\n                <div class=\"col-lg-3 links\">\r\n                    <h4>Our Services</h4>\r\n                    <p><a");
                BeginWriteAttribute("href", "  href=\"", 4961, "\"", 4969, 0);
                EndWriteAttribute();
                WriteLiteral("><i class=\"fa-solid fa-angle-right\"></i> Web Design</a></p>\r\n                    <p><a");
                BeginWriteAttribute("href", " href=\"", 5056, "\"", 5063, 0);
                EndWriteAttribute();
                WriteLiteral("><i class=\"fa-solid fa-angle-right\"></i> Web Development</a></p>\r\n                    <p><a");
                BeginWriteAttribute("href", " href=\"", 5155, "\"", 5162, 0);
                EndWriteAttribute();
                WriteLiteral("><i class=\"fa-solid fa-angle-right\"></i> Product Management</a></p>\r\n                    <p><a");
                BeginWriteAttribute("href", " href=\"", 5257, "\"", 5264, 0);
                EndWriteAttribute();
                WriteLiteral("><i class=\"fa-solid fa-angle-right\"></i> Marketing</a></p>\r\n                    <p><a");
                BeginWriteAttribute("href", " href=\"", 5350, "\"", 5357, 0);
                EndWriteAttribute();
                WriteLiteral(@"><i class=""fa-solid fa-angle-right""></i> Graphic Design</a></p>
                </div>
                <div class=""col-lg-3 links"">
                    <h4>Contact Us</h4>
                    <p>AZ062 20 January <br>
                       Baku, AZ1005 <br>
                       Azerbaijan <br>
                    </p>
                    <h6>Phone: <p>");
#nullable restore
#line 103 "C:\Users\user\source\repos\FinalTask\FinalTask\Views\Shared\_Layout.cshtml"
                             Write(layoutservis.GetDatas().Result.FirstOrDefault(s=>s.Key=="phone").Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p></h6>\r\n                    <h6>Email: <p>");
#nullable restore
#line 104 "C:\Users\user\source\repos\FinalTask\FinalTask\Views\Shared\_Layout.cshtml"
                             Write(layoutservis.GetDatas().Result.FirstOrDefault(s=>s.Key=="email").Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p></h6>
                </div>
                <div class=""col-lg-3 links"">
                    <h4>About Eterna</h4>
                    <p>Cras fermentum odio eu feugiat lide par naso tierra. Justo eget nada terra videa magna derita valies darta donna mare fermentum iaculis eu non diam phasellus.</p>
                    <i");
                BeginWriteAttribute("class", " class=\"", 6240, "\"", 6323, 1);
#nullable restore
#line 109 "C:\Users\user\source\repos\FinalTask\FinalTask\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 6248, layoutservis.GetDatas().Result.FirstOrDefault(s=>s.Key=="twitter").IconUrl, 6248, 75, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></i>\r\n                    <i");
                BeginWriteAttribute("class", " class=\"", 6353, "\"", 6437, 1);
#nullable restore
#line 110 "C:\Users\user\source\repos\FinalTask\FinalTask\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 6361, layoutservis.GetDatas().Result.FirstOrDefault(s=>s.Key=="facebook").IconUrl, 6361, 76, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></i>\r\n                    <i");
                BeginWriteAttribute("class", " class=\"", 6467, "\"", 6552, 1);
#nullable restore
#line 111 "C:\Users\user\source\repos\FinalTask\FinalTask\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 6475, layoutservis.GetDatas().Result.FirstOrDefault(s=>s.Key=="instagram").IconUrl, 6475, 77, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></i>\r\n                    <i");
                BeginWriteAttribute("class", " class=\"", 6582, "\"", 6663, 1);
#nullable restore
#line 112 "C:\Users\user\source\repos\FinalTask\FinalTask\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 6590, layoutservis.GetDatas().Result.FirstOrDefault(s=>s.Key=="skype").IconUrl, 6590, 73, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></i>\r\n                    <i");
                BeginWriteAttribute("class", " class=\"", 6693, "\"", 6777, 1);
#nullable restore
#line 113 "C:\Users\user\source\repos\FinalTask\FinalTask\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 6701, layoutservis.GetDatas().Result.FirstOrDefault(s=>s.Key=="linkedin").IconUrl, 6701, 76, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"></i>
                </div>
            </div>
        </div>
        <div class=""container mt-5"">
            <div class=""row text-center"">
               <p>© Copyright ETERNA. All Rights Reserved</p>
               <p class=""khalitov"">Designed by KHALITOV</p>
            </div>
        </div>
    </footer>
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "20ad686c481a719c05d222cc9ba7fcf460fd365824407", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591