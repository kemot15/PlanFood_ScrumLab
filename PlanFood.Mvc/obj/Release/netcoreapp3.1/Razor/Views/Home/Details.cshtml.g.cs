#pragma checksum "G:\CodersLab\ScrumLab\ScrumLab_Ostateczna_Wersja\CookPlan-master\src\PlanFood\PlanFood.Mvc\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0bdc2ef6e47d7ffc9dd724fb3e4e2c6e715909ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0bdc2ef6e47d7ffc9dd724fb3e4e2c6e715909ca", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64f6064c036a569ef5c098c2dbeb54f6e6e3da03", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Recipe>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "G:\CodersLab\ScrumLab\ScrumLab_Ostateczna_Wersja\CookPlan-master\src\PlanFood\PlanFood.Mvc\Views\Home\Details.cshtml"
  
    ViewBag.Title = "Przepis";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<section class=""mr-4 ml-4"">
    <div class=""row pt-4 pb-2"">
        <i class=""fas fa-users icon-users""></i>
        <h1>Przepisy naszych użytkowników:</h1>
        <hr>
        <div class=""orange-line w-100""></div>
    </div>
</section>

<section class=""width-medium text-color-darker"">
    <div class=""m-4 p-3 width-medium text-color-darker"">
        <div class=""dashboard-content border-dashed p-3 m-4 view-height"">
            <div class=""mt-4 ml-4 mr-4"">
                <div class=""row border-bottom border-3"">
                    <div class=""col""><h3 class=""color-header text-uppercase"">Szczegóły przepisu</h3></div>
                    <div class=""col d-flex justify-content-end mb-2""><a href=""javascript:history.back()"" class=""btn btn-color rounded-0 pt-0 pb-0 pr-4 pl-4"">Powrót</a></div>
                </div>

                <table class=""table borderless"">
                    <tbody>
                        <tr class=""d-flex"">
                            <th scope=""row"" class=""col-2"">Nazwa Przepisu</th>
  ");
            WriteLiteral("                          <td class=\"col-7\">\n                                ");
#nullable restore
#line 31 "G:\CodersLab\ScrumLab\ScrumLab_Ostateczna_Wersja\CookPlan-master\src\PlanFood\PlanFood.Mvc\Views\Home\Details.cshtml"
                           Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </td>\n                        </tr>\n                        <tr class=\"d-flex\">\n                            <th scope=\"row\" class=\"col-2\">Opis przepisu</th>\n                            <td class=\"col-7\">");
#nullable restore
#line 36 "G:\CodersLab\ScrumLab\ScrumLab_Ostateczna_Wersja\CookPlan-master\src\PlanFood\PlanFood.Mvc\Views\Home\Details.cshtml"
                                         Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        </tr>\n                        <tr class=\"d-flex\">\n                            <th scope=\"row\" class=\"col-2\">Przygotowanie (minuty)</th>\n                            <td class=\"col-7\">\n                                ");
#nullable restore
#line 41 "G:\CodersLab\ScrumLab\ScrumLab_Ostateczna_Wersja\CookPlan-master\src\PlanFood\PlanFood.Mvc\Views\Home\Details.cshtml"
                           Write(Model.PreparationTime);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </td>
                        </tr>
                    </tbody>
                </table>

                <div class=""row d-flex"">
                    <div class=""col-5 border-bottom border-3""><h3 class=""text-uppercase"">Sposób przygotowania</h3></div>
                    <div class=""col-2""></div>
                    <div class=""col-5 border-bottom border-3""><h3 class=""text-uppercase"">Składniki</h3></div>
                </div>
                <div class=""row d-flex"">
                    <div class=""col-5 p-4"">
                        <p>");
#nullable restore
#line 54 "G:\CodersLab\ScrumLab\ScrumLab_Ostateczna_Wersja\CookPlan-master\src\PlanFood\PlanFood.Mvc\Views\Home\Details.cshtml"
                      Write(Model.Preparation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                    </div>\n                    <div class=\"col-2\"></div>\n                    <ul class=\"col-5 p-4 list-unstyled\">\n                        ");
#nullable restore
#line 58 "G:\CodersLab\ScrumLab\ScrumLab_Ostateczna_Wersja\CookPlan-master\src\PlanFood\PlanFood.Mvc\Views\Home\Details.cshtml"
                   Write(Model.Ingredients);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </ul>\n                </div>\n            </div>\n        </div>\n    </div>\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Recipe> Html { get; private set; }
    }
}
#pragma warning restore 1591
