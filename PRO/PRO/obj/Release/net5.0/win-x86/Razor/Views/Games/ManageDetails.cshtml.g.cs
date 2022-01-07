#pragma checksum "D:\PRO_Core\PRO\PRO\Views\Games\ManageDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "165ccac98e3e84589e0cafa3a15b8779001b3f8c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Games_ManageDetails), @"mvc.1.0.view", @"/Views/Games/ManageDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"165ccac98e3e84589e0cafa3a15b8779001b3f8c", @"/Views/Games/ManageDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50bf9f3a3aa24260c90f9edb8910125fa82e0c97", @"/Views/_ViewImports.cshtml")]
    public class Views_Games_ManageDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PRO.Entities.Game>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\PRO_Core\PRO\PRO\Views\Games\ManageDetails.cshtml"
  
    ViewBag.Title = "ManageDetails";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h2 class=\"list-title box-shadow\">Szczegóły gry</h2>\r\n<div class=\"window-background box-shadow p-3\">\r\n    <div>\r\n\r\n        <dl class=\"dl-horizontal\">\r\n            <dt>\r\n                ");
#nullable restore
#line 15 "D:\PRO_Core\PRO\PRO\Views\Games\ManageDetails.cshtml"
           Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n\r\n            <dd>\r\n                ");
#nullable restore
#line 19 "D:\PRO_Core\PRO\PRO\Views\Games\ManageDetails.cshtml"
           Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
#nullable restore
#line 22 "D:\PRO_Core\PRO\PRO\Views\Games\ManageDetails.cshtml"
           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n\r\n            <dd>\r\n                ");
