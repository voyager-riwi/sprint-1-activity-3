namespace Objetos.Class;

public class Students
{
    public string name;
    public int age;
    public int grade;
    private List<Students> students = new List<Students>();

    public void menu()
    {
        Console.WriteLine("======MENU======\n" +
                          "1. Registrar estudiante\n" +
                          "2. Listar estudiantes\n" +
                          "3. Salir");
    }
    public void add(string name, int age, int grade)
    {
        students.Add(new Students { name = name, age = age, grade = grade });
    }

    public void list()
    {
        Console.WriteLine("Lista de estudiantes:");
        foreach (var s in students)
        {
            Console.WriteLine($"Estudiante {s.name} tiene {s.age} años y esta en grado {s.grade}");
        }
    }
}
