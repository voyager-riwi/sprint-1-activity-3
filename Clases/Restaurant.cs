namespace sprint_1_activity_3.Clases;

public class Order
{
    public int TableNumber { get; set; }
    public string DishName { get; set; }
    public decimal Price { get; set; }

    public Order(int tableNumber, string dishName, decimal price)
    {
        TableNumber = tableNumber;
        DishName = dishName;
        Price = price;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Mesa: {TableNumber} | Plato: {DishName} | Precio: {Price:C}");
    }
}

public static class Restaurant
{
    private static List<Order> orders = new List<Order>();

    public static void RegisterOrder(int table, string dish, decimal price)
    {
        Order newOrder = new Order(table, dish, price);
        orders.Add(newOrder);
    }

    public static decimal CalculateTotal(int table)
    {
        var tableOrders = orders.Where(o => o.TableNumber == table).ToList();
        return tableOrders.Sum(o => o.Price);
    }

    public static List<Order> GetOrders(int table)
    {
        return orders.Where(o => o.TableNumber == table).ToList();
    }
}