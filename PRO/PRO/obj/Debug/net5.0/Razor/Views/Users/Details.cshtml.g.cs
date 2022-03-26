#pragma checksum "E:\Repo_PRO\PRO\PRO\Views\Users\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32f1fd962d896e663b6588e986ee8ca8a44c3c16"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Details), @"mvc.1.0.view", @"/Views/Users/Details.cshtml")]
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
#line 1 "E:\Repo_PRO\PRO\PRO\Views\_ViewImports.cshtml"
using PRO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Repo_PRO\PRO\PRO\Views\_ViewImports.cshtml"
using PRO.UI.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32f1fd962d896e663b6588e986ee8ca8a44c3c16", @"/Views/Users/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50bf9f3a3aa24260c90f9edb8910125fa82e0c97", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Users_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PRO.UI.ViewModels.UserProfileViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "~/Views/Users/_TopUserBar.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "~/Views/Users/_UserLeftSide.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "~/Views/Shared/_SingleReview.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\Repo_PRO\PRO\PRO\Views\Users\Details.cshtml"
  
    ViewBag.Title = "Profil użytkownika";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    <div class=\"box-shadow\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "32f1fd962d896e663b6588e986ee8ca8a44c3c164282", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute(",", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
#nullable restore
#line 8 "E:\Repo_PRO\PRO\PRO\Views\Users\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model.AppUser;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<div id=\"content\" class=\"userprofilecontent box-shadow window-background\">\r\n");
#nullable restore
#line 12 "E:\Repo_PRO\PRO\PRO\Views\Users\Details.cshtml"
     if (Model.AppUser.IsPublic || ViewBag.IsOwner)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "32f1fd962d896e663b6588e986ee8ca8a44c3c166462", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute(",", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
#nullable restore
#line 15 "E:\Repo_PRO\PRO\PRO\Views\Users\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model.AppUser;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral(@"        <div valign=""top"" style=""        padding-left: 5px;        display: flex;        width: 100%;"">
            <div class=""js-scrollfix-bottom-rel"" style=""display: flex; width: 100%;"">
                <div style="" margin:0 auto""></div><a name=""lower""></a>

                <table border=""0"" cellspacing=""0"" cellpadding=""0"" style=""display: inline-table; width: 100%;"">
                    <tbody>
                        <tr>
                            <td class=""pb24"">
                                <div class=""underlined_h2"">Opis</div>
");
#nullable restore
#line 26 "E:\Repo_PRO\PRO\PRO\Views\Users\Details.cshtml"
                                 if (Model.AppUser.Description != null)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>\r\n                                        ");
#nullable restore
#line 28 "E:\Repo_PRO\PRO\PRO\Views\Users\Details.cshtml"
                                   Write(Html.Raw(@Model.AppUser.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </p>\r\n");
#nullable restore
#line 30 "E:\Repo_PRO\PRO\PRO\Views\Users\Details.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p>\r\n                                        Ten użytkownik nie wprowadził jeszcze opisu.\r\n                                    </p>\r\n");
#nullable restore
#line 36 "E:\Repo_PRO\PRO\PRO\Views\Users\Details.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </td>
                        </tr>
                        <tr>
                            <td class=""pb24"">
                                <div class=""user-statistics mb24"">
                                    <div class=""underlined_h2"">Statystyki</div>
                                    <div class=""userprofile-statistics mt16"">
                                        <div class=""stats userprofile-cell"">
                                            <div class=""underlined_h2"" style=""font-weight: 400;"">Listy</div>
                                            <div class=""spaceit user-list-stats font-weight-bold""><span class=""dark_text"">Wszystkich gier: </span><a");
            BeginWriteAttribute("href", " href=\"", 2321, "\"", 2362, 2);
            WriteAttributeValue("", 2328, "/users/gamelists/", 2328, 17, true);
#nullable restore
#line 47 "E:\Repo_PRO\PRO\PRO\Views\Users\Details.cshtml"
WriteAttributeValue("", 2345, Model.AppUser.Id, 2345, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 47 "E:\Repo_PRO\PRO\PRO\Views\Users\Details.cshtml"
                                                                                                                                                                                          Write(Model.GameLists.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></div>\r\n                                            <div class=\"spaceit user-list-stats font-weight-bold\">\r\n                                                <span class=\"dark_text\">Średnia ocen: </span>\r\n");
#nullable restore
#line 50 "E:\Repo_PRO\PRO\PRO\Views\Users\Details.cshtml"
                                                  
                                                    double? avr = Model.GameLists.Average(s => s.PersonalScore);
                                                    if (avr.HasValue)
                                                    {
                                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "E:\Repo_PRO\PRO\PRO\Views\Users\Details.cshtml"
                                                         Write(Math.Round(avr.Value, 1));

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "E:\Repo_PRO\PRO\PRO\Views\Users\Details.cshtml"
                                                                                              
                                                    }
                                                    else
                                                    {
                                                        

#line default
#line hidden
#nullable disable
            WriteLiteral(" Brak ocen");
#nullable restore
#line 58 "E:\Repo_PRO\PRO\PRO\Views\Users\Details.cshtml"
                                                                               
                                                    };
                                                

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n                                            </div>\r\n                                            <div class=\"clearfix mauto mt16\" style=\"width:160px;padding-right:10px\"></div>\r\n");
#nullable restore
#line 66 "E:\Repo_PRO\PRO\PRO\Views\Users\Details.cshtml"
                                             foreach (var type in Model.ListTypes)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"spaceit user-list-stats\"><span class=\"dark_text\">");
#nullable restore
#line 67 "E:\Repo_PRO\PRO\PRO\Views\Users\Details.cshtml"
                                                                                                     Write(type.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span><a");
            BeginWriteAttribute("href", " href=\"", 3731, "\"", 3797, 4);
            WriteAttributeValue("", 3738, "/users/gamelists/", 3738, 17, true);
#nullable restore
#line 67 "E:\Repo_PRO\PRO\PRO\Views\Users\Details.cshtml"
WriteAttributeValue("", 3755, Model.AppUser.Id, 3755, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3772, "?currentFilter=", 3772, 15, true);
#nullable restore
#line 67 "E:\Repo_PRO\PRO\PRO\Views\Users\Details.cshtml"
WriteAttributeValue("", 3787, type.Name, 3787, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 67 "E:\Repo_PRO\PRO\PRO\Views\Users\Details.cshtml"
                                                                                                                                                                                             Write(Model.GameLists.Where(t => t.UserList.ListTypeId == type.Id).Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></div>\r\n");
#nullable restore
#line 68 "E:\Repo_PRO\PRO\PRO\Views\Users\Details.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </div>
                                        <div class=""updates game userprofile-cell"">
                                            <div class=""underlined_h2"" style=""font-weight: 400;"">Ostatnio aktualizowane</div>
");
#nullable restore
#line 73 "E:\Repo_PRO\PRO\PRO\Views\Users\Details.cshtml"
                                             if (Model.RecentlyUpdatedGames?.Any() ?? false)
                                            {

                                                foreach (var game in Model.RecentlyUpdatedGames)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"statistics-updates di-b w100 mb8\" style=\"margin-bottom:5px;\">\r\n");
#nullable restore
#line 78 "E:\Repo_PRO\PRO\PRO\Views\Users\Details.cshtml"
                                                         if (game.Item1.Game.Image != null)
                                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<a");
            BeginWriteAttribute("href", " href=\"", 4702, "\"", 4734, 2);
            WriteAttributeValue("", 4709, "/games/", 4709, 7, true);
#nullable restore
#line 79 "E:\Repo_PRO\PRO\PRO\Views\Users\Details.cshtml"
WriteAttributeValue("", 4716, game.Item1.GameId, 4716, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"image fl-l di-ib mr8\">\r\n                                                                <img style=\"max-width:60px;\" class=\"lazyloaded\"");
            BeginWriteAttribute("src", " src=\"", 4878, "\"", 4924, 2);
            WriteAttributeValue("", 4884, "/images/", 4884, 8, true);
#nullable restore
#line 80 "E:\Repo_PRO\PRO\PRO\Views\Users\Details.cshtml"
WriteAttributeValue("", 4892, game.Item1.Game.Image.ImagePath, 4892, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                            </a>");
#nullable restore
#line 81 "E:\Repo_PRO\PRO\PRO\Views\Users\Details.cshtml"
                                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <div class=\"data\" style=\"font-size:0.85rem;\">\r\n                                                            <a");
            BeginWriteAttribute("href", " href=\"", 5160, "\"", 5192, 2);
            WriteAttributeValue("", 5167, "/games/", 5167, 7, true);
#nullable restore
#line 83 "E:\Repo_PRO\PRO\PRO\Views\Users\Details.cshtml"
WriteAttributeValue("", 5174, game.Item1.GameId, 5174, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 83 "E:\Repo_PRO\PRO\PRO\Views\Users\Details.cshtml"
                                                                                           Write(game.Item1.Game.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                                            <div class=\"clearfix graph-content pt8\" style=\"display:flex; flex-direction:column;\">\r\n                                                                <span class=\"fl-r fn-grey2\">Edytowano ");
#nullable restore
#line 85 "E:\Repo_PRO\PRO\PRO\Views\Users\Details.cshtml"
                                                                                                 Write(game.Item2.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                                                <span class=\"text completed\">");
#nullable restore
#line 86 "E:\Repo_PRO\PRO\PRO\Views\Users\Details.cshtml"
                                                                                        Write(game.Item1.UserList.ListType.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                                                <span class=\"text completed score-label score-8\">Ocena: ");
#nullable restore
#line 87 "E:\Repo_PRO\PRO\PRO\Views\Users\Details.cshtml"
                                                                                                                   Write(game.Item1.PersonalScore);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                                            </div>

                                                            <div class=""clearfix graph-content pt8"">

                                                            </div>
                                                        </div>
                                                    </div>
");
#nullable restore
#line 95 "E:\Repo_PRO\PRO\PRO\Views\Users\Details.cshtml"
                                                }
                                            }
                                            else
                                            { 

#line default
#line hidden
#nullable disable
            WriteLiteral("Brak gier");
#nullable restore
#line 98 "E:\Repo_PRO\PRO\PRO\Views\Users\Details.cshtml"
                                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </div>

                                    </div>
                                </div>
                                <div class=""clearfix mauto mt16"" style=""width:160px;padding-right:10px"">
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td class=""pb24"">
                                <div>
                                    <span class=""floatRightHeader"">
");
#nullable restore
#line 112 "E:\Repo_PRO\PRO\PRO\Views\Users\Details.cshtml"
                                          
                                            if (Model.ReviewsPlaytimes != null)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <a");
            BeginWriteAttribute("href", " href=\"", 7141, "\"", 7195, 3);
            WriteAttributeValue("", 7148, "/users/reviews/", 7148, 15, true);
#nullable restore
#line 115 "E:\Repo_PRO\PRO\PRO\Views\Users\Details.cshtml"
WriteAttributeValue("", 7163, Model.AppUser.Id, 7163, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 7180, "?page=1&items=5", 7180, 15, true);
            EndWriteAttribute();
            WriteLiteral(">Wszystkie recenzje</a>");
#nullable restore
#line 115 "E:\Repo_PRO\PRO\PRO\Views\Users\Details.cshtml"
                                                                                                                                }
                                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </span>\r\n                                    <div class=\"underlined_h2\">Recenzje użytkownika</div>\r\n                                </div>\r\n");
#nullable restore
#line 120 "E:\Repo_PRO\PRO\PRO\Views\Users\Details.cshtml"
                                 if (Model.ReviewsPlaytimes.Count() == 0)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>Użytkownik nie napisał jeszcze żadnej recenzji</p>");
#nullable restore
#line 121 "E:\Repo_PRO\PRO\PRO\Views\Users\Details.cshtml"
                                                                                      }

#line default
#line hidden
#nullable disable
#nullable restore
#line 122 "E:\Repo_PRO\PRO\PRO\Views\Users\Details.cshtml"
                                 for (int i = 1; i <= 3; i++)
                                {
                                    if (Model.ReviewsPlaytimes.Count() >= i)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "32f1fd962d896e663b6588e986ee8ca8a44c3c1624125", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute(",", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
#nullable restore
#line 126 "E:\Repo_PRO\PRO\PRO\Views\Users\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model.ReviewsPlaytimes.ToList()[i - 1];

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 127 "E:\Repo_PRO\PRO\PRO\Views\Users\Details.cshtml"

                                    }

                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n                    </tbody>\r\n                </table>\r\n            </div>\r\n\r\n        </div>\r\n");
#nullable restore
#line 139 "E:\Repo_PRO\PRO\PRO\Views\Users\Details.cshtml"

    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p style=\"display:flex; justify-content:center; margin-top:1rem;\">Ten profil jest prywatny</p>\r\n");
#nullable restore
#line 144 "E:\Repo_PRO\PRO\PRO\Views\Users\Details.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PRO.UI.ViewModels.UserProfileViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
