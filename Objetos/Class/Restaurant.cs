namespace Objetos.Class;

public class Restaurant
{
    public string name;
    public int numberTables;
    public decimal price;
    private List<Restaurant> restaurants = new List<Restaurant>();

    public void menu()
    {
        Console.WriteLine("======MENU======\n" +
                          "1. Registrar nuevo pedido\n" +
                          "2. Calcular total del pedido\n" +
                          "3. Mostrar detalles pedido\n" +
                          "4. Salir");
    }

    public void add(string name, int numberTables, decimal price)
    {
        restaurants.Add(new Restaurant { name = name ,numberTables = numberTables, price = price });
    }

    public decimal orderlist(int numberTables, bool mostrarDetalles)
    {
        var items = restaurants
            .Where(r => r.numberTables == numberTables)
            .ToList();

        if (items.Count == 0)
        {
            Console.WriteLine("No hay pedidos para esta mesa.");
            return 0m;
        }

        Console.WriteLine($"Detalles del pedido (Mesa {numberTables}):");
        foreach (var it in items)
        {
            Console.WriteLine($"- {it.name}: {it.price}");
        }

        var total = items.Sum(it => it.price);
        Console.WriteLine($"Total: {total}");
        return total;
    }
    
    public decimal totalOrder(int numberTables)
    {
        var total = restaurants
            .Where(r => r.numberTables == numberTables)
            .Sum(r => r.price);
        return total;
    }
}