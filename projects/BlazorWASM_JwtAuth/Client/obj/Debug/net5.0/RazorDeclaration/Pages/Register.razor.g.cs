// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorWASM_JwtAuth.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Ashton\OneDrive - Nebula\JupyterNotebooks\C#\blazor-study-notebooks\projects\BlazorWASM_JwtAuth\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ashton\OneDrive - Nebula\JupyterNotebooks\C#\blazor-study-notebooks\projects\BlazorWASM_JwtAuth\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ashton\OneDrive - Nebula\JupyterNotebooks\C#\blazor-study-notebooks\projects\BlazorWASM_JwtAuth\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Ashton\OneDrive - Nebula\JupyterNotebooks\C#\blazor-study-notebooks\projects\BlazorWASM_JwtAuth\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Ashton\OneDrive - Nebula\JupyterNotebooks\C#\blazor-study-notebooks\projects\BlazorWASM_JwtAuth\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Ashton\OneDrive - Nebula\JupyterNotebooks\C#\blazor-study-notebooks\projects\BlazorWASM_JwtAuth\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Ashton\OneDrive - Nebula\JupyterNotebooks\C#\blazor-study-notebooks\projects\BlazorWASM_JwtAuth\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Ashton\OneDrive - Nebula\JupyterNotebooks\C#\blazor-study-notebooks\projects\BlazorWASM_JwtAuth\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Ashton\OneDrive - Nebula\JupyterNotebooks\C#\blazor-study-notebooks\projects\BlazorWASM_JwtAuth\Client\_Imports.razor"
using BlazorWASM_JwtAuth.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Ashton\OneDrive - Nebula\JupyterNotebooks\C#\blazor-study-notebooks\projects\BlazorWASM_JwtAuth\Client\_Imports.razor"
using BlazorWASM_JwtAuth.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ashton\OneDrive - Nebula\JupyterNotebooks\C#\blazor-study-notebooks\projects\BlazorWASM_JwtAuth\Client\Pages\Register.razor"
using BlazorWASM_JwtAuth.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/register")]
    public partial class Register : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "C:\Users\Ashton\OneDrive - Nebula\JupyterNotebooks\C#\blazor-study-notebooks\projects\BlazorWASM_JwtAuth\Client\Pages\Register.razor"
       
	RegisterModel reg = new RegisterModel();
	string message = string.Empty, login = string.Empty;
	bool isDisabled = false;

	private async Task OnValid()
	{
		isDisabled = true;
		using (var msg = await Http.PostAsJsonAsync<RegisterModel>("/api/auth/register", reg, System.Threading.CancellationToken.None))
		{
			if (msg.IsSuccessStatusCode)
			{
				LoginResult result = await msg.Content.ReadFromJsonAsync<LoginResult>();
				message = result.Message;
				if (result.Success)
				{
					message += " Please LOGIN to continue.";
					login = "Click here to LOGIN.";
				}
				else
					isDisabled = false;
			}
		}
	}

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
