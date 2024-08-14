using DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

class Program
{
    private static IServiceProvider _serviceProvider;

    static void Main(string[] args)
    {
        RegisterServices();
        var movieController = _serviceProvider.GetRequiredService<MovieController>();
        Console.WriteLine(movieController.GetMovie(1));
        DisposeServices();
    }

    private static void RegisterServices()
    {
        var services = new ServiceCollection();
        services.AddSingleton<IMovieRepository, MovieRepository>();
        services.AddSingleton<MovieController>();
        _serviceProvider = services.BuildServiceProvider(true);
    }

    private static void DisposeServices()
    {
        if (_serviceProvider == null)
        {
            return;
        }
        if (_serviceProvider is IDisposable)
        {
            ((IDisposable)_serviceProvider).Dispose();
        }
    }
}