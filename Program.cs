using System;
using sprint_1_activity_3.Clases;
using System.Collections.Generic;

List<Person> students = new List<Person>();

bool next = true;

while (next)
{
    Person person = new Person();

    Console.WriteLine("Ingresa el nombre completo del estudiante: ");
    person.Name = Console.ReadLine();

    Console.WriteLine("Ingresa la edad del estudiante: ");
    person.Age = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Ingresa el grado del estudiante: ");
    person.Grade = Convert.ToInt32(Console.ReadLine());

    students.Add(person);

    Console.WriteLine("¿Quieres agregar otro estudiante? (s/n): ");
    string answer = Console.ReadLine().ToLower();
    if (answer != "s")
    {
        next = false;
    }
}

Console.WriteLine("LISTA DE ESTUDIANTES");
foreach (var student in students)
{
    Console.WriteLine(student.StudentInfo());
}


// Second part - Bank accounts

{
    class Program
    {
        static List<Account> accounts = new List<Account>();
        static Random rnd = new Random();

        static void Main()
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("--- MENÚ BANCO ---");
                Console.WriteLine("1. Abrir una nueva cuenta");
                Console.WriteLine("2. Consultar saldo");
                Console.WriteLine("3. Depositar dinero");
                Console.WriteLine("4. Salir");
                Console.Write("Opción: ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        OpenAccount();
                        break;
                    case "2":
                        CheckBalance();
                        break;
                    case "3":
                        DepositMoney();
                        break;
                    case "4":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
        }

        static void OpenAccount()
        {
            Console.Write("Ingresa el nombre del dueño: ");
            string owner = Console.ReadLine();

            // Generar número aleatorio de 10 dígitos
            string accountNumber = "";
            for (int i = 0; i < 10; i++)
            {
                accountNumber += rnd.Next(0, 10).ToString();
            }

            Account newAccount = new Account(owner, accountNumber);
            accounts.Add(newAccount);

            Console.WriteLine($"Cuenta creada con éxito.");
            Console.WriteLine($"Número: {accountNumber}");
            Console.WriteLine($"Dueño: {owner}");
            Console.WriteLine("Saldo inicial: 0");
        }

        static void CheckBalance()
        {
            Console.Write("Ingresa el número de cuenta: ");
            string number = Console.ReadLine();

            Account acc = accounts.Find(a => a.AccountNumber == number);
            if (acc == null)
            {
                Console.WriteLine("La cuenta no existe.");
            }
            else
            {
                acc.ShowBalance();
            }
        }

        static void DepositMoney()
        {
            Console.Write("Ingresa el número de cuenta: ");
            string number = Console.ReadLine();

            Account acc = accounts.Find(a => a.AccountNumber == number);
            if (acc == null)
            {
                Console.WriteLine("La cuenta no existe.");
                return;
            }

            Console.Write("Monto a depositar: ");
            decimal amount = Convert.ToDecimal(Console.ReadLine());

            acc.Deposit(amount);
        }
    }
}


// Part 3 - store and products

{
    class Program
    {
        static List<Product> products = new List<Product>();

        static void Main()
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("--- MENÚ TIENDA ---");
                Console.WriteLine("1. Registrar nuevo producto");
                Console.WriteLine("2. Consultar detalles de un producto");
                Console.WriteLine("3. Vender producto");
                Console.WriteLine("4. Salir");
                Console.Write("Opción: ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        RegisterProduct();
                        break;
                    case "2":
                        CheckProduct();
                        break;
                    case "3":
                        SellProduct();
                        break;
                    case "4":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
        }

        static void RegisterProduct()
        {
            Console.Write("Nombre del producto: ");
            string name = Console.ReadLine();

            Console.Write("Precio: ");
            decimal price = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Cantidad en stock: ");
            int stock = Convert.ToInt32(Console.ReadLine());

            Product newProduct = new Product(name, price, stock);
            products.Add(newProduct);

            Console.WriteLine("Producto registrado con éxito.");
        }

        static void CheckProduct()
        {
            Console.Write("Ingresa el nombre del producto: ");
            string name = Console.ReadLine();

            Product prod = products.Find(p => p.Name.ToLower() == name.ToLower());
            if (prod == null)
            {
                Console.WriteLine("El producto no existe.");
            }
            else
            {
                prod.ShowDetails();
            }
        }

        static void SellProduct()
        {
            Console.Write("Ingresa el nombre del producto: ");
            string name = Console.ReadLine();

            Product prod = products.Find(p => p.Name.ToLower() == name.ToLower());
            if (prod == null)
            {
                Console.WriteLine("El producto no existe.");
                return;
            }

            Console.Write("Cantidad a vender: ");
            int qty = Convert.ToInt32(Console.ReadLine());

            prod.Sell(qty);
        }
    }
}

