using System.Diagnostics;
using System.Text;
using Ucll.OOD.ASYNC.Model;
using Ucll.OOD.ASYNC.Services;

namespace Ucll.OOD.ASYNC;

public partial class FrmMain : Form
{
    private readonly List<string> _websites;

    private readonly CancellationTokenSource _tokenSource = new();
    public FrmMain()
    {
        _websites = new List<string>
        {
            "http://www.google.com",
            "http://www.wikipedia.com",
            "http://www.youtube.com",
            "https://intranet.ucll.be/",
            "http://www.euri.com",
            "http://www.google.com",
            "http://www.wikipedia.com",
            "http://www.youtube.com",
            "https://intranet.ucll.be/",
            "http://www.euri.com",
            "http://www.google.com",
            "http://www.wikipedia.com",
            "http://www.youtube.com",
            "https://intranet.ucll.be/",
            "http://www.euri.com",
            "http://www.google.com",
            "http://www.wikipedia.com",
            "http://www.youtube.com",
            "https://intranet.ucll.be/",
            "http://www.euri.com",
            "http://www.google.com",
            "http://www.wikipedia.com",
            "http://www.youtube.com",
            "https://intranet.ucll.be/",
            "http://www.euri.com"
        };
        InitializeComponent();
    }

    private void BtnSync_Click(object sender, EventArgs e)
    {
        var watch = new Stopwatch();
        watch.Start();
        tbOutput.Text = "";
        var sb = new StringBuilder();
        foreach (var website in _websites)
        {
            sb.AppendLine($"{website}: {DownloadService.DownloadWebsite(website)}");
        }
        watch.Stop();
        sb.AppendLine($"Elapsed time: {watch.ElapsedMilliseconds}");
        tbOutput.Text = sb.ToString();
    }

    private async void BtnSync2_Click(object sender, EventArgs e)
    {
        var watch = new Stopwatch();
        watch.Start();
        tbOutput.Text = "";
        var sb = new StringBuilder();
        foreach (var website in _websites)
        {
            sb.AppendLine($"{website}: {await Task.Run(() => DownloadService.DownloadWebsite(website))}");
        }
        watch.Stop();
        sb.AppendLine($"Elapsed time: {watch.ElapsedMilliseconds}");
        tbOutput.Text = sb.ToString();
    }

    private async void BtnAsync_Click(object sender, EventArgs e)
    {
        var watch = new Stopwatch();
        watch.Start();
        tbOutput.Text = "";
        List<Task<WebsiteModel>> tasks = new();
        var sb = new StringBuilder();
        foreach (var website in _websites)
        {
            tasks.Add(DownloadService.DownloadWebsiteAsync(website));
        }

        var results = await Task.WhenAll(tasks);
        foreach (var item in results)
        {
            sb.AppendLine($"{item.WebsiteName} - {item.PageLength}");
        }
        watch.Stop();
        sb.AppendLine($"Elapsed time: {watch.ElapsedMilliseconds}");
        tbOutput.Text = sb.ToString();
    }
    private async void btnAsyncWithCancel_Click(object sender, EventArgs e)
    {
        try
        {
            await DownloadAllWebsitesAsync(_tokenSource.Token);
        }
        catch (Exception)
        {
            tbOutput.Text = "Download was cancelled by user";
        }
    }

    private async Task DownloadAllWebsitesAsync(CancellationToken cancellationToken)
    {
        var watch = new Stopwatch();
        watch.Start();
        tbOutput.Text = "";
        List<Task<WebsiteModel>> tasks = new();
        var sb = new StringBuilder();
        foreach (var website in _websites)
        {
            tasks.Add(DownloadService.DownloadWebsiteWithCancelAsync(website, cancellationToken));
        }

        var results = await Task.WhenAll(tasks);
        foreach (var item in results)
        {
            sb.AppendLine($"{item.WebsiteName} - {item.PageLength}");
        }
        watch.Stop();
        sb.AppendLine($"Elapsed time: {watch.ElapsedMilliseconds}");
        tbOutput.Text = sb.ToString();
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
        _tokenSource.Cancel();
    }

}
