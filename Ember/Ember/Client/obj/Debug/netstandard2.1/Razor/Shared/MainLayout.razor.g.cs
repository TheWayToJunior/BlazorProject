#pragma checksum "D:\С#\.NET Core\Ember\Ember\Client\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "245e1db942221779f348b44a4f2e2c3261c9da29"
// <auto-generated/>
#pragma warning disable 1591
namespace Ember.Client.Shared
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
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "main");
            __builder.AddMarkupContent(2, "\r\n\r\n        ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "intro");
            __builder.AddMarkupContent(5, "\r\n            <div class=\"filter\"></div>\r\n            ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "banner");
            __builder.AddMarkupContent(8, "\r\n                ");
            __builder.AddMarkupContent(9, "<a class=\"nav-header-link\">\r\n                    <i class=\"material-icons\">\r\n                        chevron_left\r\n                    </i>\r\n                </a>\r\n                ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "banner-content");
            __builder.AddMarkupContent(12, "\r\n                    ");
            __builder.AddMarkupContent(13, @"<div class=""banner-text"">
                        <h2>СПП Уголек <br> ГП <span>Донбасстепло<span>энерго</span></span></h2>
                        <p>
                            бренд с почти вековой историей. Сегодня это —
                            энергогенерирующая компания, в основе философии
                            которой лежит успешная интеграция инновационных
                            решений в традиционное производство.
                        </p>
                    </div>
                    ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "banner-buttom");
            __builder.AddMarkupContent(16, "\r\n                        ");
            __builder.AddMarkupContent(17, @"<a class=""btn-linck"" href=""#"">
                            <i class=""material-icons icon"">
                                supervisor_account
                            </i>
                            Личный кабинет
                        </a>

                        ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "scroll-indicator");
            __builder.AddAttribute(20, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "D:\С#\.NET Core\Ember\Ember\Client\Shared\MainLayout.razor"
                                                                () => JSRuntime.ScrollToElementId(indexs[0])

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(21, "\r\n                            <span></span>\r\n                            <span></span>\r\n                            <span></span>\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n\r\n                ");
            __builder.AddMarkupContent(25, "<a class=\"nav-header-link\">\r\n                   <i class=\"material-icons\">\r\n                       navigate_next\r\n                   </i>\r\n                </a>\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n\r\n        ");
            __builder.OpenElement(28, "header");
            __builder.AddAttribute(29, "id", "header");
            __builder.AddMarkupContent(30, "\r\n            ");
            __builder.OpenComponent<Ember.Client.Shared.NavMenu>(31);
            __builder.AddAttribute(32, "Image", "/img/Logo.png");
            __builder.AddAttribute(33, "CssClassImage", "logo-img");
            __builder.CloseComponent();
            __builder.AddMarkupContent(34, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n\r\n        ");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "body");
            __builder.AddAttribute(38, "id", "top");
            __builder.AddMarkupContent(39, "\r\n            ");
            __builder.AddContent(40, 
#nullable restore
#line 59 "D:\С#\.NET Core\Ember\Ember\Client\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(41, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n\r\n        ");
            __builder.AddMarkupContent(43, "<footer>\r\n            <h1>Footer</h1>\r\n        </footer>\r\n    ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 68 "D:\С#\.NET Core\Ember\Ember\Client\Shared\MainLayout.razor"
 
    string[] indexs = { "top" };

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
    }
}
#pragma warning restore 1591
