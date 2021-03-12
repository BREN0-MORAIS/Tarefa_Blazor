#pragma checksum "D:\_DESENVOLVIMENTO\CODIGO FONTE\Blazor_Tarefa\Tarefas_Blazor\Tarefas_Blazor\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "82cbd45f0fb17b564871f6d3dc4c3bd6afa34d65"
// <auto-generated/>
#pragma warning disable 1591
namespace Tarefas_Blazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\_DESENVOLVIMENTO\CODIGO FONTE\Blazor_Tarefa\Tarefas_Blazor\Tarefas_Blazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\_DESENVOLVIMENTO\CODIGO FONTE\Blazor_Tarefa\Tarefas_Blazor\Tarefas_Blazor\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\_DESENVOLVIMENTO\CODIGO FONTE\Blazor_Tarefa\Tarefas_Blazor\Tarefas_Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\_DESENVOLVIMENTO\CODIGO FONTE\Blazor_Tarefa\Tarefas_Blazor\Tarefas_Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\_DESENVOLVIMENTO\CODIGO FONTE\Blazor_Tarefa\Tarefas_Blazor\Tarefas_Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\_DESENVOLVIMENTO\CODIGO FONTE\Blazor_Tarefa\Tarefas_Blazor\Tarefas_Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\_DESENVOLVIMENTO\CODIGO FONTE\Blazor_Tarefa\Tarefas_Blazor\Tarefas_Blazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\_DESENVOLVIMENTO\CODIGO FONTE\Blazor_Tarefa\Tarefas_Blazor\Tarefas_Blazor\_Imports.razor"
using Tarefas_Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\_DESENVOLVIMENTO\CODIGO FONTE\Blazor_Tarefa\Tarefas_Blazor\Tarefas_Blazor\_Imports.razor"
using Tarefas_Blazor.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 5 "D:\_DESENVOLVIMENTO\CODIGO FONTE\Blazor_Tarefa\Tarefas_Blazor\Tarefas_Blazor\Pages\Index.razor"
 if (tarefas == null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Tarefas_Blazor.Shared.AlertComponent>(0);
            __builder.AddAttribute(1, "Menssagem", "Ainda Não tem tarefas");
            __builder.CloseComponent();
#nullable restore
#line 8 "D:\_DESENVOLVIMENTO\CODIGO FONTE\Blazor_Tarefa\Tarefas_Blazor\Tarefas_Blazor\Pages\Index.razor"
}
else if (!tarefas.Any())
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Tarefas_Blazor.Shared.AlertComponent>(2);
            __builder.AddAttribute(3, "Menssagem", "Carregando...................");
            __builder.CloseComponent();
