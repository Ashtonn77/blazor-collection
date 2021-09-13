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
#line 2 "C:\Users\Ashton\OneDrive - Nebula\JupyterNotebooks\C#\blazor-study-notebooks\projects\BlazorWASM_JwtAuth\Client\Pages\FetchData.razor"
using BlazorWASM_JwtAuth.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 50 "C:\Users\Ashton\OneDrive - Nebula\JupyterNotebooks\C#\blazor-study-notebooks\projects\BlazorWASM_JwtAuth\Client\Pages\FetchData.razor"
       

	private List<WeatherForecast> forecasts;
	string userdata;

	private async Task<string> GetJWT()
	{
		userdata = await jsr.InvokeAsync<string>("localStorage.getItem", "user").ConfigureAwait(false);
		if (!string.IsNullOrWhiteSpace(userdata))
		{
			var dataArray = userdata.Split(';', 2);
			if (dataArray.Length == 2)
				return dataArray[1];
		}
		return null;
	}

	private async Task GetTodaysForecast()
	{
		try
		{
			var requestMsg = new HttpRequestMessage(HttpMethod.Get, $"/api/weatherforecast/{DateTime.Now.ToString("yyyy-MM-dd")}");
			requestMsg.Headers.Add("Authorization", "Bearer " + await GetJWT());
			var response = await Http.SendAsync(requestMsg);
			if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized) // NOTE: THEN TOKEN HAS EXPIRED
			{
				await jsr.InvokeVoidAsync("localStorage.removeItem", "user").ConfigureAwait(false);
				userdata = null;
			}
			else if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
				forecasts = null;
			else if (response.IsSuccessStatusCode)
			{
				var forecast = await response.Content.ReadFromJsonAsync<WeatherForecast>();
				forecasts.Clear();
				forecasts.Add(forecast);
			}
		}
		catch (Exception ex)
		{

		}
	}

	protected override async Task OnInitializedAsync()
	{
		await base.OnInitializedAsync();
		try
		{
			var requestMsg = new HttpRequestMessage(HttpMethod.Get, "/api/weatherforecast");
			requestMsg.Headers.Add("Authorization", "Bearer " + await GetJWT());
			var response = await Http.SendAsync(requestMsg);
			if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized) // NOTE: THEN TOKEN HAS EXPIRED
			{
				await jsr.InvokeVoidAsync("localStorage.removeItem", "user").ConfigureAwait(false);
				userdata = null;
			}
			else if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
				forecasts = null;
			else if (response.IsSuccessStatusCode)
				forecasts = await response.Content.ReadFromJsonAsync<List<WeatherForecast>>();
		}
		catch (Exception ex)
		{
            
		}
	}

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsr { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
