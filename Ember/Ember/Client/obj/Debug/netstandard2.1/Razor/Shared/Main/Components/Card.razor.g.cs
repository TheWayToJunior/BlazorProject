#pragma checksum "D:\С#\.NET Core\Ember\Ember\Client\Shared\Main\Components\Card.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70f35b86dfb9487d73af01a60d3517dd5a6babb0"
// <auto-generated/>
#pragma warning disable 1591
namespace Ember.Client.Shared.Main.Components
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
    public partial class Card : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "col-sm-4");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "card news-card");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "news-card-img");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.OpenElement(9, "img");
            __builder.AddAttribute(10, "class", "img-responsive");
            __builder.AddAttribute(11, "src", 
#nullable restore
#line 6 "D:\С#\.NET Core\Ember\Ember\Client\Shared\Main\Components\Card.razor"
                                              ImageSrc

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n        ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "news-content");
            __builder.AddMarkupContent(16, "\r\n            ");
            __builder.AddMarkupContent(17, "<span class=\"news-lable\">News</span>\r\n            ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "news-meta");
            __builder.AddMarkupContent(20, "\r\n                ");
            __builder.OpenElement(21, "span");
            __builder.AddAttribute(22, "class", "time");
            __builder.AddMarkupContent(23, "\r\n                    ");
            __builder.OpenElement(24, "a");
            __builder.AddAttribute(25, "href", "#");
            __builder.AddMarkupContent(26, "\r\n                        ");
            __builder.AddMarkupContent(27, "<i class=\"material-icons\">\r\n                            query_builder\r\n                        </i>\r\n                        ");
            __builder.AddContent(28, 
#nullable restore
#line 16 "D:\С#\.NET Core\Ember\Ember\Client\Shared\Main\Components\Card.razor"
                         Date.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(29, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                    ");
            __builder.OpenElement(31, "a");
            __builder.AddAttribute(32, "href", 
#nullable restore
#line 18 "D:\С#\.NET Core\Ember\Ember\Client\Shared\Main\Components\Card.razor"
                              Source

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(33, "Подробнее");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n            ");
            __builder.OpenElement(37, "h2");
            __builder.AddAttribute(38, "class", "news-header");
            __builder.AddContent(39, 
#nullable restore
#line 21 "D:\С#\.NET Core\Ember\Ember\Client\Shared\Main\Components\Card.razor"
                                     Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n            ");
            __builder.OpenElement(41, "p");
            __builder.AddMarkupContent(42, "\r\n                ");
            __builder.AddContent(43, 
#nullable restore
#line 23 "D:\С#\.NET Core\Ember\Ember\Client\Shared\Main\Components\Card.razor"
                 ChildContent

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(44, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "D:\С#\.NET Core\Ember\Ember\Client\Shared\Main\Components\Card.razor"
       
    public int Id { get; set; }

    [Parameter]
    public string Title { get; set; }

    [Parameter]
    public string ImageSrc { get; set; }

    [Parameter]
    public string Source { get; set; }

    [Parameter]
    public DateTime Date { get; set; }

    [Parameter]
    public RenderFragment ChildContent { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
