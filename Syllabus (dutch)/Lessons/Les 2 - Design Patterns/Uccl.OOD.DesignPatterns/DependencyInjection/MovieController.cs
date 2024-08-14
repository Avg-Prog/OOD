namespace DependencyInjection;

public sealed class MovieController
{
    private IMovieRepository _movieRepository;

    public MovieController(IMovieRepository movieRepository)
    {
        _movieRepository = movieRepository;
    }

    public string GetMovie(int id)
    {
        var movie = _movieRepository.GetMovie(id);
        if (movie is not null)
        {
            return $"{movie.Title} \n- Directed by: {movie.Director}\n- Release year: {movie.ReleaseYear}";
        }

        return "Movie not found";
    }
}
