using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using QBNsite;
using QBNsite.Helper;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");


var baseUri = builder.HostEnvironment.BaseAddress;
if (builder.HostEnvironment.IsProduction())
{
    baseUri = builder.HostEnvironment.BaseAddress + "QuocBaoNguyen/"; 
}
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(baseUri) });

builder.Services.AddLocalization();
builder.Services.AddSingleton<Helper>();

await builder.Build().RunAsync();
