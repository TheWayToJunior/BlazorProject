#pragma checksum "D:\С#\.NET Core\Ember\Ember\Client\Shared\Category.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa7efb39dc8b269370a6640080e3aa0337cbb4ab"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#nullable restore
#line 11 "D:\С#\.NET Core\Ember\Ember\Client\_Imports.razor"
using BlazorComponentUtilities;

#line default
#line hidden
#nullable disable
    public partial class Category : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "D:\С#\.NET Core\Ember\Ember\Client\Shared\Category.razor"
       
    [Parameter]
    public CategoryMode CurrentCategory { get; set; }

    [Parameter]
    public IEnumerable<(string, CategoryMode)> Lincks { get; set; }

    [Parameter]
    public EventCallback<CategoryMode> SelectedLinck { get; set; }

    List<LinkModel> links;

    protected override void OnParametersSet()
    {
        LoadPages();
    }

    private async Task SelectedLinckInternal(LinkModel link)
    {
        if (link.Active)
        {
            return;
        }

        Console.WriteLine(link.Category);

        await SelectedLinck.InvokeAsync(link.Category);
    }

    private void LoadPages()
    {
        links = new List<LinkModel>();

        foreach (var linck in Lincks)
        {
            links.Add(new LinkModel(linck.Item1) { Category = linck.Item2,  Active = CurrentCategory == linck.Item2});
        }
    }

    class LinkModel
    {

        public LinkModel(string text)
        {
            Text = text;
        }

        public string Text { get; set; }

        public CategoryMode Category{ get; set; }

        public bool Active { get; set; } = false;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591