#pragma checksum "C:\Users\JUAN\source\repos\BlazorApp1\BlazorApp1\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be5207625458cb9cd7defea24226fdff5a910eca"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp1.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\JUAN\source\repos\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\JUAN\source\repos\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\JUAN\source\repos\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\JUAN\source\repos\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\JUAN\source\repos\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\JUAN\source\repos\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\JUAN\source\repos\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\JUAN\source\repos\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\JUAN\source\repos\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using BlazorApp1.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\JUAN\source\repos\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using BlazorApp1.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\JUAN\source\repos\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using BlazorApp1.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\JUAN\source\repos\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using BlazorApp1.Shared.Entidades;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\JUAN\source\repos\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using BlazorApp1.Client.Repositorios;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.OpenElement(1, "h1");
            __builder.AddContent(2, "Hello, ");
#nullable restore
#line 4 "C:\Users\JUAN\source\repos\BlazorApp1\BlazorApp1\Client\Pages\Index.razor"
__builder.AddContent(3, stringOpc.toMayus("Peliculas"));

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenComponent<BlazorApp1.Client.Shared.VerPeliculas>(5);
            __builder.AddAttribute(6, "listaPeliculas", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<BlazorApp1.Shared.Entidades.Pelicula>>(
#nullable restore
#line 5 "C:\Users\JUAN\source\repos\BlazorApp1\BlazorApp1\Client\Pages\Index.razor"
                                  Peliculas

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "C:\Users\JUAN\source\repos\BlazorApp1\BlazorApp1\Client\Pages\Index.razor"
      

    private List<Pelicula> Peliculas;
    protected override void OnInitialized()
    {
        Peliculas = repo.ObtenerPeliculas();
    }

    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRepositorio repo { get; set; }
    }
}
#pragma warning restore 1591
