using SparksBlogBlazorApp.Shared.Models;
using System.Net.Http.Json;

namespace SparksBlogBlazorApp.DataAccess
{
    public interface IHostClient
    {
        Task<ArticleDataModel?> GetArticleData();
        Task<string> GetArticleContent(string id);
    }

    public class HostClient : IHostClient
    {
        private readonly HttpClient _client;
        public HostClient(HttpClient client) => _client = client;

        public async Task<ArticleDataModel?> GetArticleData()
        {
            return await _client.GetFromJsonAsync<ArticleDataModel>("data/articles.json");
        }

        public async Task<string> GetArticleContent(string id)
        {
            return await _client.GetStringAsync($"articles/{id.ToLower()}.md");
        }
    }
}
