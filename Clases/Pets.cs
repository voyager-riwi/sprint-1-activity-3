namespace sprint_1_activity_3.Clases;

public class Pet
{
    public string Name { get; set; }
    public string Species { get; set; }
    public int Age { get; set; } // en años

    public Pet(string name, string species, int age)
    {
        Name = name;
        Species = species;
        Age = age;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Nombre: {Name} | Especie: {Species} | Edad: {Age} años");
    }

    public void IsPuppy()
    {
        if (Age < 2)
            Console.WriteLine($"La mascota {Name} es un cachorro (menos de 2 años).");
        else
            Console.WriteLine($"La mascota {Name} NO es un cachorro (2 años o más).");
    }
}

public static class Veterinary
{
    private static List<Pet> pets = new List<Pet>();

    public static void RegisterPet(string name, string species, int age)
    {
        Pet newPet = new Pet(name, species, age);
        pets.Add(newPet);
    }

    public static Pet FindPet(string name)
    {
        return pets.Find(p => p.Name.ToLower() == name.ToLower());
    }

    public static List<Pet> GetPets()
    {
        return pets;
    }
}