#pragma checksum "D:\С#\.NET Core\Ember\Ember\Client\Pages\About.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9ee399edf74e0aa882e495d633c8930bcbca0ef"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/about")]
    public partial class About : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Ember.Client.Shared.Main.Intro>(0);
            __builder.AddAttribute(1, "BodyId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 4 "D:\С#\.NET Core\Ember\Ember\Client\Pages\About.razor"
                 "body"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "ImgSource", "img/banner.jpg");
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n    ");
                __builder2.AddMarkupContent(5, @"<div class=""banner-text"">
        <h2>Наше Предприятие</h2>
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
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "body");
            __builder.AddAttribute(17, "id", "body");
            __builder.AddAttribute(18, "style", "padding-top: 0;");
            __builder.AddMarkupContent(19, "\r\n    ");
            __builder.OpenComponent<Ember.Client.Shared.Main.Structure>(20);
            __builder.AddAttribute(21, "Attributes", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.Dictionary<System.String, System.Object>>(
#nullable restore
#line 20 "D:\С#\.NET Core\Ember\Ember\Client\Pages\About.razor"
                           StructureStyleCss

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(22, "\r\n\r\n    ");
            __builder.OpenComponent<Ember.Client.Shared.Main.Components.ScrollLine>(23);
            __builder.AddAttribute(24, "ContentClassCss", "about-content");
            __builder.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(26, "\r\n");
#nullable restore
#line 23 "D:\С#\.NET Core\Ember\Ember\Client\Pages\About.razor"
         for (int i = 1; i < 7; i++)
        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(27, "            ");
                __builder2.OpenElement(28, "div");
                __builder2.AddAttribute(29, "class", "about-content__item");
                __builder2.AddMarkupContent(30, "\r\n                ");
                __builder2.AddMarkupContent(31, "<div class=\"dot\">\r\n                    <div class=\"dot-scroll\"></div>\r\n                </div>\r\n                ");
                __builder2.OpenElement(32, "div");
                __builder2.AddAttribute(33, "class", "about-content__info");
                __builder2.AddAttribute(34, "style", "flex-direction:" + " " + (
#nullable restore
#line 29 "D:\С#\.NET Core\Ember\Ember\Client\Pages\About.razor"
                                                                          i % 2 == 0 ? "row-reverse" : "row"

#line default
#line hidden
#nullable disable
                ) + ";");
                __builder2.AddMarkupContent(35, "\r\n                    ");
                __builder2.AddMarkupContent(36, "<div class=\"about-content__img\">\r\n                        <img src=\"https://upload.wikimedia.org/wikipedia/commons/thumb/2/2b/Черепетская_ГРЭС_2017.jpg/1200px-Черепетская_ГРЭС_2017.jpg\">\r\n                    </div>\r\n                    ");
                __builder2.AddMarkupContent(37, @"<div class=""about-content__text"">
                        <h2 class=""text-blue"">
                            СЕ ПАО «ДОНБАССЭНЕРГО» СЛАВЯНСКАЯ ТЭС
                        </h2>
                        <p>
                            Установленная мощность ТЭС – 2 010 МВт, в эксплуатации 9 энергоблоков,
                            станция работает в режиме маневрирования. В течение 2015-2016 годов в 
                            работе одновременно находится от 2 до 5 энергоблоков. В генерации задействованы
                            блоки с наиболее высокими показателями экономичности и экологичности, в том числе 
                            реконструированные в 2013-2014 годах №№ 12,13. На Старобешевской ТЭС продолжается 
                            работа по обеспечению участия модернизированных блоков во вторичном регулировании 
                            в рамках будущей синхронизации с европейской энергосистемой – «Донбассэнерго» выполняет 
                            взятые на себя обязательства перед государством и международными партнерами.
                        </p>
                    </div>
                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n");
#nullable restore
#line 50 "D:\С#\.NET Core\Ember\Ember\Client\Pages\About.razor"
        }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(40, "    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(41, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 54 "D:\С#\.NET Core\Ember\Ember\Client\Pages\About.razor"
       
    private Dictionary<string, object> StructureStyleCss =
        new Dictionary<string, object>()
        {
            { "style", "background-color:#fff;" }
        };

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