// Part 4 - library and books

{
    class Program
    {
        static List<Book> books = new List<Book>();

        static void Main()
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("MENÚ BIBLIOTECA");
                Console.WriteLine("1. Registrar un nuevo libro");
                Console.WriteLine("2. Consultar información de un libro");
                Console.WriteLine("3. Revisar si un libro tiene más de 300 páginas");
                Console.WriteLine("4. Salir");
                Console.Write("Opción: ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1": RegisterBook(); break;
                    case "2": ShowBook(); break;
                    case "3": CheckBookPages(); break;
                    case "4": running = false; break;
                    default: Console.WriteLine("Opción no válida."); break;
                }
            }
        }

        static void RegisterBook()
        {
            Console.Write("Título: ");
            string title = Console.ReadLine();
            Console.Write("Autor: ");
            string author = Console.ReadLine();
            Console.Write("Número de páginas: ");
            int pages = Convert.ToInt32(Console.ReadLine());

            Book newBook = new Book(title, author, pages);
            books.Add(newBook);

            Console.WriteLine("Libro registrado con éxito.");
        }

        static void ShowBook()
        {
            Console.Write("Título del libro a consultar: ");
            string title = Console.ReadLine();

            Book book = books.Find(b => b.Title == title);
            if (book == null)
            {
                Console.WriteLine("El libro no existe.");
            }
            else
            {
                book.ShowDetails();
            }
        }

        static void CheckBookPages()
        {
            Console.Write("Título del libro a consultar: ");
            string title = Console.ReadLine();

            Book book = books.Find(b => b.Title == title);
            if (book == null)
            {
                Console.WriteLine("El libro no existe.");
            }
            else
            {
                book.CheckPages();
            }
        }
    }
}


// Part 5 - Restaurant and orders

{
    class Program
    {
        static void Main()
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("MENÚ RESTAURANTE");
                Console.WriteLine("1. Registrar un nuevo pedido");
                Console.WriteLine("2. Calcular total de un pedido");
                Console.WriteLine("3. Mostrar platos de un pedido");
                Console.WriteLine("4. Salir");
                Console.Write("Opción: ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.Write("Número de mesa: ");
                        int table = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Nombre del plato: ");
                        string dish = Console.ReadLine();

                        Console.Write("Precio: ");
                        decimal price = Convert.ToDecimal(Console.ReadLine());

                        Restaurant.RegisterOrder(table, dish, price);
                        Console.WriteLine("Pedido registrado con éxito.");
                        break;

                    case "2":
                        Console.Write("Número de mesa: ");
                        int tableTotal = Convert.ToInt32(Console.ReadLine());

                        decimal total = Restaurant.CalculateTotal(tableTotal);
                        if (total == 0)
                            Console.WriteLine("No hay pedidos para esta mesa.");
                        else
                            Console.WriteLine($"Total a pagar para mesa {tableTotal}: {total}");
                        break;

                    case "3":
                        Console.Write("Número de mesa: ");
                        int tableShow = Convert.ToInt32(Console.ReadLine());

                        var orders = Restaurant.GetOrders(tableShow);
                        if (orders.Count == 0)
                            Console.WriteLine("No hay pedidos para esta mesa.");
                        else
                        {
                            Console.WriteLine($"Pedidos de la mesa {tableShow}");
                            foreach (var order in orders)
                            {
                                order.ShowInfo();
                            }
                        }
                        break;

                    case "4":
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
        }
    }
  
}

// Part 6 Parking

