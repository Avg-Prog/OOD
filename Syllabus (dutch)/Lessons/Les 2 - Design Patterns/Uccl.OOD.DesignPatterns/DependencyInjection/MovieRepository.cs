namespace DependencyInjection;

public class MovieRepository : IMovieRepository
{
    private readonly List<Movie> _movies = new();

    public MovieRepository()
    {
        _movies.Add(new Movie
        {
            Id = 1,
            Director = "Robert Zemeckis",
            ReleaseYear = 1985,
            Title = "Back To The Future"
        });
    }

    public Movie GetMovie(int id)
    {
        return _movies.Where(m => m.Id == id).FirstOrDefault();
    }
}
