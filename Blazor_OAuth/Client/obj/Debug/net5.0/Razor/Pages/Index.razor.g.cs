#pragma checksum "/home/ash/Documents/github/dotnet/blazor-collection/Blazor_OAuth/Client/Pages/Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2625576482d4bc3a31c1b07b79fde47cfa513238"
// <auto-generated/>
#pragma warning disable 1591
namespace Blazor_OAuth.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/home/ash/Documents/github/dotnet/blazor-collection/Blazor_OAuth/Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/ash/Documents/github/dotnet/blazor-collection/Blazor_OAuth/Client/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/ash/Documents/github/dotnet/blazor-collection/Blazor_OAuth/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/ash/Documents/github/dotnet/blazor-collection/Blazor_OAuth/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/ash/Documents/github/dotnet/blazor-collection/Blazor_OAuth/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/ash/Documents/github/dotnet/blazor-collection/Blazor_OAuth/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/ash/Documents/github/dotnet/blazor-collection/Blazor_OAuth/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/ash/Documents/github/dotnet/blazor-collection/Blazor_OAuth/Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/ash/Documents/github/dotnet/blazor-collection/Blazor_OAuth/Client/_Imports.razor"
using Blazor_OAuth.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/home/ash/Documents/github/dotnet/blazor-collection/Blazor_OAuth/Client/_Imports.razor"
using Blazor_OAuth.Client.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<style>

.wrapper{

    width: 100%;
    height: 100vh;
    display: flex;
    justify-content: center;
    align-items: center;

}


.auth-box{
    width: 80%;
    max-width: 800px;
    height: 64px;
    margin: auto;
    display: flex;
    justify-content: space-between;
}

.auth-box img{
    cursor: pointer;
}

</style>


");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "wrapper");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "auth-box");
            __builder.AddMarkupContent(5, "<img src=\"images/google.png\" alt=\"google\">\r\n\r\n        <img src=\"images/facebook.png\" alt=\"facebook\">\r\n\r\n        ");
            __builder.OpenElement(6, "img");
            __builder.AddAttribute(7, "src", "images/twitter.png");
            __builder.AddAttribute(8, "alt", "twitter");
            __builder.AddAttribute(9, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 41 "/home/ash/Documents/github/dotnet/blazor-collection/Blazor_OAuth/Client/Pages/Index.razor"
                                                              TwitterSignIn

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n\r\n        <img src=\"images/linkedin.png\" alt=\"linkedin\">");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 51 "/home/ash/Documents/github/dotnet/blazor-collection/Blazor_OAuth/Client/Pages/Index.razor"
      

    private void TwitterSignIn()
    {
        NavigationManager.NavigateTo("api/user/TwitterSignIn", true);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