{   
    class Program
    {
        static void Main()
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("MENÚ PARQUEADERO");
                Console.WriteLine("1. Registrar entrada de vehículo");
                Console.WriteLine("2. Registrar salida de vehículo");
                Console.WriteLine("3. Mostrar vehículos en el parqueadero");
                Console.WriteLine("4. Salir");
                Console.Write("Opción: ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.Write("Placa: ");
                        string plate = Console.ReadLine();

                        Console.Write("Marca: ");
                        string brand = Console.ReadLine();

                        Parking.RegisterEntry(plate, brand);
                        Console.WriteLine("Vehículo registrado con éxito.");
                        break;

                    case "2":
                        Console.Write("Placa del vehículo que sale: ");
                        string exitPlate = Console.ReadLine();

                        decimal amount = Parking.RegisterExit(exitPlate);
                        if (amount == -1)
                            Console.WriteLine("Vehículo no encontrado.");
                        else
                            Console.WriteLine($"El cliente debe pagar: {amount}");
                        break;

                    case "3":
                        var vehicles = Parking.GetVehicles();
                        if (vehicles.Count == 0)
                            Console.WriteLine("No hay vehículos en el parqueadero.");
                        else
                        {
                            Console.WriteLine("Vehículos en el parqueadero");
                            foreach (var v in vehicles)
                            {
                                v.ShowInfo();
                            }
                        }
                        break;

                    case "4":
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
        }
    }
}

// Part 7 - Cinema

{
    class Program
    {
        static void Main()
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("MENÚ CINE");
                Console.WriteLine("1. Registrar nueva película");
                Console.WriteLine("2. Consultar información de una película");
                Console.WriteLine("3. Revisar si una película es larga (>120 min)");
                Console.WriteLine("4. Mostrar todas las películas");
                Console.WriteLine("5. Salir");
                Console.Write("Opción: ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.Write("Título: ");
                        string title = Console.ReadLine();

                        Console.Write("Género: ");
                        string genre = Console.ReadLine();

                        Console.Write("Duración (minutos): ");
                        int duration = Convert.ToInt32(Console.ReadLine());

                        Cinema.RegisterMovie(title, genre, duration);
                        Console.WriteLine("Película registrada con éxito.");
                        break;

                    case "2":
                        Console.Write("Título de la película: ");
                        string searchTitle = Console.ReadLine();

                        Movie movie = Cinema.FindMovie(searchTitle);
                        if (movie == null)
                            Console.WriteLine("La película no existe.");
                        else
                            movie.ShowInfo();
                        break;

                    case "3":
                        Console.Write("Título de la película: ");
                        string checkTitle = Console.ReadLine();

                        Movie longMovie = Cinema.FindMovie(checkTitle);
                        if (longMovie == null)
                            Console.WriteLine("La película no existe.");
                        else
                            longMovie.IsLong();
                        break;

                    case "4":
                        var movies = Cinema.GetMovies();
                        if (movies.Count == 0)
                            Console.WriteLine("No hay películas registradas.");
                        else
                        {
                            Console.WriteLine("LISTA DE PELÍCULAS");
                            foreach (var m in movies)
                            {
                                m.ShowInfo();
                            }
                        }
                        break;

                    case "5":
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
        }
    }

}

// Part 8 Pets

{
    class Program
    {
        static void Main()
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("MENÚ VETERINARIA");
                Console.WriteLine("1. Registrar nueva mascota");
                Console.WriteLine("2. Consultar datos de una mascota");
                Console.WriteLine("3. Revisar si una mascota es cachorro (<2 años)");
                Console.WriteLine("4. Mostrar todas las mascotas");
                Console.WriteLine("5. Salir");
                Console.Write("Opción: ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.Write("Nombre: ");
                        string name = Console.ReadLine();

                        Console.Write("Especie: ");
                        string species = Console.ReadLine();

                        Console.Write("Edad (años): ");
                        int age = Convert.ToInt32(Console.ReadLine());

                        Veterinary.RegisterPet(name, species, age);
                        Console.WriteLine("Mascota registrada con éxito.");
                        break;

                    case "2":
                        Console.Write("Nombre de la mascota: ");
                        string searchName = Console.ReadLine();

                        Pet pet = Veterinary.FindPet(searchName);
                        if (pet == null)
                            Console.WriteLine("La mascota no existe.");
                        else
                            pet.ShowInfo();
                        break;

                    case "3":
                        Console.Write("Nombre de la mascota: ");
                        string checkName = Console.ReadLine();

                        Pet puppy = Veterinary.FindPet(checkName);
                        if (puppy == null)
                            Console.WriteLine("La mascota no existe.");
                        else
                            puppy.IsPuppy();
                        break;

                    case "4":
                        var pets = Veterinary.GetPets();
                        if (pets.Count == 0)
                            Console.WriteLine("No hay mascotas registradas.");
                        else
                        {
                            Console.WriteLine("LISTA DE MASCOTAS");
                            foreach (var p in pets)
                            {
                                p.ShowInfo();
                            }
                        }
                        break;

                    case "5":
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
        }
    }
}

