using Jorda.Client;
using Jorda.Client.Services;
using Jorda.Client.Services.Identity;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.AddRootComponents().AddClientServices();

var host = builder.Build();

await host.Services.GetRequiredService<IAuthService>().InitializeAsync();
await host.Services.GetRequiredService<IClientPreferenceService>().InitializeAsync();

await host.RunAsync();
