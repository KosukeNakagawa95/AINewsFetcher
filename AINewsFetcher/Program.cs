using System;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        var url = "https://news.google.com/rss/search?q=AI&hl=en-US&gl=US&ceid=US:en";

        using var client = new HttpClient();
        var rss = await client.GetStringAsync(url);

        Console.WriteLine(rss);

    }
}