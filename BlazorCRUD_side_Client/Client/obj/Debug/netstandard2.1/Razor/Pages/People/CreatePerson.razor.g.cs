#pragma checksum "C:\Users\edwin.diaz\source\repos\BlazorCRUD_side_Client\BlazorCRUD_side_Client\Client\Pages\People\CreatePerson.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8eef96fc3979985f27bc0a1615d40a1e02be4c9e"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorCRUD_side_Client.Client.Pages.People
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\edwin.diaz\source\repos\BlazorCRUD_side_Client\BlazorCRUD_side_Client\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\edwin.diaz\source\repos\BlazorCRUD_side_Client\BlazorCRUD_side_Client\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\edwin.diaz\source\repos\BlazorCRUD_side_Client\BlazorCRUD_side_Client\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\edwin.diaz\source\repos\BlazorCRUD_side_Client\BlazorCRUD_side_Client\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\edwin.diaz\source\repos\BlazorCRUD_side_Client\BlazorCRUD_side_Client\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\edwin.diaz\source\repos\BlazorCRUD_side_Client\BlazorCRUD_side_Client\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\edwin.diaz\source\repos\BlazorCRUD_side_Client\BlazorCRUD_side_Client\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\edwin.diaz\source\repos\BlazorCRUD_side_Client\BlazorCRUD_side_Client\Client\_Imports.razor"
using BlazorCRUD_side_Client.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\edwin.diaz\source\repos\BlazorCRUD_side_Client\BlazorCRUD_side_Client\Client\_Imports.razor"
using BlazorCRUD_side_Client.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\edwin.diaz\source\repos\BlazorCRUD_side_Client\BlazorCRUD_side_Client\Client\_Imports.razor"
using BlazorCRUD_side_Client.Shared.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Create-Person")]
    public partial class CreatePerson : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>CreatePerson</h3>\r\n");
            __builder.OpenComponent<BlazorCRUD_side_Client.Client.Pages.People.FormPerson>(1);
            __builder.AddAttribute(2, "TextoBoton", "Crear Persona");
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 6 "C:\Users\edwin.diaz\source\repos\BlazorCRUD_side_Client\BlazorCRUD_side_Client\Client\Pages\People\CreatePerson.razor"
                                                       CrearPersona

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "Person", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorCRUD_side_Client.Shared.Models.Person>(
#nullable restore
#line 6 "C:\Users\edwin.diaz\source\repos\BlazorCRUD_side_Client\BlazorCRUD_side_Client\Client\Pages\People\CreatePerson.razor"
                                                                              persona

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 7 "C:\Users\edwin.diaz\source\repos\BlazorCRUD_side_Client\BlazorCRUD_side_Client\Client\Pages\People\CreatePerson.razor"
       
    Person persona = new Person();
    //Para salvar la informaci??n
    public async Task CrearPersona()
    {
        await Http.PostAsJsonAsync("api/People", persona);
        Navigationmanager.NavigateTo("/Indice-personas");//Para navegar a que p??gina deseo ir
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigationmanager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
