namespace Objetos.Class;

public class Store
{
    public string name;
    public decimal price;
    public int quantity;
    private List<Store> products = new List<Store>();

    public void menu()
    {
        Console.WriteLine("======MENU======\n" +
                          "1. Registrar producto\n" +
                          "2. Consultar detalles de un producto\n" +
                          "3. Vender producto\n" +
                          "4. Salir");
    }
    public void add(string name, decimal price, int quantity)
    {
        products.Add(new Store { name = name ,price = price, quantity = quantity });
    }

    public Store consultProduct(string name)
    {
        var product = products.Find(b => b.name == name);

        if (product != null)
        {
            return product;
        }
        else
        {
            Console.WriteLine("Cuenta no encontrada.");
            return null;
        }
    }
    
    public int Sell(string name, int amount)
    {
        var product = products.Find(b => b.name == name);
        
        if (product != null)
        {
            product.quantity -= amount;
            return product.quantity;
        }
        else
        {
            Console.WriteLine("Stock insuficiente.");
            return 0;
        }
    }
}