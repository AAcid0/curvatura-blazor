#pragma checksum "C:\Users\JUAN\source\repos\BlazorApp1\BlazorApp1\Client\Pages\Peliculas\FormularioPeliculas.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cfc286e5cab557c65fc784f4014b25412e2c3d9d"
// <auto-generated/>
#pragma warning disable 1591
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
    public partial class FormularioPeliculas : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 1 "C:\Users\JUAN\source\repos\BlazorApp1\BlazorApp1\Client\Pages\Peliculas\FormularioPeliculas.razor"
                 pelicula

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 1 "C:\Users\JUAN\source\repos\BlazorApp1\BlazorApp1\Client\Pages\Peliculas\FormularioPeliculas.razor"
                                          OnValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(4);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "form-group");
                __builder2.AddMarkupContent(8, "<label><b>Titulo</b></label>\r\n        ");
                __builder2.OpenElement(9, "div");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(10);
                __builder2.AddAttribute(11, "class", "form-control");
                __builder2.AddAttribute(12, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 6 "C:\Users\JUAN\source\repos\BlazorApp1\BlazorApp1\Client\Pages\Peliculas\FormularioPeliculas.razor"
                                                          pelicula.Titulo

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => pelicula.Titulo = __value, pelicula.Titulo))));
                __builder2.AddAttribute(14, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => pelicula.Titulo));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\r\n            ");
                __Blazor.BlazorApp1.Client.Pages.Peliculas.FormularioPeliculas.TypeInference.CreateValidationMessage_0(__builder2, 16, 17, 
#nullable restore
#line 7 "C:\Users\JUAN\source\repos\BlazorApp1\BlazorApp1\Client\Pages\Peliculas\FormularioPeliculas.razor"
                                    (() => pelicula.Titulo)

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(18, "\r\n    ");
                __builder2.OpenElement(19, "div");
                __builder2.AddAttribute(20, "class", "form-group");
                __builder2.AddMarkupContent(21, "<label><b>En Cartelera</b></label>\r\n        ");
                __builder2.OpenElement(22, "div");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(23);
                __builder2.AddAttribute(24, "class", "form-control");
                __builder2.AddAttribute(25, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 13 "C:\Users\JUAN\source\repos\BlazorApp1\BlazorApp1\Client\Pages\Peliculas\FormularioPeliculas.razor"
                                                              pelicula.EnCartelera

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => pelicula.EnCartelera = __value, pelicula.EnCartelera))));
                __builder2.AddAttribute(27, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => pelicula.EnCartelera));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(28, "\r\n            ");
                __Blazor.BlazorApp1.Client.Pages.Peliculas.FormularioPeliculas.TypeInference.CreateValidationMessage_1(__builder2, 29, 30, 
#nullable restore
#line 14 "C:\Users\JUAN\source\repos\BlazorApp1\BlazorApp1\Client\Pages\Peliculas\FormularioPeliculas.razor"
                                    (() => pelicula.EnCartelera)

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n    ");
                __builder2.OpenElement(32, "div");
                __builder2.AddAttribute(33, "class", "form-group");
                __builder2.AddMarkupContent(34, "<label><b>Trailer</b></label>\r\n        ");
                __builder2.OpenElement(35, "div");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(36);
                __builder2.AddAttribute(37, "class", "form-control");
                __builder2.AddAttribute(38, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "C:\Users\JUAN\source\repos\BlazorApp1\BlazorApp1\Client\Pages\Peliculas\FormularioPeliculas.razor"
                                                          pelicula.Titulo

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(39, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => pelicula.Titulo = __value, pelicula.Titulo))));
                __builder2.AddAttribute(40, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => pelicula.Titulo));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(41, "\r\n            ");
                __Blazor.BlazorApp1.Client.Pages.Peliculas.FormularioPeliculas.TypeInference.CreateValidationMessage_2(__builder2, 42, 43, 
#nullable restore
#line 21 "C:\Users\JUAN\source\repos\BlazorApp1\BlazorApp1\Client\Pages\Peliculas\FormularioPeliculas.razor"
                                    (() => pelicula.Titulo)

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n    ");
                __builder2.OpenElement(45, "div");
                __builder2.AddAttribute(46, "class", "form-group");
                __builder2.AddMarkupContent(47, "<label><b>Fecha Lanzamiento</b></label>\r\n        ");
                __builder2.OpenElement(48, "div");
                __Blazor.BlazorApp1.Client.Pages.Peliculas.FormularioPeliculas.TypeInference.CreateInputDate_3(__builder2, 49, 50, "form-control", 51, 
#nullable restore
#line 27 "C:\Users\JUAN\source\repos\BlazorApp1\BlazorApp1\Client\Pages\Peliculas\FormularioPeliculas.razor"
                                                          pelicula.Lanzamiento

#line default
#line hidden
#nullable disable
                , 52, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => pelicula.Lanzamiento = __value, pelicula.Lanzamiento)), 53, () => pelicula.Lanzamiento);
                __builder2.AddMarkupContent(54, "\r\n            ");
                __Blazor.BlazorApp1.Client.Pages.Peliculas.FormularioPeliculas.TypeInference.CreateValidationMessage_4(__builder2, 55, 56, 
#nullable restore
#line 28 "C:\Users\JUAN\source\repos\BlazorApp1\BlazorApp1\Client\Pages\Peliculas\FormularioPeliculas.razor"
                                    (() => pelicula.Lanzamiento)

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(57, "\r\n     ");
                __builder2.OpenElement(58, "div");
                __builder2.AddAttribute(59, "class", "form-group");
                __builder2.OpenComponent<BlazorApp1.Client.Shared.InputImg>(60);
                __builder2.AddAttribute(61, "label", "Foto");
                __builder2.AddAttribute(62, "ImagenSeleccionada", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 32 "C:\Users\JUAN\source\repos\BlazorApp1\BlazorApp1\Client\Pages\Peliculas\FormularioPeliculas.razor"
                                                   imagenSeleccionada

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(63, "ImagenUrl", "");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(64, "\r\n     ");
                __builder2.OpenElement(65, "div");
                __builder2.AddAttribute(66, "class", "form-group");
                __builder2.AddMarkupContent(67, "<label><a>Género</a></label>\r\n         ");
                __builder2.OpenComponent<BlazorApp1.Client.Shared.SelectorMultiple>(68);
                __builder2.AddAttribute(69, "seleccionados", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<BlazorApp1.Client.Helpers.SelectorMultipleModal>>(
#nullable restore
#line 36 "C:\Users\JUAN\source\repos\BlazorApp1\BlazorApp1\Client\Pages\Peliculas\FormularioPeliculas.razor"
                                          Seleccionados

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(70, "noSeleccionados", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<BlazorApp1.Client.Helpers.SelectorMultipleModal>>(
#nullable restore
#line 36 "C:\Users\JUAN\source\repos\BlazorApp1\BlazorApp1\Client\Pages\Peliculas\FormularioPeliculas.razor"
                                                                          NoSeleccionados

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(71, "\r\n     ");
                __builder2.OpenElement(72, "div");
                __builder2.AddAttribute(73, "class", "form-group");
                __builder2.AddMarkupContent(74, "<label><a>Actores</a></label>\r\n         ");
                __builder2.OpenElement(75, "div");
                __Blazor.BlazorApp1.Client.Pages.Peliculas.FormularioPeliculas.TypeInference.CreateSelectorMultipleTypeAHead_5(__builder2, 76, 77, 
#nullable restore
#line 42 "C:\Users\JUAN\source\repos\BlazorApp1\BlazorApp1\Client\Pages\Peliculas\FormularioPeliculas.razor"
                              BuscarActores

#line default
#line hidden
#nullable disable
                , 78, 
#nullable restore
#line 43 "C:\Users\JUAN\source\repos\BlazorApp1\BlazorApp1\Client\Pages\Peliculas\FormularioPeliculas.razor"
                                        ActoresSeleccionados

#line default
#line hidden
#nullable disable
                , 79, (persona) => (__builder3) => {
#nullable restore
#line 45 "C:\Users\JUAN\source\repos\BlazorApp1\BlazorApp1\Client\Pages\Peliculas\FormularioPeliculas.razor"
__builder3.AddContent(80, persona.Nombre);

#line default
#line hidden
#nullable disable
                }
                , 81, (persona) => (__builder3) => {
                    __builder3.OpenElement(82, "img");
                    __builder3.AddAttribute(83, "style", "width: 50px");
                    __builder3.AddAttribute(84, "src", 
#nullable restore
#line 48 "C:\Users\JUAN\source\repos\BlazorApp1\BlazorApp1\Client\Pages\Peliculas\FormularioPeliculas.razor"
                                                       persona.Foto

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(85, "\r\n                        ");
#nullable restore
#line 49 "C:\Users\JUAN\source\repos\BlazorApp1\BlazorApp1\Client\Pages\Peliculas\FormularioPeliculas.razor"
__builder3.AddContent(86, persona.Nombre);

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(87, "\r\n     ");
                __builder2.AddMarkupContent(88, "<button class=\"btn btn-success\">Guardar Cambios</button>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 57 "C:\Users\JUAN\source\repos\BlazorApp1\BlazorApp1\Client\Pages\Peliculas\FormularioPeliculas.razor"
       
    [Parameter] public Pelicula pelicula { get; set; }
    [Parameter] public EventCallback OnValidSubmit { get; set; }
    [Parameter] public List<Genero> GenerosSeleccionados { get; set; } = new List<Genero>();
    [Parameter] public List<Genero> GenerosNOSeleccionados { get; set; } = new List<Genero>();
    [Parameter] public List<Persona> ActoresSeleccionados { get; set; } = new List<Persona>();

    private List<SelectorMultipleModal> Seleccionados { get; set; } = new List<SelectorMultipleModal>();
    private List<SelectorMultipleModal> NoSeleccionados { get; set; } = new List<SelectorMultipleModal>();
    private string posterTemp;

    protected override void OnInitialized()
    {
        Seleccionados = GenerosSeleccionados.Select(x => new SelectorMultipleModal(x.Id.ToString(), x.Nombre)).ToList();
        NoSeleccionados = GenerosNOSeleccionados.Select(x => new SelectorMultipleModal(x.Id.ToString(), x.Nombre)).ToList();
        //Para que funcione el importador de archivos
        if (!string.IsNullOrWhiteSpace(pelicula.UrlPoster))
        {
            posterTemp = pelicula.UrlPoster;
            pelicula.UrlPoster = null;
        }
    }

    protected void imagenSeleccionada(string base64)
    {
        pelicula.UrlPoster = base64;
    }
    private async Task<IEnumerable<Persona>> BuscarActores(string searchText)
    {
        return new List<Persona>()
        {
            new Persona(){Id=1, Nombre="Tom Holland", Foto = "https://m.media-amazon.com/images/M/MV5BNTAzMzA3NjQwOF5BMl5BanBnXkFtZTgwMDUzODQ5MTI@._V1_UY317_CR23,0,214,317_AL_.jpg"},
            new Persona(){Id=2, Nombre="Tom Hanks", Foto = "https://m.media-amazon.com/images/M/MV5BMTQ2MjMwNDA3Nl5BMl5BanBnXkFtZTcwMTA2NDY3NQ@@._V1_UY317_CR2,0,214,317_AL_.jpg"}
        };
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.BlazorApp1.Client.Pages.Peliculas.FormularioPeliculas
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateSelectorMultipleTypeAHead_5<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Func<global::System.String, global::System.Threading.Tasks.Task<global::System.Collections.Generic.IEnumerable<T>>> __arg0, int __seq1, global::System.Collections.Generic.List<T> __arg1, int __seq2, global::Microsoft.AspNetCore.Components.RenderFragment<T> __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment<T> __arg3)
        {
        __builder.OpenComponent<global::BlazorApp1.Client.Shared.SelectorMultipleTypeAHead<T>>(seq);
        __builder.AddAttribute(__seq0, "SearchMethod", __arg0);
        __builder.AddAttribute(__seq1, "ElementosSeleccionados", __arg1);
        __builder.AddAttribute(__seq2, "MyListTemplate", __arg2);
        __builder.AddAttribute(__seq3, "MyResultTemplate", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591