namespace sprint_1_activity_3.Clases;

public class Movie
{
    public string Title { get; set; }
    public string Genre { get; set; }
    public int Duration { get; set; } // Duracion en minutos

    public Movie(string title, string genre, int duration)
    {
        Title = title;
        Genre = genre;
        Duration = duration;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Título: {Title} | Género: {Genre} | Duración: {Duration} minutos");
    }

    public void IsLong()
    {
        if (Duration > 120)
            Console.WriteLine($"La película {Title} es larga (más de 120 minutos).");
        else
            Console.WriteLine($"La película {Title} NO es larga (120 minutos o menos).");
    }
}

public static class Cinema
{
    private static List<Movie> movies = new List<Movie>();

    public static void RegisterMovie(string title, string genre, int duration)
    {
        Movie newMovie = new Movie(title, genre, duration);
        movies.Add(newMovie);
    }

    public static Movie FindMovie(string title)
    {
        return movies.Find(m => m.Title.ToLower() == title.ToLower());
    }

    public static List<Movie> GetMovies()
    {
        return movies;
    }
}