// Part 9  Hotel

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Sistema de Reservas del Hotel ===");

            Hotel hotel = new Hotel();

            while (true)
            {
                Console.WriteLine("Menú Principal");
                Console.WriteLine("1. Registrar reserva");
                Console.WriteLine("2. Consultar reserva");
                Console.WriteLine("3. Calcular costo de estadía");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.Write("Ingrese número de habitación: ");
                        int roomNumber = int.Parse(Console.ReadLine());

                        Console.Write("Ingrese nombre del huésped: ");
                        string guestName = Console.ReadLine();

                        Console.Write("Ingrese cantidad de noches: ");
                        int nights = int.Parse(Console.ReadLine());

                        Console.Write("Ingrese valor por noche: ");
                        double pricePerNight = double.Parse(Console.ReadLine());

                        hotel.RegisterReservation(roomNumber, guestName, nights, pricePerNight);
                        Console.WriteLine("Reserva registrada correctamente.");
                        break;

                    case "2":
                        Console.Write("Ingrese número de habitación a consultar: ");
                        int searchRoom = int.Parse(Console.ReadLine());

                        Reservation found = hotel.GetReservation(searchRoom);
                        if (found != null)
                        {
                            Console.WriteLine(found.GetInfo());
                        }
                        else
                        {
                            Console.WriteLine("No se encontró la reserva.");
                        }
                        break;

                    case "3":
                        Console.Write("Ingrese número de habitación para calcular costo: ");
                        int costRoom = int.Parse(Console.ReadLine());

                        double totalCost = hotel.CalculateTotalCost(costRoom);
                        if (totalCost > 0)
                        {
                            Console.WriteLine($"El costo total de la estadía es: {totalCost}");
                        }
                        else
                        {
                            Console.WriteLine("No se encontró la reserva.");
                        }
                        break;

                    case "4":
                        Console.WriteLine("Saliendo del sistema...");
                        return;

                    default:
                        Console.WriteLine("Opción inválida. Intente nuevamente.");
                        break;
                }
            }
        }
    }
}

// Part 10 Clinic

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sistema de Citas Médicas");

            Clinic clinic = new Clinic();

            while (true)
            {
                Console.WriteLine("Menú:");
                Console.WriteLine("1. Registrar cita");
                Console.WriteLine("2. Consultar cita");
                Console.WriteLine("3. Días restantes para la cita");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");

                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.Write("Ingrese nombre del paciente: ");
                        string patientName = Console.ReadLine();

                        Console.Write("Ingrese especialidad: ");
                        string specialty = Console.ReadLine();

                        Console.Write("Ingrese fecha de la cita (AAAA-MM-DD): ");
                        DateTime appointmentDate = DateTime.Parse(Console.ReadLine());

                        clinic.RegisterAppointment(patientName, specialty, appointmentDate);
                        Console.WriteLine("Cita registrada con éxito.");
                        break;

                    case "2":
                        Console.Write("Ingrese nombre del paciente: ");
                        string searchName = Console.ReadLine();

                        Appointment found = clinic.GetAppointment(searchName);
                        if (found != null)
                        {
                            Console.WriteLine(found.GetInfo());
                        }
                        else
                        {
                            Console.WriteLine("No se encontró la cita.");
                        }
                        break;

                    case "3":
                        Console.Write("Ingrese nombre del paciente: ");
                        string nameDays = Console.ReadLine();

                        Appointment app = clinic.GetAppointment(nameDays);
                        if (app != null)
                        {
                            int days = app.DaysUntilAppointment();
                            if (days >= 0)
                                Console.WriteLine($"Faltan {days} días para la cita.");
                            else
                                Console.WriteLine("La fecha de la cita ya pasó.");
                        }
                        else
                        {
                            Console.WriteLine("No se encontró la cita.");
                        }
                        break;

                    case "4":
                        Console.WriteLine("Saliendo del sistema...");
                        return;

                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }
            }
        }
    }
}