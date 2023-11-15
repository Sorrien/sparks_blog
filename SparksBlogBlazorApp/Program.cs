using Markdig;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using SparksBlogBlazorApp;
using SparksBlogBlazorApp.DataAccess;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddHttpClient<IHostClient, HostClient>(client =>
{
    client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress);
});

var markdownPipelineBuilder = new MarkdownPipelineBuilder();
var markdownPipeline = markdownPipelineBuilder.Build();
builder.Services.AddSingleton(sp => markdownPipeline);

await builder.Build().RunAsync();
