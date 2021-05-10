#pragma checksum "D:\PRO_Core\PRO\PRO\Views\Shared\_GameInfoBar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eda5f942a164763b69023b2a7ef89bb08fc0724a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__GameInfoBar), @"mvc.1.0.view", @"/Views/Shared/_GameInfoBar.cshtml")]
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
#line 1 "D:\PRO_Core\PRO\PRO\Views\_ViewImports.cshtml"
using PRO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\PRO_Core\PRO\PRO\Views\_ViewImports.cshtml"
using PRO.UI.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eda5f942a164763b69023b2a7ef89bb08fc0724a", @"/Views/Shared/_GameInfoBar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50bf9f3a3aa24260c90f9edb8910125fa82e0c97", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__GameInfoBar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PRO.UI.ViewModels.GameAndGameListFormViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<td class=\"borderClass\" width=\"225\" style=\"border-width: 0 1px 0 0;\" valign=\"top\">\r\n    <div style=\"width: 225px\">\r\n\r\n        <div style=\"text-align: center;\">\r\n");
#nullable restore
#line 8 "D:\PRO_Core\PRO\PRO\Views\Shared\_GameInfoBar.cshtml"
             if (Model.Game.Image != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<a>\r\n                    <img style=\"max-width:200px;width: expression(this.width > 200 ? 200: true);\" class=\"lazyloaded\"");
            BeginWriteAttribute("src", " src=\"", 398, "\"", 439, 2);
            WriteAttributeValue("", 404, "/images/", 404, 8, true);
#nullable restore
#line 10 "D:\PRO_Core\PRO\PRO\Views\Shared\_GameInfoBar.cshtml"
WriteAttributeValue("", 412, Model.Game.Image.ImagePath, 412, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                </a>");
#nullable restore
#line 11 "D:\PRO_Core\PRO\PRO\Views\Shared\_GameInfoBar.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 14 "D:\PRO_Core\PRO\PRO\Views\Shared\_GameInfoBar.cshtml"
         if (User.Identity.IsAuthenticated && (Model.UserLists?.Any() ?? false))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"underlined_h2\">Dodaj do listy</div>\r\n");
#nullable restore
#line 16 "D:\PRO_Core\PRO\PRO\Views\Shared\_GameInfoBar.cshtml"
       Write(await Component.InvokeAsync("AddGameToUserList", new { gameid = Model.Game.Id}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\PRO_Core\PRO\PRO\Views\Shared\_GameInfoBar.cshtml"
                                                                                            
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        <div class=\"underlined_h2\">Informacje</div>\r\n\r\n        <div class=\"spaceit\">\r\n            <span class=\"dark_text\">Data premiery: </span>\r\n");
#nullable restore
#line 24 "D:\PRO_Core\PRO\PRO\Views\Shared\_GameInfoBar.cshtml"
              

                if (Model.Game.ReleaseDate == null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <a href=\"#\">Nieznana</a>");
#nullable restore
#line 27 "D:\PRO_Core\PRO\PRO\Views\Shared\_GameInfoBar.cshtml"
                                          }
                else if (Model.Game.ReleaseDate.Value.Year < 1900)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <a href=\"#\">Nieznana</a>");
#nullable restore
#line 29 "D:\PRO_Core\PRO\PRO\Views\Shared\_GameInfoBar.cshtml"
                                          }
                else
                {
                    var date = @Model.Game.ReleaseDate.Value.ToShortDateString();

        

#line default
#line hidden
#nullable disable
            WriteLiteral("<a href=\"#\">");
#nullable restore
#line 34 "D:\PRO_Core\PRO\PRO\Views\Shared\_GameInfoBar.cshtml"
               Write(date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>");
#nullable restore
#line 34 "D:\PRO_Core\PRO\PRO\Views\Shared\_GameInfoBar.cshtml"
                             }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <div class=\"spaceit\"><span class=\"dark_text\">Platforma: </span><a href=\"#\">");
#nullable restore
#line 37 "D:\PRO_Core\PRO\PRO\Views\Shared\_GameInfoBar.cshtml"
                                                                              Write(Model.Game.Platform.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></div>\r\n        <div class=\"spaceit\"><span class=\"dark_text\">Gatunek: </span>");
#nullable restore
#line 38 "D:\PRO_Core\PRO\PRO\Views\Shared\_GameInfoBar.cshtml"
                                                                Write(Model.Game.Genre.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <div class=\"spaceit\">\r\n            <span class=\"dark_text\">Wydawca: </span>");
#nullable restore
#line 40 "D:\PRO_Core\PRO\PRO\Views\Shared\_GameInfoBar.cshtml"
                                                     if (Model.Game.PublisherCompany == null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<a>Brak</a> ");
#nullable restore
#line 41 "D:\PRO_Core\PRO\PRO\Views\Shared\_GameInfoBar.cshtml"
                         }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <a>");
#nullable restore
#line 43 "D:\PRO_Core\PRO\PRO\Views\Shared\_GameInfoBar.cshtml"
            Write(Model.Game.PublisherCompany.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>");
#nullable restore
#line 43 "D:\PRO_Core\PRO\PRO\Views\Shared\_GameInfoBar.cshtml"
                                                      }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <div class=\"spaceit\">\r\n            <span class=\"dark_text\">Producent: </span>");
