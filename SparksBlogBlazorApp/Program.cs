using Markdig;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using SparksBlogBlazorApp;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

var markdownPipelineBuilder = new MarkdownPipelineBuilder();
var markdownPipeline = markdownPipelineBuilder.Build();
builder.Services.AddSingleton(sp => markdownPipeline);

await builder.Build().RunAsync();
