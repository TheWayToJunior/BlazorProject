#pragma checksum "D:\С#\.NET Core\Ember\Ember\Client\Pages\News.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ddb144d4d9e303fe05c7bc0d9206aab5323d75fb"
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
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\С#\.NET Core\Ember\Ember\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\С#\.NET Core\Ember\Ember\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\С#\.NET Core\Ember\Ember\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\С#\.NET Core\Ember\Ember\Client\_Imports.razor"
using Ember.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\С#\.NET Core\Ember\Ember\Client\_Imports.razor"
using Ember.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\С#\.NET Core\Ember\Ember\Client\_Imports.razor"
using Ember.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\С#\.NET Core\Ember\Ember\Client\_Imports.razor"
using Ember.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/news")]
    public partial class News : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "section");
            __builder.AddMarkupContent(1, "\r\n    ");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "container-fluid");
            __builder.AddMarkupContent(4, "\r\n        ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "container");
            __builder.AddMarkupContent(7, "\r\n\r\n            ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "news-category");
            __builder.AddMarkupContent(10, "\r\n                ");
            __builder.OpenElement(11, "ul");
            __builder.AddAttribute(12, "class", "filter-ul");
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "li");
            __builder.AddMarkupContent(15, "\r\n                        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(16);
            __builder.AddAttribute(17, "href", "news");
            __builder.AddAttribute(18, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 10 "D:\С#\.NET Core\Ember\Ember\Client\Pages\News.razor"
                                                    NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(20, "\r\n                            ");
                __builder2.AddMarkupContent(21, "<span>Все</span>\r\n                        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(22, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                    ");
            __builder.OpenElement(24, "li");
            __builder.AddMarkupContent(25, "\r\n                        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(26);
            __builder.AddAttribute(27, "href", "#");
            __builder.AddAttribute(28, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(29, "\r\n                            ");
                __builder2.AddMarkupContent(30, "<span>Мироприятия</span>\r\n                        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(31, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                    ");
            __builder.OpenElement(33, "li");
            __builder.AddMarkupContent(34, "\r\n                        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(35);
            __builder.AddAttribute(36, "href", "#");
            __builder.AddAttribute(37, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(38, "\r\n                            ");
                __builder2.AddMarkupContent(39, "<span>Ремотн</span>\r\n                        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(40, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                    ");
            __builder.OpenElement(42, "li");
            __builder.AddMarkupContent(43, "\r\n                        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(44);
            __builder.AddAttribute(45, "href", "#");
            __builder.AddAttribute(46, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(47, "\r\n                            ");
                __builder2.AddMarkupContent(48, "<span>Экология</span>\r\n                        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(49, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n\r\n            ");
            __builder.OpenElement(53, "div");
            __builder.AddAttribute(54, "class", "row");
            __builder.AddMarkupContent(55, "\r\n");
#nullable restore
#line 33 "D:\С#\.NET Core\Ember\Ember\Client\Pages\News.razor"
                 foreach (var item in posts)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(56, "                    ");
            __builder.OpenComponent<Ember.Client.Shared.NewsCard>(57);
            __builder.AddAttribute(58, "Date", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.DateTime>(
#nullable restore
#line 35 "D:\С#\.NET Core\Ember\Ember\Client\Pages\News.razor"
                                     item.Time

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(59, "ImageSrc", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 35 "D:\С#\.NET Core\Ember\Ember\Client\Pages\News.razor"
                                                           item.ImageSrc

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(60, "Title", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 35 "D:\С#\.NET Core\Ember\Ember\Client\Pages\News.razor"
                                                                                  item.Title

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(61, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(62, "\r\n                        ");
                __builder2.OpenElement(63, "span");
                __builder2.AddMarkupContent(64, "\r\n                            ");
                __builder2.AddContent(65, 
#nullable restore
#line 37 "D:\С#\.NET Core\Ember\Ember\Client\Pages\News.razor"
                             item.Description

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(66, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(67, "\r\n                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(68, "\r\n");
#nullable restore
#line 40 "D:\С#\.NET Core\Ember\Ember\Client\Pages\News.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(69, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "D:\С#\.NET Core\Ember\Ember\Client\Pages\News.razor"
       
    NewsPost [] posts =
    {
        new NewsPost
        {
            Time = DateTime.Now,

            ImageSrc="https://sun9-9.userapi.com/c850128/v850128254/1d36a9/B54sYaowd5E.jpg",

            Title= "Об итогах ремонтного периода.",

            Description = "Согласно Правил подготовки теплового хозяйства к отопительному сезону предприятием были" +
                           " разработаны мероприятия по подготовке объектов теплоснабжения к работе в осеннее-зимний" +
                           " период 2019-2020 годов, выполнение которых обеспечит гарантированный пуск и бесперебойную" +
                           " работу котельных на протяжении всего отопительного сезона." +
                           " В ходе реализации программы СПП «Уголек» к отопительному сезону подготовлены" +
                           " 119 котельных. Выполнен ремонт 407 котлов, 499 насосных агрегатов и 59 водоподготовительных" +
                           "установок, другого котельного оборудования."

        },

        new NewsPost
        {
            Time = DateTime.Now,

            ImageSrc="https://sun9-28.userapi.com/c204516/v204516299/3b411/0qjhwQo15mw.jpg",

            Title= "Внимание произвадятся работы!!!",

            Description = "Согласно Правил подготовки теплового хозяйства к отопительному сезону предприятием были"+
                        "разработаны мероприятия по подготовке объектов теплоснабжения к работе в осеннее-зимний"+
                        "период 2019-2020 годов, выполнение которых обеспечит гарантированный пуск и бесперебойную"+
                        "работу котельных на протяжении всего отопительного сезона."+
                        "В ходе реализации программы СПП «Уголек» к отопительному сезону подготовлены"+
                        "119 котельных. Выполнен ремонт 407 котлов, 499 насосных агрегатов и 59 водоподготовительных"+
                        "установок, другого котельного оборудования."

        },

        new NewsPost
        {
            Time = DateTime.Now,

            ImageSrc="https://sun9-26.userapi.com/c206624/v206624328/1cfc1/QhLJ8tTkLC8.jpg",

            Title= "Инвестиционная программа 2019 года",

            Description = "В рамках инвестиционной программы 2019 года СПП \"Уголек\" ГП \"Донбасстеплоэнерго\""+
                        " выполнило ряд мероприятий по ремонту котельных. Котельная N 3 - замена котлов, монтаж"+
                        " системы водоочистки, установка дымовой трубы."

        },
    };

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
