#pragma checksum "D:\С#\.NET Core\Ember\Ember\Client\Pages\Job.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1149afef1b630ab4790c559e8e8e0744098b453f"
// <auto-generated/>
#pragma warning disable 1591
namespace Ember.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\С#\.NET Core\Ember\Ember\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\С#\.NET Core\Ember\Ember\Client\_Imports.razor"
using System.Text;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\С#\.NET Core\Ember\Ember\Client\_Imports.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\С#\.NET Core\Ember\Ember\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\С#\.NET Core\Ember\Ember\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\С#\.NET Core\Ember\Ember\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\С#\.NET Core\Ember\Ember\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\С#\.NET Core\Ember\Ember\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\С#\.NET Core\Ember\Ember\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\С#\.NET Core\Ember\Ember\Client\_Imports.razor"
using Ember.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\С#\.NET Core\Ember\Ember\Client\_Imports.razor"
using Ember.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\С#\.NET Core\Ember\Ember\Client\_Imports.razor"
using Ember.Client.Auth;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\С#\.NET Core\Ember\Ember\Client\_Imports.razor"
using Ember.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\С#\.NET Core\Ember\Ember\Client\_Imports.razor"
using Ember.Client.Shared.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\С#\.NET Core\Ember\Ember\Client\_Imports.razor"
using Ember.Client.Shared.Main;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "D:\С#\.NET Core\Ember\Ember\Client\_Imports.razor"
using Ember.Client.Shared.Main.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "D:\С#\.NET Core\Ember\Ember\Client\_Imports.razor"
using Ember.Client.Shared.Layouts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "D:\С#\.NET Core\Ember\Ember\Client\_Imports.razor"
using Ember.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "D:\С#\.NET Core\Ember\Ember\Client\_Imports.razor"
using BlazorComponentUtilities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "D:\С#\.NET Core\Ember\Ember\Client\_Imports.razor"
using Blazored;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "D:\С#\.NET Core\Ember\Ember\Client\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "D:\С#\.NET Core\Ember\Ember\Client\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/job")]
    public partial class Job : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Ember.Client.Shared.Main.Intro>(0);
            __builder.AddAttribute(1, "BodyId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 4 "D:\С#\.NET Core\Ember\Ember\Client\Pages\Job.razor"
                 "body"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "ImgSource", "https://sun9-4.userapi.com/c857420/v857420760/1ad9df/5fa5DiZogHA.jpg");
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n    ");
                __builder2.AddMarkupContent(5, @"<div class=""banner-text"">
        <h2>Вакансии</h2>
        <p>
            созданно с целью бесперебойного снабжения потребителей качественным теплом,
            для обеспечения комфортных условий труда и проживания граждан.
        </p>
    </div>
");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(6, "\r\n\r\n");
            __builder.OpenElement(7, "header");
            __builder.AddAttribute(8, "id", "header");
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.OpenComponent<Ember.Client.Shared.Main.NavMenu>(10);
            __builder.AddAttribute(11, "Image", "/img/Logo.png");
            __builder.AddAttribute(12, "CssClassImage", "logo-img");
            __builder.CloseComponent();
            __builder.AddMarkupContent(13, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n\r\n");
            __builder.AddMarkupContent(15, "<div class=\"body\" id=\"body\">\r\n    <div class=\"container\">\r\n        <div class=\"jobs_block\">\r\n            <div class=\"job_container\">\r\n                <div class=\"job_item\">\r\n                    <div class=\"job_name\">\r\n                        ИНЖЕНЕР-ГЕОДЕЗИСТ\r\n                    </div>\r\n                    <div class=\"job_time\">\r\n                        20.04.2020\r\n                    </div>\r\n                    <table class=\"job_data\">\r\n                        <tbody>\r\n                            <tr>\r\n                                <td class=\"job_data-title\">\r\n                                    Место\r\n                                </td>\r\n                                <td class=\"job_data-info\">\r\n                                    СПП \"Уголек\" (г. Горловка)\r\n                                </td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td class=\"job_data-title\">\r\n                                    Зарплата\r\n                                </td>\r\n                                <td class=\"job_data-info\">\r\n                                    10 000 р.\r\n                                </td>\r\n                            </tr>\r\n                        </tbody>\r\n                    </table>\r\n                    <div class=\"btn-group\">\r\n                        <a class=\"btn btn-primary d-flex align-items-center waves-effect\" href>\r\n                            Подробнее\r\n                        </a>\r\n                    </div>\r\n                </div>\r\n\r\n                <div class=\"job_item\">\r\n                    <div class=\"job_name\">\r\n                        Программист 1С\r\n                    </div>\r\n                    <div class=\"job_time\">\r\n                        23.03.2020\r\n                    </div>\r\n                    <table class=\"job_data\">\r\n                        <tbody>\r\n                            <tr>\r\n                                <td class=\"job_data-title\">\r\n                                    Место\r\n                                </td>\r\n                                <td class=\"job_data-info\">\r\n                                    СПП \"Уголек\" (г. Горловка)\r\n                                </td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td class=\"job_data-title\">\r\n                                    Зарплата\r\n                                </td>\r\n                                <td class=\"job_data-info\">\r\n                                    14 000 р.\r\n                                </td>\r\n                            </tr>\r\n                        </tbody>\r\n                    </table>\r\n                    <div class=\"btn-group\">\r\n                        <a class=\"btn btn-primary d-flex align-items-center waves-effect\" href>\r\n                            Подробнее\r\n                        </a>\r\n                    </div>\r\n                </div>\r\n\r\n                <div class=\"job_item\">\r\n                    <div class=\"job_name\">\r\n                        Сварщик 3-го разряда\r\n                    </div>\r\n                    <div class=\"job_time\">\r\n                        20.03.2020\r\n                    </div>\r\n                    <table class=\"job_data\">\r\n                        <tbody>\r\n                            <tr>\r\n                                <td class=\"job_data-title\">\r\n                                    Место\r\n                                </td>\r\n                                <td class=\"job_data-info\">\r\n                                    СПП \"Уголек\" (г. Горловка)\r\n                                </td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td class=\"job_data-title\">\r\n                                    Зарплата\r\n                                </td>\r\n                                <td class=\"job_data-info\">\r\n                                    9 000 р.\r\n                                </td>\r\n                            </tr>\r\n                        </tbody>\r\n                    </table>\r\n                    <div class=\"btn-group\">\r\n                        <a class=\"btn btn-primary d-flex align-items-center waves-effect\" href>\r\n                            Подробнее\r\n                        </a>\r\n                    </div>\r\n                </div>\r\n\r\n                <div class=\"job_item\">\r\n                    <div class=\"job_name\">\r\n                        Водитель\r\n                    </div>\r\n                    <div class=\"job_time\">\r\n                        20.02.2020\r\n                    </div>\r\n                    <table class=\"job_data\">\r\n                        <tbody>\r\n                            <tr>\r\n                                <td class=\"job_data-title\">\r\n                                    Место\r\n                                </td>\r\n                                <td class=\"job_data-info\">\r\n                                    СПП \"Уголек\" (г. Горловка)\r\n                                </td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td class=\"job_data-title\">\r\n                                    Зарплата\r\n                                </td>\r\n                                <td class=\"job_data-info\">\r\n                                    7 000 р.\r\n                                </td>\r\n                            </tr>\r\n                        </tbody>\r\n                    </table>\r\n                    <div class=\"btn-group\">\r\n                        <a class=\"btn btn-primary d-flex align-items-center waves-effect\" href>\r\n                            Подробнее\r\n                        </a>\r\n                    </div>\r\n                </div>\r\n\r\n                <div class=\"job_item\">\r\n                    <div class=\"job_name\">\r\n                        Программист С#\r\n                    </div>\r\n                    <div class=\"job_time\">\r\n                        19.01.2020\r\n                    </div>\r\n                    <table class=\"job_data\">\r\n                        <tbody>\r\n                            <tr>\r\n                                <td class=\"job_data-title\">\r\n                                    Место\r\n                                </td>\r\n                                <td class=\"job_data-info\">\r\n                                    СПП \"Уголек\" (г. Горловка)\r\n                                </td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td class=\"job_data-title\">\r\n                                    Зарплата\r\n                                </td>\r\n                                <td class=\"job_data-info\">\r\n                                    23 000 р.\r\n                                </td>\r\n                            </tr>\r\n                        </tbody>\r\n                    </table>\r\n                    <div class=\"btn-group\">\r\n                        <a class=\"btn btn-primary d-flex align-items-center waves-effect\" href>\r\n                            Подробнее\r\n                        </a>\r\n                    </div>\r\n                </div>\r\n\r\n                <div class=\"create-line\" style></div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
