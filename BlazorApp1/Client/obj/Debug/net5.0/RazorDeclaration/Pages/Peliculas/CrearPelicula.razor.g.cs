// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorApp1.Client.Pages.Peliculas
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/peliculas/crear")]
    public partial class CrearPelicula : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "C:\Users\JUAN\source\repos\BlazorApp1\BlazorApp1\Client\Pages\Peliculas\CrearPelicula.razor"
       
    private Pelicula pelicula = new Pelicula();
    private List<Genero> GenerosNOSeleccionados = new List<Genero>();

    protected override void OnInitialized()
    {
        GenerosNOSeleccionados = new List<Genero>()
        {
            new Genero(){Id = 1, Nombre="Comedia"},
            new Genero(){Id = 2, Nombre="Acci??n"},
            new Genero(){Id = 3, Nombre="Drama"},
            new Genero(){Id = 4, Nombre="Terror"},
            new Genero(){Id = 4, Nombre="Ciencia Ficci??n"}
        };
    }

    void Crear()
    {
        Console.WriteLine("Pelicual creada");
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
