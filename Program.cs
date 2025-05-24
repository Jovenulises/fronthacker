using BestHackerNewsStoriesFront.Architecture.HackerNewsStories.Interfaces;
using BestHackerNewsStoriesFront.Architecture.HackerNewsStories.Repository;
using BestHackerNewsStoriesFront.Architecture.HackerNewsStories.Services;
using FrontHacker;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;


var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Servicios
builder.Services.AddScoped<IStoryRepository, StoryRepository>();
builder.Services.AddScoped<IStoryService, StoryService>();

// HttpClient para consumir APIs externas (StoryRepository)
builder.Services.AddHttpClient<IStoryRepository, StoryRepository>(client =>
{
    client.BaseAddress = new Uri("https://apihacker-ebf6bydabxhjgvf0.canadacentral-01.azurewebsites.net/");
});

// HttpClient general para otros usos (por si lo inyectas directamente en otros componentes)
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();