#nullable restore
#line 12 "D:\_DESENVOLVIMENTO\CODIGO FONTE\Blazor_Tarefa\Tarefas_Blazor\Tarefas_Blazor\Pages\Index.razor"
}
else
{
    foreach (var item in tarefas)
    {


#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "table");
            __builder.AddAttribute(5, "class", "table");
            __builder.AddMarkupContent(6, "<thead><tr><th>Ação</th>\r\n                    <th scope=\"col\">ID</th>\r\n                    <th scope=\"col\">Descrição</th>\r\n                    <th scope=\"col\">Concluido</th>\r\n                    <th scope=\"col\">DataCriação</th></tr></thead>\r\n            ");
            __builder.OpenElement(7, "tbody");
            __builder.OpenElement(8, "tr");
            __builder.OpenElement(9, "td");
            __builder.OpenElement(10, "button");
            __builder.AddAttribute(11, "class", "btn btn-danger");
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "D:\_DESENVOLVIMENTO\CODIGO FONTE\Blazor_Tarefa\Tarefas_Blazor\Tarefas_Blazor\Pages\Index.razor"
                                                                 (() => RemoverTarefa(item.ID))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(13, "EXCLUIR");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n                    ");
            __builder.OpenElement(15, "td");
            __builder.AddContent(16, 
#nullable restore
#line 31 "D:\_DESENVOLVIMENTO\CODIGO FONTE\Blazor_Tarefa\Tarefas_Blazor\Tarefas_Blazor\Pages\Index.razor"
                         item.ID

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                    ");
            __builder.OpenElement(18, "td");
            __builder.AddContent(19, 
#nullable restore
#line 32 "D:\_DESENVOLVIMENTO\CODIGO FONTE\Blazor_Tarefa\Tarefas_Blazor\Tarefas_Blazor\Pages\Index.razor"
                         item.Descricao

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                    ");
            __builder.OpenElement(21, "td");
            __builder.OpenElement(22, "input");
            __builder.AddAttribute(23, "type", "checkbox");
            __builder.AddAttribute(24, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 33 "D:\_DESENVOLVIMENTO\CODIGO FONTE\Blazor_Tarefa\Tarefas_Blazor\Tarefas_Blazor\Pages\Index.razor"
                                                       item.Concluido

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => item.Concluido = __value, item.Concluido));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddContent(26, 
#nullable restore
#line 33 "D:\_DESENVOLVIMENTO\CODIGO FONTE\Blazor_Tarefa\Tarefas_Blazor\Tarefas_Blazor\Pages\Index.razor"
                                                                          item.Concluido

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                    ");
            __builder.OpenElement(28, "td");
            __builder.AddContent(29, 
#nullable restore
#line 34 "D:\_DESENVOLVIMENTO\CODIGO FONTE\Blazor_Tarefa\Tarefas_Blazor\Tarefas_Blazor\Pages\Index.razor"
                         item.DataCriacao

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 38 "D:\_DESENVOLVIMENTO\CODIGO FONTE\Blazor_Tarefa\Tarefas_Blazor\Tarefas_Blazor\Pages\Index.razor"
    }






    

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "D:\_DESENVOLVIMENTO\CODIGO FONTE\Blazor_Tarefa\Tarefas_Blazor\Tarefas_Blazor\Pages\Index.razor"
     if (tarefas != null)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "form-group");
            __builder.AddMarkupContent(32, "<label>Tarefa</label>\r\n            ");
            __builder.OpenElement(33, "input");
            __builder.AddAttribute(34, "type", "text");
            __builder.AddAttribute(35, "placeholder", "Informe a Tarfefa");
            __builder.AddAttribute(36, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 49 "D:\_DESENVOLVIMENTO\CODIGO FONTE\Blazor_Tarefa\Tarefas_Blazor\Tarefas_Blazor\Pages\Index.razor"
                                                                      novaTarefa

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(37, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => novaTarefa = __value, novaTarefa));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n            ");
            __builder.OpenElement(39, "button");
            __builder.AddAttribute(40, "class", "btn btn-primary");
            __builder.AddAttribute(41, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 50 "D:\_DESENVOLVIMENTO\CODIGO FONTE\Blazor_Tarefa\Tarefas_Blazor\Tarefas_Blazor\Pages\Index.razor"
                                                      AdicionarNovaTarefa

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(42, "Regitrar Tarfea");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 52 "D:\_DESENVOLVIMENTO\CODIGO FONTE\Blazor_Tarefa\Tarefas_Blazor\Tarefas_Blazor\Pages\Index.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "D:\_DESENVOLVIMENTO\CODIGO FONTE\Blazor_Tarefa\Tarefas_Blazor\Tarefas_Blazor\Pages\Index.razor"
     
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 54 "D:\_DESENVOLVIMENTO\CODIGO FONTE\Blazor_Tarefa\Tarefas_Blazor\Tarefas_Blazor\Pages\Index.razor"
      

    public class Tarefa
    {
        public Guid ID { get; set; }
        public string Descricao { get; set; }
        public bool Concluido { get; set; }
        public DateTime DataCriacao { get; set; }

    }
    private string novaTarefa = "";
    public void AdicionarNovaTarefa()
    {


        tarefas.Add(new Tarefa
        {
            DataCriacao = DateTime.Now,
            Descricao = novaTarefa,
            ID = Guid.NewGuid()

        });
    }
    private List<Tarefa> tarefas = new List<Tarefa>();
    private Tarefa tarefa = new Tarefa();

    public void RemoverTarefa(Guid id)
    {
        tarefas.Remove(tarefas.First(a => a.ID == id));
    }




    protected override async Task OnInitializedAsync()
    {
        tarefas = await http.GetFromJsonAsync<List<Tarefa>>("Dados/tarefas.json");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591