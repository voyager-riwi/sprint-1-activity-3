namespace Objetos.Class;

public class Cinema
{
    public string title;
    public string genre;
    public int duration;
    private List<Cinema> movies = new List<Cinema>();
    
    public void menu()
    {
        Console.WriteLine("======MENU======\n" +
                          "1 - Registrar pelicula\n" +
                          "2 - Consultar pelicula\n" +
                          "3 - Duracion de pelicula\n" +
                          "4 - Sair\n");
    }

    public void add(string title, string genre, int duration)
    {
        movies.Add(new Cinema { title = title ,genre = genre, duration = duration });
    }
    public Cinema consultMovie(string title)
    {
        var movie = movies.Find(b => b.title == title);

        if (movie != null)
        {
            return movie;
            
        }
        else
        {
            return null;
        }
    }
    public int durationMovie(string title)
    {
        var movie = movies.Find(b => b.title == title);
        if (movie != null)
        {
            return movie.duration;
        }
        else
        {
            return 0;
        }
    }
}