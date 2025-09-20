namespace Objetos.Class;

public class Library
{
    public string title;
    public string author;
    public int numberPages;
    private List<Library> books = new List<Library>();
    
    public void menu()
    {
        Console.WriteLine("======MENU======\n" +
                          "1. Registrar libro\n" +
                          "2. Consultar detalles de un libro\n" +
                          "3. Libros de mas de 300 paginas\n" +
                          "4. Salir");
    }
    public void add(string title, string author, int numberPages)
    {
        books.Add(new Library { title = title ,author = author, numberPages = numberPages });
    }

    public Library consultBook(string title)
    {
        var book = books.Find(b => b.title == title);

        if (book != null)
        {
            return book;
        }
        else
        {
            Console.WriteLine("Libro no encontrado.");
            return null;
        }
    }
    public bool isMoreThan300Pages(string titleNumberPages)
    {
        var book = books.Find(b => b.title == titleNumberPages);
        
        if (book.numberPages < 300)
        {
            return false;    
        }
        else
        {
            return book.numberPages > 300;
        }
    }
}