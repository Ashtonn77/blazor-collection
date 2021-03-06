#pragma checksum "C:\Users\Ashton\OneDrive - Nebula\JupyterNotebooks\C#\blazor-study-notebooks\projects\BlazorWASM_JwtAuth\Client\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "777f1bc3229f13c685b18e72eff254cc2130d30d"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.OpenComponent<BlazorWASM_JwtAuth.Client.Pages.UserComponent>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\r\n\r\n");
            __builder.AddMarkupContent(2, "<h1>Weather forecast</h1>\r\n\r\n");
            __builder.AddMarkupContent(3, "<p>This component demonstrates fetching data from the server.</p>");
#nullable restore
#line 11 "C:\Users\Ashton\OneDrive - Nebula\JupyterNotebooks\C#\blazor-study-notebooks\projects\BlazorWASM_JwtAuth\Client\Pages\FetchData.razor"
 if (string.IsNullOrEmpty(userdata))
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(4, "<p><a href=\"/login\">LOGIN TO ACCESS THIS DATA</a></p>");
#nullable restore
#line 14 "C:\Users\Ashton\OneDrive - Nebula\JupyterNotebooks\C#\blazor-study-notebooks\projects\BlazorWASM_JwtAuth\Client\Pages\FetchData.razor"
}
else
{
	if (forecasts == null)
	{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(5, "<p><em>Loading...</em></p>");
#nullable restore
#line 20 "C:\Users\Ashton\OneDrive - Nebula\JupyterNotebooks\C#\blazor-study-notebooks\projects\BlazorWASM_JwtAuth\Client\Pages\FetchData.razor"
	}
	else
	{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "p");
            __builder.OpenElement(7, "a");
            __builder.AddAttribute(8, "href", "javascript:;");
            __builder.AddAttribute(9, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "C:\Users\Ashton\OneDrive - Nebula\JupyterNotebooks\C#\blazor-study-notebooks\projects\BlazorWASM_JwtAuth\Client\Pages\FetchData.razor"
                                            GetTodaysForecast

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(10, "TODAY\'S FORECAST");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n\t\t");
            __builder.OpenElement(12, "table");
            __builder.AddAttribute(13, "class", "table");
            __builder.AddMarkupContent(14, "<thead><tr><th>Date</th>\r\n\t\t\t\t\t<th>Temp. (C)</th>\r\n\t\t\t\t\t<th>Temp. (F)</th>\r\n\t\t\t\t\t<th>Summary</th>\r\n\t\t\t\t\t<th>User</th></tr></thead>\r\n\t\t\t");
            __builder.OpenElement(15, "tbody");
#nullable restore
#line 35 "C:\Users\Ashton\OneDrive - Nebula\JupyterNotebooks\C#\blazor-study-notebooks\projects\BlazorWASM_JwtAuth\Client\Pages\FetchData.razor"
                 foreach (var forecast in forecasts)
				{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(16, "tr");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 38 "C:\Users\Ashton\OneDrive - Nebula\JupyterNotebooks\C#\blazor-study-notebooks\projects\BlazorWASM_JwtAuth\Client\Pages\FetchData.razor"
                             forecast.Date.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n\t\t\t\t\t\t");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 39 "C:\Users\Ashton\OneDrive - Nebula\JupyterNotebooks\C#\blazor-study-notebooks\projects\BlazorWASM_JwtAuth\Client\Pages\FetchData.razor"
                             forecast.TemperatureC

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n\t\t\t\t\t\t");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 40 "C:\Users\Ashton\OneDrive - Nebula\JupyterNotebooks\C#\blazor-study-notebooks\projects\BlazorWASM_JwtAuth\Client\Pages\FetchData.razor"
                             forecast.TemperatureF

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n\t\t\t\t\t\t");
            __builder.OpenElement(26, "td");
            __builder.AddContent(27, 
#nullable restore
#line 41 "C:\Users\Ashton\OneDrive - Nebula\JupyterNotebooks\C#\blazor-study-notebooks\projects\BlazorWASM_JwtAuth\Client\Pages\FetchData.razor"
                             forecast.Summary

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n\t\t\t\t\t\t");
            __builder.OpenElement(29, "td");
            __builder.AddContent(30, 
#nullable restore
#line 42 "C:\Users\Ashton\OneDrive - Nebula\JupyterNotebooks\C#\blazor-study-notebooks\projects\BlazorWASM_JwtAuth\Client\Pages\FetchData.razor"
                             forecast.UserName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 44 "C:\Users\Ashton\OneDrive - Nebula\JupyterNotebooks\C#\blazor-study-notebooks\projects\BlazorWASM_JwtAuth\Client\Pages\FetchData.razor"
				}

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 47 "C:\Users\Ashton\OneDrive - Nebula\JupyterNotebooks\C#\blazor-study-notebooks\projects\BlazorWASM_JwtAuth\Client\Pages\FetchData.razor"
	}
}

#line default
#line hidden
#nullable disable
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
