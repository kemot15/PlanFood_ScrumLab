#pragma checksum "G:\CodersLab\ScrumLab\ScrumLab_Ostateczna_Wersja\CookPlan-master\src\PlanFood\PlanFood.Mvc\Views\Book\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c88b3a8070d264039f6e4154f678472bca6f4b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_Index), @"mvc.1.0.view", @"/Views/Book/Index.cshtml")]
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
#line 2 "G:\CodersLab\ScrumLab\ScrumLab_Ostateczna_Wersja\CookPlan-master\src\PlanFood\PlanFood.Mvc\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "G:\CodersLab\ScrumLab\ScrumLab_Ostateczna_Wersja\CookPlan-master\src\PlanFood\PlanFood.Mvc\Views\_ViewImports.cshtml"
using PlanFood.Mvc.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "G:\CodersLab\ScrumLab\ScrumLab_Ostateczna_Wersja\CookPlan-master\src\PlanFood\PlanFood.Mvc\Views\_ViewImports.cshtml"
using PlanFood.Mvc.Models.Db;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c88b3a8070d264039f6e4154f678472bca6f4b7", @"/Views/Book/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64f6064c036a569ef5c098c2dbeb54f6e6e3da03", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<PlanFood.Mvc.Models.Db.Book>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("recipes-section"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 3 "G:\CodersLab\ScrumLab\ScrumLab_Ostateczna_Wersja\CookPlan-master\src\PlanFood\PlanFood.Mvc\Views\Book\Index.cshtml"
  
    ViewBag.Title = "Książki kucharskie";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<!DOCTYPE html>\n<html lang=\"en\">\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c88b3a8070d264039f6e4154f678472bca6f4b75838", async() => {
                WriteLiteral("\n    <meta charset=\"utf-8\">\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, shrink-to-fit=no\">\n    <title>");
#nullable restore
#line 12 "G:\CodersLab\ScrumLab\ScrumLab_Ostateczna_Wersja\CookPlan-master\src\PlanFood\PlanFood.Mvc\Views\Book\Index.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral(" - Zaplanuj Jedzonko</title>\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7c88b3a8070d264039f6e4154f678472bca6f4b76525", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <link href=""https://fonts.googleapis.com/css?family=Charmonman:400,700|Open+Sans:400,600,700&amp;subset=latin-ext"" rel=""stylesheet"">
    <link rel=""stylesheet"" href=""https://use.fontawesome.com/releases/v5.5.0/css/all.css"" integrity=""sha384-B4dIYHKNBt8Bc12p+WXckhzcICo0wtJAoU8YZTY5qE0Id1GSseTk6S+L3BlXeVIU"" crossorigin=""anonymous"">
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7c88b3a8070d264039f6e4154f678472bca6f4b78137", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
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
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c88b3a8070d264039f6e4154f678472bca6f4b710103", async() => {
                WriteLiteral(@"
    <header class=""page-header"">
        <nav class=""navbar navbar-expand-lg justify-content-around"">
            <a href=""/"" class=""navbar-brand main-logo"">
                Zaplanuj <span>Jedzonko</span>
            </a>
            <ul class=""nav nounderline text-uppercase"">
                <li class=""nav-item ml-4"">
                    <a class=""nav-link color-header"" href=""login.html"">logowanie</a>
                </li>
                <li class=""nav-item ml-4"">
                    <a class=""nav-link color-header"" href=""registration.html"">rejestracja</a>
                </li>
                <li class=""nav-item ml-4"">
                    <a class=""nav-link"" href=""/#about"">o aplikacji</a>
                </li>
                <li class=""nav-item ml-4"">
                    <a class=""nav-link disabled"" href=""recipes.html"">Przepisy</a>
                </li>
                <li class=""nav-item ml-4"">
                    <a class=""nav-link disabled"" href=""/#contact"">Kontakt</a>
                </li>
          ");
                WriteLiteral("  </ul>\n        </nav>\n    </header>\n    <section>\n        <div class=\"row padding-small\">\n            <i class=\"fas fa-users icon-users\"></i>\n            <h1>");
#nullable restore
#line 46 "G:\CodersLab\ScrumLab\ScrumLab_Ostateczna_Wersja\CookPlan-master\src\PlanFood\PlanFood.Mvc\Views\Book\Index.cshtml"
           Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral(@":</h1>
            <hr>
            <div class=""orange-line w-100""></div>
        </div>
    </section>
    <section class=""mr-4 ml-4"">
        <table class=""table"">
            <thead>
                <tr class=""d-flex text-color-darker"">
                    <th scope=""col"" class=""col-1"">ID</th>
                    <th scope=""col"" class=""col-5"">TYTUŁ</th>
                    <th scope=""col"" class=""col-5"">AUTOR</th>
                    <th scope=""col"" class=""col-1"">ISBN</th>
                </tr>
            </thead>
            <tbody class=""text-color-lighter"">
");
#nullable restore
#line 62 "G:\CodersLab\ScrumLab\ScrumLab_Ostateczna_Wersja\CookPlan-master\src\PlanFood\PlanFood.Mvc\Views\Book\Index.cshtml"
             foreach (var book in Model)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr class=\"d-flex\">\n                    <th scope=\"row\" class=\"col-1\">");
#nullable restore
#line 65 "G:\CodersLab\ScrumLab\ScrumLab_Ostateczna_Wersja\CookPlan-master\src\PlanFood\PlanFood.Mvc\Views\Book\Index.cshtml"
                                             Write(book.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\n                    <td class=\"col-5\">");
#nullable restore
#line 66 "G:\CodersLab\ScrumLab\ScrumLab_Ostateczna_Wersja\CookPlan-master\src\PlanFood\PlanFood.Mvc\Views\Book\Index.cshtml"
                                 Write(book.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                    <td class=\"col-4\">");
#nullable restore
#line 67 "G:\CodersLab\ScrumLab\ScrumLab_Ostateczna_Wersja\CookPlan-master\src\PlanFood\PlanFood.Mvc\Views\Book\Index.cshtml"
                                 Write(book.Author);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                    <td class=\"col-2\">");
#nullable restore
#line 68 "G:\CodersLab\ScrumLab\ScrumLab_Ostateczna_Wersja\CookPlan-master\src\PlanFood\PlanFood.Mvc\Views\Book\Index.cshtml"
                                 Write(book.Isbn);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                </tr>\n");
#nullable restore
#line 70 "G:\CodersLab\ScrumLab\ScrumLab_Ostateczna_Wersja\CookPlan-master\src\PlanFood\PlanFood.Mvc\Views\Book\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"            </tbody>
        </table>
    </section>
    <section class=""last-info-section padding-small"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col"">
                    <h3 class=""mb-4"">Lorem ipsum dolor</h3>
                    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam at porttitor sem.  Aliquam erat volutpat. Donec placerat nisl magna.</p>
                </div>
                <div class=""col pl-4 ml-4"">
                    <h3 class=""mb-4"">Lorem ipsum dolor</h3>
                    <ul class=""container"">
                        <li>consectetur adipiscing elit</li>
                        <li>sed do eiusmod tempor</li>
                        <li>incididunt ut labore</li>
                        <li>et dolore magna aliqua</li>
                    </ul>
                </div>
                <div class=""col"">
                    <h3 class=""mb-4"">Lorem ipsum dolor</h3>
                    <div class=""input-group mb-3"">
          ");
                WriteLiteral("              <input type=\"text\" class=\"form-control border-0 rounded-0\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 4037, "\"", 4051, 0);
                EndWriteAttribute();
                WriteLiteral(@"
                               aria-label=""Recipient's username"" aria-describedby=""basic-addon2"">
                        <div class=""input-group-append"">
                            <button class=""input-group-text btn-color border-0 rounded-0"" type=""submit"" id=""basic-addon2"">
                                <a href=""index.html"">Lorem</a>
                            </button>
                        </div>
                    </div>
                    <div class=""container d-flex-row"">
                        <a href=""#"">
                            <i class=""fab fa-facebook-square mr-4 icon-social""></i>
                        </a>
                        <a href=""#"">
                            <i class=""fab fa-twitter-square mr-4 icon-social""></i>

                        </a>
                        <a href=""#"">
                            <i class=""fab fa-instagram icon-social""></i>
                        </a>
                    </div>
                </div>
            </div>
        </div>
    </se");
                WriteLiteral(@"ction>
    <footer class=""footer-section pt-3 pb-3"">
        <div class=""container text-center"">
            <h5 class=""text-light"">Copyright <span class=""footer-text-color"">ZaplanujJedzonko.pl</span></h5>
        </div>
    </footer>
    <script src=""https://code.jquery.com/jquery-3.3.1.slim.min.js"" integrity=""sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo""
            crossorigin=""anonymous""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js"" integrity=""sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49""
            crossorigin=""anonymous""></script>
    <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js"" integrity=""sha384-ChfqqxuZUCnJSK3+MXmPNIyE6ZbWh2IMqE241rYiqJxyMiZ6OW/JmZQ5stwEULTy""
            crossorigin=""anonymous""></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<PlanFood.Mvc.Models.Db.Book>> Html { get; private set; }
    }
}
#pragma warning restore 1591
