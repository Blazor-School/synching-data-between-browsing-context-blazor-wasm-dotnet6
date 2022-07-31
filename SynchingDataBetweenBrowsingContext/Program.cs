using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using SynchingDataBetweenBrowsingContext;
using SynchingDataBetweenBrowsingContext.Utils;
using SynchingDataBetweenBrowsingContext.Utils.GlobalBroadcaster;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<BlazorSchoolBroadcaster>();
builder.Services.AddScoped<BlazorSchoolGlobalBroadcasterService>();

await builder.Build().RunAsync();
