namespace sprint_1_activity_3.Clases;

public class Product
{
    // Propiedades
    public string Name { get; private set; }
    public decimal Price { get; private set; }
    public int Stock { get; private set; }

    // Constructor
    public Product(string name, decimal price, int stock)
    {
        Name = name;
        Price = price;
        Stock = stock;
    }

    // Mostrar detalles del producto
    public void ShowDetails()
    {
        Console.WriteLine($"Producto: {Name}");
        Console.WriteLine($"Precio: {Price}");
        Console.WriteLine($"Stock disponible: {Stock}");
    }

    // Vender producto
    public void Sell(int quantity)
    {
        if (quantity <= 0)
        {
            Console.WriteLine("La cantidad debe ser mayor a 0.");
            return;
        }

        if (quantity > Stock)
        {
            Console.WriteLine("No hay suficiente stock para realizar la venta.");
        }
        else
        {
            Stock -= quantity;
            Console.WriteLine($"Venta realizada: {quantity} unidades de {Name}.");
            Console.WriteLine($"Stock restante: {Stock}");
        }
    }
}