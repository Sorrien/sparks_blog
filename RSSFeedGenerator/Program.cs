using SparksBlogBlazorApp.Shared.Models;
//using System.Reflection;
using System.ServiceModel.Syndication;
using System.Text;
using System.Text.Json;
using System.Xml;

//var versionString = Assembly.GetEntryAssembly()?
//                                .GetCustomAttribute<AssemblyInformationalVersionAttribute>()?
//                                .InformationalVersion
//                                .ToString();

if (args.Length > 0)
{
    var filePath = args[0];
    var fileInfo = new FileInfo(filePath);
    Console.WriteLine(fileInfo.FullName);

    var wwwrootPath = fileInfo.Directory.Parent.FullName;
    Console.WriteLine(wwwrootPath);

    var articleDataString = await File.ReadAllTextAsync(filePath);

    var articleData = JsonSerializer.Deserialize<ArticleDataModel>(articleDataString);

    var resultFileName = "feed.xml";
    GenerateFeed(articleData, $"{wwwrootPath}/{resultFileName}");
}
else
{
    Console.WriteLine("Please include a data file.");
}

static void GenerateFeed(ArticleDataModel articleData, string path)
{
    var blogUrl = "https://www.collinsparks.net";

    var items = new List<SyndicationItem>();
    foreach (var article in articleData.Articles)
    {
        var articleItem = new SyndicationItem(article.Title, article.Description, new Uri($"{blogUrl}/post/{article.Id}"))
        {
            Id = article.Id,
            PublishDate = article.CreatedDate,
            LastUpdatedTime = article.ModifiedDate,
        };
        items.Add(articleItem);
    }

    var feed = new SyndicationFeed("Collin Sparks Blog", "This is the blog of Software Engineer Collin Sparks.", new Uri(blogUrl), "RSSUrl", DateTime.Now)
    {
        Copyright = new TextSyndicationContent($"{DateTime.Now.Year} Collin Sparks"),
        Items = items
    };

    var settings = new XmlWriterSettings
    {
        Encoding = Encoding.UTF8,
        NewLineHandling = NewLineHandling.Entitize,
        NewLineOnAttributes = true,
        Indent = true
    };
    using var stream = new MemoryStream();
    using var xmlWriter = XmlWriter.Create(stream, settings);
    var rssFormatter = new Rss20FeedFormatter(feed, false);
    rssFormatter.WriteTo(xmlWriter);
    xmlWriter.Flush();
    File.WriteAllBytesAsync(path, stream.ToArray());
}