using Blazored.Toast;
using Course.BlazorWasm.Client;
using Course.BlazorWasm.Client.Model;
using Course.BlazorWasm.Client.StateProvider;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using OnlineCourses.BlazorWasm.Client;
using OnlineCourses.BlazorWasm.Services.Extensions;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddOidcAuthentication(options =>
{
    // Configure your authentication provider options here.
    // For more information, see https://aka.ms/blazor-standalone-auth
    builder.Configuration.Bind("Google", options.ProviderOptions);
});
// Register the services that provide access to the API resources.
builder.Services.AddServices();

// Toast service help show pop-up messages to the user.
builder.Services.AddBlazoredToast();

//builder.Services.AddScoped<GoogleResponse>();
//builder.Services.AddScoped<AuthenticationDataMemoryStorage>();
//builder.Services.AddScoped<BlazorUserService>();
//builder.Services.AddScoped<CustomAuthenticationStateProvider>();
//builder.Services.AddScoped<AuthenticationStateProvider>(sp => sp.GetRequiredService<CustomAuthenticationStateProvider>());

//builder.Services.AddCors(policy => {

//    policy.AddPolicy("Policy_Name", builder =>
//      builder.WithOrigins("https://*:5001/")
//        .SetIsOriginAllowedToAllowWildcardSubdomains()
//        .AllowAnyOrigin()


// );
//});

// Configure the HTTP request pipeline.

//app.UseCors("Policy_Name");

await builder.Build().RunAsync();
