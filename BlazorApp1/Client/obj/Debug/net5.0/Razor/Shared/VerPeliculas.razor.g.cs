#pragma checksum "C:\Users\JUAN\source\repos\BlazorApp1\BlazorApp1\Client\Shared\VerPeliculas.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f5a2d59677848d41d5d2148aa14cae6fd94a06c"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp1.Client.Shared
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
    public partial class VerPeliculas : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __Blazor.BlazorApp1.Client.Shared.VerPeliculas.TypeInference.CreateListaGenerica_0(__builder, 0, 1, 
#nullable restore
#line 3 "C:\Users\JUAN\source\repos\BlazorApp1\BlazorApp1\Client\Shared\VerPeliculas.razor"
                        listaPeliculas

#line default
#line hidden
#nullable disable
            , 2, (context) => (__builder2) => {
                __builder2.OpenComponent<BlazorApp1.Client.Shared.PeliculaIndividual>(3);
                __builder2.AddAttribute(4, "peli", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorApp1.Shared.Entidades.Pelicula>(
#nullable restore
#line 5 "C:\Users\JUAN\source\repos\BlazorApp1\BlazorApp1\Client\Shared\VerPeliculas.razor"
                                  context

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(5, "mostrarBotones", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 5 "C:\Users\JUAN\source\repos\BlazorApp1\BlazorApp1\Client\Shared\VerPeliculas.razor"
                                                           mostrarBotones

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(6, "eliminarPeli", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<BlazorApp1.Shared.Entidades.Pelicula>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<BlazorApp1.Shared.Entidades.Pelicula>(this, 
#nullable restore
#line 5 "C:\Users\JUAN\source\repos\BlazorApp1\BlazorApp1\Client\Shared\VerPeliculas.razor"
                                                                                         eliminarPeli

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
            }
            );
            __builder.AddMarkupContent(7, "\r\n\r\n");
            __builder.OpenComponent<BlazorApp1.Client.Shared.Confirmacion>(8);
            __builder.AddAttribute(9, "onConfirm", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 9 "C:\Users\JUAN\source\repos\BlazorApp1\BlazorApp1\Client\Shared\VerPeliculas.razor"
                                             confirmacionEliminado

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(10, "onCancel", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 9 "C:\Users\JUAN\source\repos\BlazorApp1\BlazorApp1\Client\Shared\VerPeliculas.razor"
                                                                              cancelarEliminado

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(12, "<h2>¿Desea Eliminar?</h2>");
            }
            ));
            __builder.AddComponentReferenceCapture(13, (__value) => {
#nullable restore
#line 9 "C:\Users\JUAN\source\repos\BlazorApp1\BlazorApp1\Client\Shared\VerPeliculas.razor"
                    confirmacion = (BlazorApp1.Client.Shared.Confirmacion)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "C:\Users\JUAN\source\repos\BlazorApp1\BlazorApp1\Client\Shared\VerPeliculas.razor"
       
    Confirmacion confirmacion;

    //public List<Pelicula> listaPelis; Para pasar las pelis por parametro se hace lo de la sgt linea
    [Parameter] public List<Pelicula> listaPeliculas { get; set; }  //PARAMETRO


    bool mostrarBotones = false;
    Pelicula peliABorrar;
    async Task eliminarPeli(Pelicula pelicula)
    {
        confirmacion.Mostrar();
        peliABorrar = pelicula;
        //EEJEMPLO DE INVOCACION DE FUNCIÓN JAVASCRIPT
        //var conf = await js.InvokeAsync<bool>("confirm", $"¿Desea eliminar {pelicula.Titulo}?");
        //if (conf)
        //{
        //    listaPeliculas.Remove(pelicula);
        //    Console.WriteLine($"Se ha eliminado {pelicula.Titulo}");
        //}
        //else
        //{
        //    Console.WriteLine("Se ha cancelado la acción");
        //}

    }
    void confirmacionEliminado()
    {
        listaPeliculas.Remove(peliABorrar);
        confirmacion.Ocultar();
        peliABorrar = null;
    }

    void cancelarEliminado()
    {
        confirmacion.Ocultar();    
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
    }
}
namespace __Blazor.BlazorApp1.Client.Shared.VerPeliculas
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateListaGenerica_0<Titem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.List<Titem> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment<Titem> __arg1)
        {
        __builder.OpenComponent<global::BlazorApp1.Client.Shared.ListaGenerica<Titem>>(seq);
        __builder.AddAttribute(__seq0, "Listado", __arg0);
        __builder.AddAttribute(__seq1, "conRegistros", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591