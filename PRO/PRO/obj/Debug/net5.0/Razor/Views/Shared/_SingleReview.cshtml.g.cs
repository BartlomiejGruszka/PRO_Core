#pragma checksum "D:\PRO_Core\PRO\PRO\Views\Shared\_SingleReview.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "59aa81542477d9ac461dc955a314220e4d3b4cac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__SingleReview), @"mvc.1.0.view", @"/Views/Shared/_SingleReview.cshtml")]
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
#nullable restore
#line 2 "D:\PRO_Core\PRO\PRO\Views\Shared\_SingleReview.cshtml"
using PRO.Domain.Extensions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59aa81542477d9ac461dc955a314220e4d3b4cac", @"/Views/Shared/_SingleReview.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50bf9f3a3aa24260c90f9edb8910125fa82e0c97", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__SingleReview : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tuple<PRO.Entities.Review, int?>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""borderDark"" style=""padding: 4px 0;"">
    <div class=""spaceit"" style=""display: flex; justify-content: space-between;"">

        <div style=""float: left; padding-bottom:12px;"">
            <table border=""0"" cellpadding=""0"" cellspacing=""0"" width=""100%"" style=""padding-left: 3px;"">
                <tbody>

");
#nullable restore
#line 11 "D:\PRO_Core\PRO\PRO\Views\Shared\_SingleReview.cshtml"
                     if (ViewContext.RouteData.Values["controller"].ToString() == "Users")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td valign=\"top\" width=\"60\">\r\n                                <div");
            BeginWriteAttribute("class", " class=\"", 634, "\"", 642, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n");
#nullable restore
#line 17 "D:\PRO_Core\PRO\PRO\Views\Shared\_SingleReview.cshtml"
                                     if (Model.Item1.Game.Image != null)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<a href=\"#\">\r\n                                            <img style=\"max-width: 100%; max-height: 100%;\" class=\" lazyloaded\"");
            BeginWriteAttribute("src", " src=\"", 884, "\"", 931, 2);
            WriteAttributeValue("", 890, "/images/", 890, 8, true);
