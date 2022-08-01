using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using SynchingDataBetweenBrowsingContext;
using SynchingDataBetweenBrowsingContext.Utils.ComponentBroadcaster;
using SynchingDataBetweenBrowsingContext.Utils.GlobalBroadcaster;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<BlazorSchoolComponentBroadcaster1>();
builder.Services.AddScoped<BlazorSchoolComponentBroadcaster2>();
builder.Services.AddScoped<BlazorSchoolGlobalBroadcaster>();

await builder.Build().RunAsync();
