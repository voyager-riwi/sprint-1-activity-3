namespace Objetos.Class;

public class Pets
{
    public string namePet;
    public string breed;
    public int age;
    private List<Pets> pets = new List<Pets>();
    
    public void menu()
    {
        Console.WriteLine("======MENU======\n" +
                          "1 - Registrar mascota\n" +
                          "2 - Consultar mascotas\n" +
                          "3 - Edad de mascota\n" +
                          "4 - Sair\n");
    }

    public void add(string name, string breed, int age)
    {
        pets.Add(new Pets { namePet = name, breed = breed, age = age });
    }

    public Pets listPet(string name)
    {
        var pet = pets.Find(p => p.namePet == name);
        if (pet != null)
        {
            return pet;
        }
        else
        {
            return null;
        }
    }
    
    public int agePet(string name)
    {
        var pet = pets.Find(p => p.namePet == name);
        
        if (pet != null)
        {
            return pet.age;
        }
        else
        {
            return 0;
        }
    }
}