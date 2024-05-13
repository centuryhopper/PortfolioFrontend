using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using PortfolioFrontend;
using Blazored.Modal;
using PortfolioFrontend.Services;
using Business.Entities;
using Radzen;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

/*

uses neon postgres db for storage
uses railway for deploying


*/

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });


// builder.Services
//     .AddHttpClient(
//         "ServerAPI",
//         client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)
//     )
//     .AddHttpMessageHandler<BaseAddressAuthorizationMessageHandler>();

// // Supply HttpClient instances that include access tokens when making requests
// // to the server project
// builder.Services.AddScoped(
//     sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient("ServerAPI")
// );

builder.Services.AddRadzenComponents();

builder.Services.AddBlazoredModal();

builder.Services.AddScoped<IContactsService<ContactMeModel>, ContactsService>();

await builder.Build().RunAsync();
