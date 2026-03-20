using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml;
using System.ServiceModel.Syndication;

class Program
{
    static async Task Main()
    {
        var url = "https://news.google.com/rss/search?q=AI&hl=en-US&gl=US&ceid=US:en";

        using var client = new HttpClient();
        var rss = await client.GetStringAsync(url);

        using var reader = XmlReader.Create(new System.IO.StringReader(rss));
        var feed = SyndicationFeed.Load(reader);

        foreach (var item in feed.Items)
        {
            Console.WriteLine(item.Title.Text);
        }        
    }
}