#nullable restore
#line 19 "D:\PRO_Core\PRO\PRO\Views\Shared\_SingleReview.cshtml"
WriteAttributeValue("", 898, Model.Item1.Game.Image.ImagePath, 898, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        </a>\r\n");
#nullable restore
#line 21 "D:\PRO_Core\PRO\PRO\Views\Shared\_SingleReview.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                            </td>\r\n                            <td valign=\"top\" style=\"padding-left: 10px;\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 1206, "\"", 1239, 2);
            WriteAttributeValue("", 1213, "/games/", 1213, 7, true);
#nullable restore
#line 26 "D:\PRO_Core\PRO\PRO\Views\Shared\_SingleReview.cshtml"
WriteAttributeValue("", 1220, Model.Item1.GameId, 1220, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 26 "D:\PRO_Core\PRO\PRO\Views\Shared\_SingleReview.cshtml"
                                                                Write(Model.Item1.Game.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 29 "D:\PRO_Core\PRO\PRO\Views\Shared\_SingleReview.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td valign=\"top\" width=\"60\">\r\n                                <div");
            BeginWriteAttribute("class", " class=\"", 1532, "\"", 1540, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n");
#nullable restore
#line 36 "D:\PRO_Core\PRO\PRO\Views\Shared\_SingleReview.cshtml"
                                     if (Model.Item1.User.Image != null)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<a href=\"#\">\r\n                                            <img style=\"max-width: 100%; max-height: 100%;\" class=\" lazyloaded\"");
            BeginWriteAttribute("src", " src=\"", 1782, "\"", 1829, 2);
            WriteAttributeValue("", 1788, "/images/", 1788, 8, true);
#nullable restore
#line 38 "D:\PRO_Core\PRO\PRO\Views\Shared\_SingleReview.cshtml"
WriteAttributeValue("", 1796, Model.Item1.User.Image.ImagePath, 1796, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        </a>\r\n");
#nullable restore
#line 40 "D:\PRO_Core\PRO\PRO\Views\Shared\_SingleReview.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                            </td>\r\n                            <td valign=\"top\" style=\"padding-left: 10px;\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 2104, "\"", 2137, 2);
            WriteAttributeValue("", 2111, "/users/", 2111, 7, true);
#nullable restore
#line 45 "D:\PRO_Core\PRO\PRO\Views\Shared\_SingleReview.cshtml"
WriteAttributeValue("", 2118, Model.Item1.UserId, 2118, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 45 "D:\PRO_Core\PRO\PRO\Views\Shared\_SingleReview.cshtml"
                                                                Write(Model.Item1.User.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 48 "D:\PRO_Core\PRO\PRO\Views\Shared\_SingleReview.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n\r\n        <div class=\"mb8\" style=\"float: right; text-align: right;\">\r\n            <div");
            BeginWriteAttribute("title", " title=\"", 2410, "\"", 2418, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 54 "D:\PRO_Core\PRO\PRO\Views\Shared\_SingleReview.cshtml"
                     Write(Model.Item1.ReviewDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <div class=\"lightLink spaceit\">\r\n");
#nullable restore
#line 56 "D:\PRO_Core\PRO\PRO\Views\Shared\_SingleReview.cshtml"
                  int? myInt = Model.Item2 == null ? 0 : Model.Item2; 

#line default
#line hidden
#nullable disable
            WriteLiteral("                Rozegrane: ");
#nullable restore
#line 57 "D:\PRO_Core\PRO\PRO\Views\Shared\_SingleReview.cshtml"
                      Write(myInt);

#line default
#line hidden
#nullable disable
            WriteLiteral(" h\r\n            </div>\r\n");
#nullable restore
#line 59 "D:\PRO_Core\PRO\PRO\Views\Shared\_SingleReview.cshtml"
              
                {
                    int avg = (Model.Item1.GameplayScore + Model.Item1.GraphicsScore + Model.Item1.MusicScore + Model.Item1.StoryScore) / 4;
                    if (Model.Item1.ModeratorId != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <div class=\"lightLink spaceit\">\r\n                            Średnia ocena: ");
#nullable restore
#line 64 "D:\PRO_Core\PRO\PRO\Views\Shared\_SingleReview.cshtml"
                                      Write(avg);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div>\r\n                            Edytowano: ");
#nullable restore
#line 67 "D:\PRO_Core\PRO\PRO\Views\Shared\_SingleReview.cshtml"
                                  Write(Model.Item1.EditDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n");
#nullable restore
#line 69 "D:\PRO_Core\PRO\PRO\Views\Shared\_SingleReview.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div>\r\n                            Średnia ocena: ");
#nullable restore
#line 73 "D:\PRO_Core\PRO\PRO\Views\Shared\_SingleReview.cshtml"
                                      Write(avg);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n");
#nullable restore
#line 75 "D:\PRO_Core\PRO\PRO\Views\Shared\_SingleReview.cshtml"
                    }


                } 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n    </div>\r\n");
#nullable restore
#line 83 "D:\PRO_Core\PRO\PRO\Views\Shared\_SingleReview.cshtml"
       if (ViewContext.RouteData.Values["action"].ToString() == "SingleReview")
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"spaceit\" style=\"clear: both; border-top: 1px solid #ebebeb; display:flex; justify-content:flex-end; flex-direction:column\">\r\n                <p class=\"reviewRatings\">Grywalność:    ");
#nullable restore
#line 86 "D:\PRO_Core\PRO\PRO\Views\Shared\_SingleReview.cshtml"
                                                   Write(Model.Item1.GameplayScore);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p class=\"reviewRatings\">Grafika:   ");
#nullable restore
#line 87 "D:\PRO_Core\PRO\PRO\Views\Shared\_SingleReview.cshtml"
                                               Write(Model.Item1.GraphicsScore);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p class=\"reviewRatings\">Fabuła:    ");
#nullable restore
#line 88 "D:\PRO_Core\PRO\PRO\Views\Shared\_SingleReview.cshtml"
                                               Write(Model.Item1.StoryScore);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p class=\"reviewRatings\">Muzyka:    ");
#nullable restore
#line 89 "D:\PRO_Core\PRO\PRO\Views\Shared\_SingleReview.cshtml"
                                               Write(Model.Item1.MusicScore);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>");
#nullable restore
#line 90 "D:\PRO_Core\PRO\PRO\Views\Shared\_SingleReview.cshtml"
                  }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"spaceit textReadability word-break pt8 mt8\" style=\"clear: both; border-top: 1px solid #ebebeb; border-bottom: 1px solid #ebebeb;\">\r\n\r\n\r\n\r\n");
#nullable restore
#line 97 "D:\PRO_Core\PRO\PRO\Views\Shared\_SingleReview.cshtml"
           if (ViewContext.RouteData.Values["action"].ToString() != "SingleReview")
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 99 "D:\PRO_Core\PRO\PRO\Views\Shared\_SingleReview.cshtml"
           Write(Html.Raw(@Model.Item1.Content.Truncate(200)));

#line default
#line hidden
#nullable disable
            WriteLiteral("... ");
            WriteLiteral("\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 4343, "\"", 4400, 4);
            WriteAttributeValue("", 4350, "/games/", 4350, 7, true);
#nullable restore
#line 100 "D:\PRO_Core\PRO\PRO\Views\Shared\_SingleReview.cshtml"
WriteAttributeValue("", 4357, Model.Item1.GameId, 4357, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4376, "/reviews/", 4376, 9, true);
#nullable restore
#line 100 "D:\PRO_Core\PRO\PRO\Views\Shared\_SingleReview.cshtml"
WriteAttributeValue("", 4385, Model.Item1.Id, 4385, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">więcej </a>\r\n");
#nullable restore
#line 101 "D:\PRO_Core\PRO\PRO\Views\Shared\_SingleReview.cshtml"
            }
            else
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 104 "D:\PRO_Core\PRO\PRO\Views\Shared\_SingleReview.cshtml"
           Write(Html.Raw(@Model.Item1.Content));

#line default
#line hidden
#nullable disable
#nullable restore
#line 104 "D:\PRO_Core\PRO\PRO\Views\Shared\_SingleReview.cshtml"
                                               
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tuple<PRO.Entities.Review, int?>> Html { get; private set; }
    }
}
#pragma warning restore 1591