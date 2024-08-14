using System.Net;
using Ucll.OOD.ASYNC.Model;

namespace Ucll.OOD.ASYNC.Services;

public static class DownloadService
{
    public static string DownloadWebsite(string url)
    {
        //we use an obsolete class to demonstrate sync downloading  
        var client = new WebClient();
        return client.DownloadString(url).Length.ToString();
    }
    public async static Task<WebsiteModel> DownloadWebsiteAsync(string url)
    {

        var client = new HttpClient();
        var page = await client.GetStringAsync(url);

        return new WebsiteModel
        {
            WebsiteName = url,
            PageLength = page.Length
        };
    }

    public async static Task<WebsiteModel> DownloadWebsiteWithCancelAsync(string url, CancellationToken cancellationToken)
    {

        var client = new HttpClient();
        var page = await client.GetStringAsync(url);
        cancellationToken.ThrowIfCancellationRequested();

        return new WebsiteModel
        {
            WebsiteName = url,
            PageLength = page.Length
        };
    }

    public async static Task<WebsiteModel> DownloadWebsiteAsync2(string url, CancellationToken cancellationToken)
    {
        if (!cancellationToken.IsCancellationRequested)
        {
            var client = new HttpClient();
            var page = await client.GetStringAsync(url);

            return new WebsiteModel
            {
                WebsiteName = url,
                PageLength = page.Length
            };
        }

        return null;
    }
}
