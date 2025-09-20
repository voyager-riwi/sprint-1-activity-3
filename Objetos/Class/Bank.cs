namespace Objetos.Class;

public class Bank
{
    public int numberAccount;
    public string name;
    public decimal balance;
    private List<Bank> banks = new List<Bank>();
    
    public void menu()
    {
        Console.WriteLine("======MENU======\n" +
                          "1. Registrar cuenta\n" +
                          "2. Consultar saldo de cuenta\n" +
                          "3. Depositar dinero\n" +
                          "4. Salir");
    }
    public void add(int numberAccount, string name, decimal balance)
    {
        banks.Add(new Bank { numberAccount = numberAccount ,name = name, balance = balance });
    }

    public decimal consultBalance(string name)
    {
        Bank account = banks.Find(b => b.name == name);

        if (account != null)
        {
            return account.balance;
        }
        else
        {
            Console.WriteLine("Cuenta no encontrada.");
            return 0;
        }
    }

    public decimal depositMoney(string name, decimal amount)
    {
        Bank account = banks.Find(b => b.name == name);

        if (account != null)
        {
            account.balance += amount;
            return account.balance;
        }
        else
        {
            Console.WriteLine("Cuenta no encontrada.");
            return 0;
        }
    }
}

