using SparksBlogBlazorApp.Shared.Models;

namespace SparksBlogBlazorApp.Models
{
    public class Article
    {
        public ArticleMetadata Metadata { get; set; }
        public string Content { get; set; }
    }
}