#nullable restore
#line 26 "D:\PRO_Core\PRO\PRO\Views\Games\ManageDetails.cshtml"
           Write(Html.Raw(@Model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
#nullable restore
#line 29 "D:\PRO_Core\PRO\PRO\Views\Games\ManageDetails.cshtml"
           Write(Html.DisplayNameFor(model => model.ReleaseDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n\r\n            <dd>\r\n");
#nullable restore
#line 33 "D:\PRO_Core\PRO\PRO\Views\Games\ManageDetails.cshtml"
                 if (Model.ReleaseDate != null)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "D:\PRO_Core\PRO\PRO\Views\Games\ManageDetails.cshtml"
               Write(Html.DisplayFor(model => model.ReleaseDate));

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "D:\PRO_Core\PRO\PRO\Views\Games\ManageDetails.cshtml"
                                                                

                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <p>Brak daty</p>");
#nullable restore
#line 39 "D:\PRO_Core\PRO\PRO\Views\Games\ManageDetails.cshtml"
                                  }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </dd>\r\n            <dt>\r\n                ");
#nullable restore
#line 42 "D:\PRO_Core\PRO\PRO\Views\Games\ManageDetails.cshtml"
           Write(Html.DisplayNameFor(model => model.IsActive));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n\r\n            <dd>\r\n                ");
#nullable restore
#line 46 "D:\PRO_Core\PRO\PRO\Views\Games\ManageDetails.cshtml"
           Write(Html.DisplayFor(model => model.IsActive));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
#nullable restore
#line 49 "D:\PRO_Core\PRO\PRO\Views\Games\ManageDetails.cshtml"
           Write(Html.DisplayNameFor(model => model.Platform));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
#nullable restore
#line 52 "D:\PRO_Core\PRO\PRO\Views\Games\ManageDetails.cshtml"
           Write(Html.DisplayFor(model => model.Platform.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
#nullable restore
#line 55 "D:\PRO_Core\PRO\PRO\Views\Games\ManageDetails.cshtml"
           Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n\r\n            <dd>\r\n                ");
#nullable restore
#line 59 "D:\PRO_Core\PRO\PRO\Views\Games\ManageDetails.cshtml"
           Write(Html.DisplayFor(model => model.Status.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
#nullable restore
#line 62 "D:\PRO_Core\PRO\PRO\Views\Games\ManageDetails.cshtml"
           Write(Html.DisplayNameFor(model => model.Genre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n\r\n            <dd>\r\n                ");
#nullable restore
#line 66 "D:\PRO_Core\PRO\PRO\Views\Games\ManageDetails.cshtml"
           Write(Html.DisplayFor(model => model.Genre.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
#nullable restore
#line 69 "D:\PRO_Core\PRO\PRO\Views\Games\ManageDetails.cshtml"
           Write(Html.DisplayNameFor(model => model.Series));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n\r\n            <dd>\r\n");
#nullable restore
#line 73 "D:\PRO_Core\PRO\PRO\Views\Games\ManageDetails.cshtml"
                 if (Model.Series != null)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 75 "D:\PRO_Core\PRO\PRO\Views\Games\ManageDetails.cshtml"
               Write(Html.DisplayFor(model => model.Series.Name));

#line default
#line hidden
#nullable disable
#nullable restore
#line 75 "D:\PRO_Core\PRO\PRO\Views\Games\ManageDetails.cshtml"
                                                                

                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <p>Brak serii</p>");
#nullable restore
#line 79 "D:\PRO_Core\PRO\PRO\Views\Games\ManageDetails.cshtml"
                                   }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </dd>\r\n            <dt>\r\n                ");
#nullable restore
#line 82 "D:\PRO_Core\PRO\PRO\Views\Games\ManageDetails.cshtml"
           Write(Html.DisplayNameFor(model => model.Image));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n\r\n            <dd>\r\n");
#nullable restore
#line 86 "D:\PRO_Core\PRO\PRO\Views\Games\ManageDetails.cshtml"
                 if (Model.Image != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("<img style=\"max-width:500px;width: expression(this.width > 500 ? 500: true);\" class=\" lazyloaded\"");
            BeginWriteAttribute("src", " src=\"", 2428, "\"", 2464, 2);
            WriteAttributeValue("", 2434, "/images/", 2434, 8, true);
#nullable restore
#line 87 "D:\PRO_Core\PRO\PRO\Views\Games\ManageDetails.cshtml"
WriteAttributeValue("", 2442, Model.Image.ImagePath, 2442, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 88 "D:\PRO_Core\PRO\PRO\Views\Games\ManageDetails.cshtml"

                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <p>Brak obrazu</p>");
#nullable restore
#line 91 "D:\PRO_Core\PRO\PRO\Views\Games\ManageDetails.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
#nullable restore
#line 95 "D:\PRO_Core\PRO\PRO\Views\Games\ManageDetails.cshtml"
           Write(Html.DisplayNameFor(model => model.PublisherCompany));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n\r\n            <dd>\r\n");
#nullable restore
#line 99 "D:\PRO_Core\PRO\PRO\Views\Games\ManageDetails.cshtml"
                 if (Model.PublisherCompany != null)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 101 "D:\PRO_Core\PRO\PRO\Views\Games\ManageDetails.cshtml"
               Write(Html.DisplayFor(model => model.PublisherCompany.Name));

#line default
#line hidden
#nullable disable
#nullable restore
#line 101 "D:\PRO_Core\PRO\PRO\Views\Games\ManageDetails.cshtml"
                                                                          

                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <p>Brak wydawcy</p>");
#nullable restore
#line 105 "D:\PRO_Core\PRO\PRO\Views\Games\ManageDetails.cshtml"
                                     }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
#nullable restore
#line 109 "D:\PRO_Core\PRO\PRO\Views\Games\ManageDetails.cshtml"
           Write(Html.DisplayNameFor(model => model.DeveloperCompany));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n\r\n            <dd>\r\n");
#nullable restore
#line 113 "D:\PRO_Core\PRO\PRO\Views\Games\ManageDetails.cshtml"
                 if (Model.DeveloperCompany != null)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 115 "D:\PRO_Core\PRO\PRO\Views\Games\ManageDetails.cshtml"
               Write(Html.DisplayFor(model => model.DeveloperCompany.Name));

#line default
#line hidden
#nullable disable
#nullable restore
#line 115 "D:\PRO_Core\PRO\PRO\Views\Games\ManageDetails.cshtml"
                                                                          

                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <p>Brak producenta</p>");
#nullable restore
#line 119 "D:\PRO_Core\PRO\PRO\Views\Games\ManageDetails.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </dd>\r\n            <dt>\r\n                ");
#nullable restore
#line 122 "D:\PRO_Core\PRO\PRO\Views\Games\ManageDetails.cshtml"
           Write(Html.DisplayNameFor(model => model.Tags));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n\r\n            <dd>\r\n");
#nullable restore
#line 126 "D:\PRO_Core\PRO\PRO\Views\Games\ManageDetails.cshtml"
                 if (Model.Tags != null)
                {
                    for (var x = 0; x < Model.Tags.Count; x++)
                    {
                        var tags = Model.Tags.ToArray();
                        var tag = tags[x];

                        if (x + 1 < Model.Tags.Count)
                        {
                            tag.Name = tag.Name + ", ";
                        }
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 137 "D:\PRO_Core\PRO\PRO\Views\Games\ManageDetails.cshtml"
                   Write(Html.DisplayFor(model => tag.Name));

#line default
#line hidden
#nullable disable
#nullable restore
#line 137 "D:\PRO_Core\PRO\PRO\Views\Games\ManageDetails.cshtml"
                                                           
                    }
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <p>Brak tagów</p>");
#nullable restore
#line 141 "D:\PRO_Core\PRO\PRO\Views\Games\ManageDetails.cshtml"
                                   }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </dd>\r\n            <dt>\r\n                ");
#nullable restore
#line 144 "D:\PRO_Core\PRO\PRO\Views\Games\ManageDetails.cshtml"
           Write(Html.DisplayNameFor(model => model.Languages));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n\r\n            <dd>\r\n");
#nullable restore
#line 148 "D:\PRO_Core\PRO\PRO\Views\Games\ManageDetails.cshtml"
                 if (Model.Languages != null)
                {
                    for (var x = 0; x < Model.Languages.Count; x++)
                    {
                        var tags = Model.Languages.ToArray();
                        var tag = tags[x];

                        if (x + 1 < Model.Languages.Count)
                        {
                            tag.Name = tag.Name + ", ";
                        }
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 159 "D:\PRO_Core\PRO\PRO\Views\Games\ManageDetails.cshtml"
                   Write(Html.DisplayFor(model => tag.Name));

#line default
#line hidden
#nullable disable
#nullable restore
#line 159 "D:\PRO_Core\PRO\PRO\Views\Games\ManageDetails.cshtml"
                                                           
                    }
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <p>Brak języków</p>");
#nullable restore
#line 163 "D:\PRO_Core\PRO\PRO\Views\Games\ManageDetails.cshtml"
                                     }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
#nullable restore
#line 167 "D:\PRO_Core\PRO\PRO\Views\Games\ManageDetails.cshtml"
           Write(Html.DisplayNameFor(model => model.SteamAppId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n\r\n            <dd>\r\n");
#nullable restore
#line 171 "D:\PRO_Core\PRO\PRO\Views\Games\ManageDetails.cshtml"
                 if (Model.SteamAppId != null)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 173 "D:\PRO_Core\PRO\PRO\Views\Games\ManageDetails.cshtml"
               Write(Model.SteamAppId);

#line default
#line hidden
#nullable disable
#nullable restore
#line 173 "D:\PRO_Core\PRO\PRO\Views\Games\ManageDetails.cshtml"
                                     
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <p>Brak przypisanej aplikacji Steam</p>");
#nullable restore
#line 176 "D:\PRO_Core\PRO\PRO\Views\Games\ManageDetails.cshtml"
                                                         }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n\r\n        </dl>\r\n    </div>\r\n    <hr />\r\n    <p>\r\n        <div class=\"btn btn-primary\"><a class=\"actionLinkManage\"");
            BeginWriteAttribute("href", " href=\"", 5259, "\"", 5287, 2);
            WriteAttributeValue("", 5266, "/games/edit/", 5266, 12, true);
#nullable restore
#line 184 "D:\PRO_Core\PRO\PRO\Views\Games\ManageDetails.cshtml"
WriteAttributeValue("", 5278, Model.Id, 5278, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edytuj</a></div>\r\n        <a href=\"#\" class=\"btn btn-secondary\" onclick=\"javascript:window.history.back(-1);return false;\">Powrót</a>\r\n    </p>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PRO.Entities.Game> Html { get; private set; }
    }
}
#pragma warning restore 1591