#nullable restore
#line 46 "D:\PRO_Core\PRO\PRO\Views\Shared\_GameInfoBar.cshtml"
                                                       if (Model.Game.DeveloperCompany == null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<a>Brak</a> ");
#nullable restore
#line 47 "D:\PRO_Core\PRO\PRO\Views\Shared\_GameInfoBar.cshtml"
                         }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <a>");
#nullable restore
#line 49 "D:\PRO_Core\PRO\PRO\Views\Shared\_GameInfoBar.cshtml"
            Write(Model.Game.DeveloperCompany.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>");
#nullable restore
#line 49 "D:\PRO_Core\PRO\PRO\Views\Shared\_GameInfoBar.cshtml"
                                                      }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <div class=\"spaceit\"><span class=\"dark_text\">Status: </span> <a>");
#nullable restore
#line 51 "D:\PRO_Core\PRO\PRO\Views\Shared\_GameInfoBar.cshtml"
                                                                   Write(Model.Game.Status.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a> </div>\r\n        <div class=\"spaceit\">\r\n            <span class=\"dark_text\">Seria: </span>");
#nullable restore
#line 53 "D:\PRO_Core\PRO\PRO\Views\Shared\_GameInfoBar.cshtml"
                                                   if (Model.Game.SeriesId == null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<a>Brak</a> ");
#nullable restore
#line 54 "D:\PRO_Core\PRO\PRO\Views\Shared\_GameInfoBar.cshtml"
                         }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <a>");
#nullable restore
#line 56 "D:\PRO_Core\PRO\PRO\Views\Shared\_GameInfoBar.cshtml"
            Write(Model.Game.Series.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>");
#nullable restore
#line 56 "D:\PRO_Core\PRO\PRO\Views\Shared\_GameInfoBar.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n\r\n        <div>\r\n            <span class=\"dark_text\">Języki:</span>\r\n\r\n\r\n");
#nullable restore
#line 63 "D:\PRO_Core\PRO\PRO\Views\Shared\_GameInfoBar.cshtml"
             foreach (var language in Model.Game.Languages)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a href=\"#\">");
#nullable restore
#line 65 "D:\PRO_Core\PRO\PRO\Views\Shared\_GameInfoBar.cshtml"
                       Write(language.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 66 "D:\PRO_Core\PRO\PRO\Views\Shared\_GameInfoBar.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"spaceit\">\r\n            <span class=\"dark_text\">Tagi:</span>\r\n");
#nullable restore
#line 71 "D:\PRO_Core\PRO\PRO\Views\Shared\_GameInfoBar.cshtml"
             foreach (var tag in Model.Game.Tags)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a href=\"#\">");
#nullable restore
#line 73 "D:\PRO_Core\PRO\PRO\Views\Shared\_GameInfoBar.cshtml"
                       Write(tag.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 74 "D:\PRO_Core\PRO\PRO\Views\Shared\_GameInfoBar.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n        <br>\r\n\r\n        <div class=\"underlined_h2\">Statystyki</div>\r\n        <div>\r\n            <span class=\"dark_text\">Ocena:</span>\r\n            <span class=\"score-label score-7\">");
#nullable restore
#line 83 "D:\PRO_Core\PRO\PRO\Views\Shared\_GameInfoBar.cshtml"
                                          Write(Model.Rating==null?0:@Model.Rating);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </div>\r\n        <div>\r\n            <span class=\"dark_text\">Ranking:</span>\r\n            #");
#nullable restore
#line 87 "D:\PRO_Core\PRO\PRO\Views\Shared\_GameInfoBar.cshtml"
        Write(Model.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div>\r\n            <span class=\"dark_text\">Popularność:</span>\r\n            #");
#nullable restore
#line 91 "D:\PRO_Core\PRO\PRO\Views\Shared\_GameInfoBar.cshtml"
        Write(Model.Popularity);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <br>\r\n\r\n\r\n        <div class=\"underlined_h2\">Nagrody</div>\r\n");
#nullable restore
#line 97 "D:\PRO_Core\PRO\PRO\Views\Shared\_GameInfoBar.cshtml"
          
            if (Model.Game.Awards?.Any() == true)
            {
                foreach (var award in Model.Game.Awards)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span>");
#nullable restore
#line 102 "D:\PRO_Core\PRO\PRO\Views\Shared\_GameInfoBar.cshtml"
                     Write(award.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><br />\r\n");
#nullable restore
#line 103 "D:\PRO_Core\PRO\PRO\Views\Shared\_GameInfoBar.cshtml"
                }
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div>brak</div>\r\n");
#nullable restore
#line 108 "D:\PRO_Core\PRO\PRO\Views\Shared\_GameInfoBar.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"clearfix mauto mt16\" style=\"width:160px;padding-right:10px\">\r\n        </div>\r\n\r\n    </div>\r\n</td>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PRO.UI.ViewModels.GameAndGameListFormViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
