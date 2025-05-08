using CssInCSharp;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Examples.Basic;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<StyleOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddCssInCSharp();

await builder.Build().RunAsync();
