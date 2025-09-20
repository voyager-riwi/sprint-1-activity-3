namespace sprint_1_activity_3.Clases;

public class Book
{
    // Propiedades
    public string Title { get; private set; }
    public string Author { get; private set; }
    public int Pages { get; private set; }

    // Constructor
    public Book(string title, string author, int pages)
    {
        Title = title;
        Author = author;
        Pages = pages;
    }

    // Mostrar detalles del libro
    public void ShowDetails()
    {
        Console.WriteLine($"Título: {Title}");
        Console.WriteLine($"Autor: {Author}");
        Console.WriteLine($"Número de páginas: {Pages}");
    }

    // Revisar si tiene más de 300 páginas
    public void CheckPages()
    {
        if (Pages > 300)
        {
            Console.WriteLine("Este libro tiene más de 300 páginas.");
        }
        else
        {
            Console.WriteLine("Este libro tiene 300 páginas o menos.");
        }
    }
}