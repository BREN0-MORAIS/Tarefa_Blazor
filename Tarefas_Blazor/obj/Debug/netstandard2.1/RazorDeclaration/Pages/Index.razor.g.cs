// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Tarefas_Blazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\_DESENVOLVIMENTO\CODIGO FONTE\Tarefa_Blazor\Tarefas_Blazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\_DESENVOLVIMENTO\CODIGO FONTE\Tarefa_Blazor\Tarefas_Blazor\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\_DESENVOLVIMENTO\CODIGO FONTE\Tarefa_Blazor\Tarefas_Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\_DESENVOLVIMENTO\CODIGO FONTE\Tarefa_Blazor\Tarefas_Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\_DESENVOLVIMENTO\CODIGO FONTE\Tarefa_Blazor\Tarefas_Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\_DESENVOLVIMENTO\CODIGO FONTE\Tarefa_Blazor\Tarefas_Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\_DESENVOLVIMENTO\CODIGO FONTE\Tarefa_Blazor\Tarefas_Blazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\_DESENVOLVIMENTO\CODIGO FONTE\Tarefa_Blazor\Tarefas_Blazor\_Imports.razor"
using Tarefas_Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\_DESENVOLVIMENTO\CODIGO FONTE\Tarefa_Blazor\Tarefas_Blazor\_Imports.razor"
using Tarefas_Blazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\_DESENVOLVIMENTO\CODIGO FONTE\Tarefa_Blazor\Tarefas_Blazor\_Imports.razor"
using Tarefas_Blazor.Entidades;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "D:\_DESENVOLVIMENTO\CODIGO FONTE\Tarefa_Blazor\Tarefas_Blazor\Pages\Index.razor"
      
    List<Tarefa> tarefas = new List<Tarefa>();
    protected override async Task OnInitializedAsync()
    {
        tarefas = await http.GetFromJsonAsync<List<Tarefa>>("Dados/tarefas.json");
    }

    private List<Tarefa> GetTarefas(){
        return tarefas;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
