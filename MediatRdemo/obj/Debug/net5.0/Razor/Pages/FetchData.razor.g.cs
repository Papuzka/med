#pragma checksum "E:\dotnet-tutorials\BlazorMediator\MediatRdemo\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d93b868235676e5223d31f9d716be45a13a30b8"
// <auto-generated/>
#pragma warning disable 1591
namespace MediatRdemo.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\dotnet-tutorials\BlazorMediator\MediatRdemo\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\dotnet-tutorials\BlazorMediator\MediatRdemo\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\dotnet-tutorials\BlazorMediator\MediatRdemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\dotnet-tutorials\BlazorMediator\MediatRdemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\dotnet-tutorials\BlazorMediator\MediatRdemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\dotnet-tutorials\BlazorMediator\MediatRdemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\dotnet-tutorials\BlazorMediator\MediatRdemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\dotnet-tutorials\BlazorMediator\MediatRdemo\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\dotnet-tutorials\BlazorMediator\MediatRdemo\_Imports.razor"
using MediatRdemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\dotnet-tutorials\BlazorMediator\MediatRdemo\_Imports.razor"
using MediatRdemo.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\dotnet-tutorials\BlazorMediator\MediatRdemo\_Imports.razor"
using DemoLibrary.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\dotnet-tutorials\BlazorMediator\MediatRdemo\_Imports.razor"
using DemoLibrary.Handlers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "E:\dotnet-tutorials\BlazorMediator\MediatRdemo\_Imports.razor"
using DemoLibrary.Queries;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\dotnet-tutorials\BlazorMediator\MediatRdemo\Pages\FetchData.razor"
using MediatRdemo.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Weather forecast</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>This component demonstrates fetching data from a service.</p>");
#nullable restore
#line 10 "E:\dotnet-tutorials\BlazorMediator\MediatRdemo\Pages\FetchData.razor"
 if (forecasts == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>");
#nullable restore
#line 13 "E:\dotnet-tutorials\BlazorMediator\MediatRdemo\Pages\FetchData.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "table");
            __builder.AddAttribute(4, "class", "table");
            __builder.AddMarkupContent(5, "<thead><tr><th>Date</th>\r\n                <th>Temp. (C)</th>\r\n                <th>Temp. (F)</th>\r\n                <th>Summary</th></tr></thead>\r\n        ");
            __builder.OpenElement(6, "tbody");
#nullable restore
#line 26 "E:\dotnet-tutorials\BlazorMediator\MediatRdemo\Pages\FetchData.razor"
             foreach (var forecast in forecasts)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "tr");
            __builder.OpenElement(8, "td");
#nullable restore
#line 29 "E:\dotnet-tutorials\BlazorMediator\MediatRdemo\Pages\FetchData.razor"
__builder.AddContent(9, forecast.Date.ToShortDateString());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n                    ");
            __builder.OpenElement(11, "td");
#nullable restore
#line 30 "E:\dotnet-tutorials\BlazorMediator\MediatRdemo\Pages\FetchData.razor"
__builder.AddContent(12, forecast.TemperatureC);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "td");
#nullable restore
#line 31 "E:\dotnet-tutorials\BlazorMediator\MediatRdemo\Pages\FetchData.razor"
__builder.AddContent(15, forecast.TemperatureF);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.OpenElement(17, "td");
#nullable restore
#line 32 "E:\dotnet-tutorials\BlazorMediator\MediatRdemo\Pages\FetchData.razor"
__builder.AddContent(18, forecast.Summary);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 34 "E:\dotnet-tutorials\BlazorMediator\MediatRdemo\Pages\FetchData.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 37 "E:\dotnet-tutorials\BlazorMediator\MediatRdemo\Pages\FetchData.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "E:\dotnet-tutorials\BlazorMediator\MediatRdemo\Pages\FetchData.razor"
       
    private WeatherForecast[] forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await ForecastService.GetForecastAsync(DateTime.Now);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WeatherForecastService ForecastService { get; set; }
    }
}
#pragma warning restore 1591
