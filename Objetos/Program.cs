using Objetos.Class;

// calculator

// Calculator calculator = new Calculator();
//
// Console.WriteLine("Ingresa numero 1: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Ingresa numero 2: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Ingresa la operación que quieres realizar: ");
// String c = Console.ReadLine();
//
// if (c == "+")
// {
//     int result = calculator.sum(a,b,c);
//     Console.WriteLine($"Tu Resultado es: {result}");
// }
// else if (c == "-")
// {
//     int result = calculator.rest(a,b,c);
//     Console.WriteLine($"Tu Resultado es: {result}");
// }
// else if (c == "*")
// {
//     int result = calculator.multiply(a, b, c);
//     Console.WriteLine($"Tu Resultado es: {result}");
// }
// else if (c == "/")
// {
//     if (b == 0)
//     {
//         throw new DivideByZeroException("No se puede dividir entre 0.");
//     }
//     else
//     {
//         decimal result = calculator.divide(a, b, c);
//         Console.WriteLine($"Tu Resultado es: {result}");
//     }
// }
// else
// {
//     throw new ArgumentException("Operación no válida.");
// }


// students

// Students student = new Students();
//
// bool running = true;
//
//
// while (running)
// {
//     student.menu();
//     Console.WriteLine("Elige una opción: ");
//     int option =  Convert.ToInt32(Console.ReadLine());
//
//     switch (option)
//     {
//         case 1:
//             Console.WriteLine("Nombre del estudiante: ");
//             string nameStudent = Console.ReadLine();
//             Console.WriteLine("Edad del estudiante: ");
//             int ageStudent = Convert.ToInt32(Console.ReadLine());
//             Console.WriteLine("Grado escolar del estudiante: ");
//             int gradeStudent = Convert.ToInt32(Console.ReadLine());
//             
//             student.add(nameStudent, ageStudent, gradeStudent);
//             Console.WriteLine($"Estudinate {nameStudent} registrado exitosamente");
//             break;
//         
//         case 2:
//             student.list();
//             break;
//         
//         case 3:
//             running = false;
//             Console.WriteLine("Saliendo del sistema...");
//             break;
//         
//         default:
//             Console.WriteLine("Opción no válida.");
//             break;
//     }
// }


// Bank
//
// Bank bank = new Bank();
//
// bool running = true;
//
// while (running)
// {
//     bank.menu();
//     Console.WriteLine("Elige una opción: "); 
//     int option =  Convert.ToInt32(Console.ReadLine());
//
//     switch (option)
//     {
//         case 1:
//             Console.WriteLine("Numero de cuenta: ");
//             int account = Convert.ToInt32(Console.ReadLine());
//             Console.WriteLine("Nombre del dueño: ");
//             string name = Console.ReadLine();
//             Console.WriteLine("Saldo: ");
//             decimal salary = decimal.Parse(Console.ReadLine());
//             
//             bank.add(account, name, salary);
//             Console.WriteLine($"Cuenta del dueño {name} creada con exito");
//             break;
//         case 2:
//             Console.WriteLine("Nombre del dueño de la cuenta a consultar: ");
//             string ownerName = Console.ReadLine();
//             decimal balance = bank.consultBalance(ownerName);
//             Console.WriteLine($"El saldo de {ownerName} es: {balance}");
//             break;
//         case 3:
//             Console.WriteLine("Nombre del dueño de la cuenta a depositar: ");
//             string ownerNameB = Console.ReadLine();
//             Console.WriteLine("Saldo a ingresar: ");
//             decimal moneyAccount = decimal.Parse(Console.ReadLine()); 
//             decimal newBalance = bank.depositMoney(ownerNameB, moneyAccount);
//
//             if (newBalance > 0)
//             {
//                 Console.WriteLine($"Cuenta de {ownerNameB} se agrego {moneyAccount} y el total es de {newBalance}");
//             }
//             break;
//         case 4:
//             running = false;
//             Console.WriteLine("Saliendo del sistema...");
//             break;
//         default:
//             Console.WriteLine("Opción invalida");
//             break;
//     }
//}


// Store
//
// Store product = new Store();
//
// bool running = true;
//
// while (running)
// {
//     product.menu();
//     Console.WriteLine("Elige una opción: "); 
//     int option =  Convert.ToInt32(Console.ReadLine());
//
//     switch (option)
//     {
//         case 1:
//             Console.WriteLine("Nombre del producto: ");
//             string nameProduct = Console.ReadLine();
//             Console.WriteLine("Precio: ");
//             decimal priceProduct = decimal.Parse(Console.ReadLine());
//             Console.WriteLine("Cantidad: ");
//             int quantityProduct = Convert.ToInt32(Console.ReadLine());
//             
//             product.add(nameProduct, priceProduct, quantityProduct);
//             Console.WriteLine($"Producto {nameProduct} registrado exitosamente");
//             break;
//         case 2:
//             Console.WriteLine("Nombre del producto a consultar: ");
//             string nameProductConsult = Console.ReadLine();
//             Store productConsult = product.consultProduct(nameProductConsult);
//             if (productConsult != null)
//             {
//                 Console.WriteLine($"Producto {nameProductConsult} tiene un precio de {productConsult.price} y una cantidad de {productConsult.quantity}");
//             }
//             else
//             {
//                 Console.WriteLine("Producto no encontrado.");
//             }
//             break;
//         
//         case 3:
//             Console.WriteLine("Nombre del producto a vender: ");
//             string nameProductSell = Console.ReadLine();
//             Console.WriteLine("Cantidad a vender: ");
//             int quantityProductSell = Convert.ToInt32(Console.ReadLine());
//             
//             int newQuantity = product.Sell(nameProductSell, quantityProductSell);
//
//             if (newQuantity > 0)
//             {
//                  Console.WriteLine($"se vendieron {quantityProductSell} del producto {nameProductSell} quedan en stock {newQuantity}");
//             }
//             else
//             {
//                 Console.WriteLine("No se pudo realizar la venta.");
//             }
//             break;
//         case 4:
//             running = false;
//             Console.WriteLine("Saliendo del sistema...");
//             break;
//     }
// }


// Library

// Library library = new Library();
//
// bool running = true;
//
// while (running)
// {
//     library.menu();
//     Console.WriteLine("Elije una opción: ");
//     int option =  Convert.ToInt32(Console.ReadLine());
//     
//     switch (option)
//     {
//         case 1:
//             Console.WriteLine("Titulo del libro: ");
//             string title = Console.ReadLine();
//             Console.WriteLine("Autor del libro: ");
//             string author = Console.ReadLine();
//             Console.WriteLine("Numero de paginas: ");
//             int numberPages = Convert.ToInt32(Console.ReadLine());
//             
//             library.add(title, author, numberPages);
//             Console.WriteLine($"Libro {title} registrado exitosamente");
//             break;
//         case 2:
//             Console.WriteLine("Titulo del libro a consultar: ");
//             string titleConsult = Console.ReadLine();
//             Library libraryConsult = library.consultBook(titleConsult);
//             if (libraryConsult != null)
//             {
//                 Console.WriteLine($"Libro: {titleConsult} su autor es: {libraryConsult.author} y tiene: {libraryConsult.numberPages} paginas");
//             }
//             else
//             {
//                 Console.WriteLine("Libro no encontrado.");
//             }
//             break;
//         case 3:
//             Console.WriteLine("Titulo del libro a consultar numero de paginas: ");
//             string titlePages = Console.ReadLine();
//             bool hasMoreThan300 = library.isMoreThan300Pages(titlePages);
//             if (hasMoreThan300)
//             {
//                 Console.WriteLine($"El libro {titlePages} tiene mas de 300 paginas.");
//             }
//             else
//             {
//                 Console.WriteLine($"El libro {titlePages} tiene menos de 300 paginas.");
//             }
//             break;
//         case 4:
//             running = false;
//             Console.WriteLine("Saliendo del sistema...");
//             break;
//     }
// }


// Restaurant

// Restaurant restaurant = new Restaurant();
//
// bool running = true;
//
// while (running)
// {
//     restaurant.menu();
//     Console.WriteLine("Elije una opción");
//     int option =  Convert.ToInt32(Console.ReadLine());
//     
//     switch (option)
//     {
//         case 1:
//             Console.WriteLine("Nombre del plato: ");
//             string nameFood = Console.ReadLine();
//             Console.WriteLine("Numero de mesa: ");
//             int quantityTable = Convert.ToInt32(Console.ReadLine());
//             Console.WriteLine("Precio del plato: ");
//             decimal priceFood = decimal.Parse(Console.ReadLine());
//             
//             restaurant.add(nameFood, quantityTable, priceFood);
//             Console.WriteLine($"Plato {nameFood} registrado exitosamente");
//             break;
//         case 2:
//             Console.WriteLine("Numero de mesa: ");
//             int tableNumber = Convert.ToInt32(Console.ReadLine());
//
//             decimal finalOrder = restaurant.totalOrder(tableNumber);
//             
//             Console.WriteLine($"El total de la orden de la mesa: {tableNumber} es: {finalOrder}");
//             break;
//         case 3:
//             Console.Write("Número de mesa: ");
//             if (!int.TryParse(Console.ReadLine(), out int mesa))
//             {
//                 Console.WriteLine("Número inválido.");
//                 break;
//             }
//             restaurant.orderlist(mesa, true);
//             break;
//         case 4:
//             running = false;
//             Console.WriteLine("Saliendo del sistema...");
//             break;
//         default:
//             Console.WriteLine("Opción no válida.");
//             break;
//     }
// }


//Parking

// Parking parkingSystem = new Parking();
// bool running = true;
//
// while (running)
// {
//     parkingSystem.menu();
//     Console.Write("Elige una opción: ");
//     if (!int.TryParse(Console.ReadLine(), out int option))
//     {
//         Console.WriteLine("Opción inválida.");
//         continue;
//     }
//
//     switch (option)
//     {
//         case 1:
//             Console.Write("Placa: ");
//             string plateIn = Console.ReadLine();
//             Console.Write("Marca: ");
//             string brandIn = Console.ReadLine();
//             parkingSystem.add(plateIn, brandIn);
//             Console.WriteLine("Entrada registrada.");
//             break;
//
//         case 2:
//             Console.Write("Placa: ");
//             string plateOut = Console.ReadLine();
//             parkingSystem.registerExit(plateOut);
//             Console.WriteLine("Salida registrada.");
//             break;
//
//         case 3:
//             Console.Write("Placa: ");
//             string plateValue = Console.ReadLine();
//             decimal total = parkingSystem.valueParking(plateValue);
//             Console.WriteLine($"Total a pagar: {total}");
//             break;
//
//         case 4:
//             running = false;
//             Console.WriteLine("Saliendo del sistema...");
//             break;
//
//         default:
//             Console.WriteLine("Opción no válida.");
//             break;
//     }
// }


// Cinema

// Cinema cinema = new Cinema();
//
// bool running = true;
//
// while (running)
// {
//     cinema.menu();
//     Console.WriteLine("Elije una opción: ");
//     int option =  Convert.ToInt32(Console.ReadLine());
//
//     switch (option)
//     {
//         case 1:
//             Console.WriteLine("Titulo de la pelicula: ");
//             string title = Console.ReadLine();
//             Console.WriteLine("Genero de la pelicula: ");
//             string genre = Console.ReadLine();
//             Console.WriteLine("Duracion de la pelicula en minutos: ");
//             int duration = Convert.ToInt32(Console.ReadLine());
//
//             cinema.add(title, genre, duration);
//             Console.WriteLine($"Pelicula {title} registrada exitosamente");
//             break;
//         case 2:
//             Console.WriteLine("Titulo de la pelicula a consultar: ");
//             string titleConsult = Console.ReadLine();
//             Cinema cinemaConsult = cinema.consultMovie(titleConsult);
//             if (cinemaConsult != null)
//             {
//                 Console.WriteLine(
//                     $"Pelicula: {titleConsult} su genero es: {cinemaConsult.genre} y tiene: {cinemaConsult.duration} minutos");
//             }
//             else
//             {
//                 Console.WriteLine("Pelicula no encontrado.");
//             }
//             break;
//         case 3:
//             Console.WriteLine("Titulo de la pelicula a consultar su duracion: ");
//             string titleDuration = Console.ReadLine();
//             int durationConsult = cinema.durationMovie(titleDuration);
//             if (durationConsult > 120)
//             {
//                 Console.WriteLine($"La duracion de la pelicula {titleDuration} es: {durationConsult} minutos, quiere decir pelicula larga");
//             }
//             else
//             {
//                 Console.WriteLine($"La pelicula {titleDuration} tiene una duracion de {durationConsult} minutos, quiere decir pelicula corta.");
//             }
//             break;
//         case 4:
//             running = false;
//             Console.WriteLine("Saliendo del sistema...");
//             break;
//     }
// }


// Pets

// Pets pets = new Pets();
//
// bool running = true;
//
// while (running)
// {
//     pets.menu();
//     Console.WriteLine("Elije una opción: ");
//     int option =  Convert.ToInt32(Console.ReadLine());
//
//     switch (option)
//     {
//         case 1:
//             Console.WriteLine("Nombre del mascota: ");
//             string namePet = Console.ReadLine();
//             Console.WriteLine("Especie de la mascota: ");
//             string breedPet = Console.ReadLine();
//             Console.WriteLine("Edad de la mascota: ");
//             int agePet = Convert.ToInt32(Console.ReadLine());
//             
//             pets.add(namePet, breedPet, agePet);
//             Console.WriteLine($"Mascota {namePet} registrada exitosamente");
//             break;
//         case 2:
//             Console.WriteLine("Nombre de la mascota a consultar: ");
//             string nameConsult = Console.ReadLine();
//             Pets petConsult = pets.listPet(nameConsult);
//             if (petConsult != null)
//             {
//                 Console.WriteLine($"La mascota {petConsult.namePet} es de especie: {petConsult.breed} y tiene {petConsult.age} años");
//             }
//             else
//             {
//                 Console.WriteLine("Mascota no encontrada.");
//             }
//             break;
//         case 3:
//             Console.WriteLine("Nombre de la mascota a consultar su edad: ");
//             string nameAge = Console.ReadLine();
//             int agePetConsult = pets.agePet(nameAge);
//             if (agePetConsult < 2)
//             {
//                 Console.WriteLine($" tu mascota {pets.namePet} es un cachorr@");
//             }
//             else
//             {
//                 Console.WriteLine($" tu mascota {pets.namePet} es un adulto");
//             }
//             break;
//         case 4:
//             running = false;
//             Console.WriteLine("Saliendo del sistema...");
//             break;
//     }
// }


//Hotel

// Hotel hotel = new Hotel();
//
// bool running = true;
//
// while (running)
// {
//     hotel.menu();
//     Console.WriteLine("Elije una opción");
//     int option =  Convert.ToInt32(Console.ReadLine());
//
//     switch (option)
//     {
//         case 1:
//             Console.WriteLine("Nombre del huesped: ");
//             string nameGuest = Console.ReadLine();
//             Console.WriteLine("Numero de habitación: ");
//             int numberRoom = Convert.ToInt32(Console.ReadLine());
//             Console.WriteLine("Cantidad de noches: ");
//             int quantityNight = Convert.ToInt32(Console.ReadLine());
//             
//             hotel.add(numberRoom, nameGuest, quantityNight);
//             Console.WriteLine($"Huesped {nameGuest} registrado exitosamente");
//             break;
//         case 2:
//             Console.WriteLine("Nombre del huesped en la reserva: ");
//             string nameGuestConsult = Console.ReadLine();
//             Hotel guestConsult = hotel.consultHotel(nameGuestConsult);
//             if (guestConsult != null)
//             {
//                 Console.WriteLine($"La reserva del señor@ {guestConsult.nameGuest} de {guestConsult.quantityNights} noches ubicado en la habitacion # {guestConsult.numberRooms}");
//             }
//             else
//             {
//                 Console.WriteLine("Huesped no encontrado.");
//             }
//             break;
//         case 3:
//             Console.WriteLine("Numero de habitación para pagar reserva: ");
//             if (!int.TryParse(Console.ReadLine(), out int roomToPay))
//             {
//                 Console.WriteLine("Número inválido.");
//                 break;
//             }
//
//             var reservation = hotel.consultHotelByRoom(roomToPay);
//             if (reservation == null)
//             {
//                 Console.WriteLine("Huesped no encontrado.");
//                 break;
//             }
//
//             Console.Write("Tarifa por noche: ");
//             if (!decimal.TryParse(Console.ReadLine(), out decimal ratePerNight))
//             {
//                 Console.WriteLine("Tarifa inválida.");
//                 break;
//             }
//
//             decimal guestCost = hotel.cost(roomToPay, ratePerNight);
//             Console.WriteLine($"El costo de las {reservation.quantityNights} noches del huesped {reservation.nameGuest} (habitación #{reservation.numberRooms}) es {guestCost}");
//             break;
//         case 4:
//             running = false;
//             Console.WriteLine("Saliendo del sistema...");
//             break;
//     }
// }


// Clinic

// Clinic clinic = new Clinic();
// bool runningClinic = true;
//
// while (runningClinic)
// {
//     clinic.menu();
//     Console.Write("Elige una opción: ");
//     if (!int.TryParse(Console.ReadLine(), out int option))
//     {
//         Console.WriteLine("Opción inválida.");
//         continue;
//     }
//
//     switch (option)
//     {
//         case 1:
//             Console.Write("Nombre del paciente: ");
//             string namePatient = Console.ReadLine();
//             Console.Write("Especialidad: ");
//             string specialty = Console.ReadLine();
//             Console.Write("Fecha de la cita (yyyy-MM-dd): ");
//             if (!DateTime.TryParse(Console.ReadLine(), out DateTime date))
//             {
//                 Console.WriteLine("Fecha inválida.");
//                 break;
//             }
//             clinic.add(namePatient, specialty, date);
//             Console.WriteLine($"Cita registrada para {namePatient} el {date:yyyy-MM-dd} en {specialty}.");
//             break;
//
//         case 2:
//             Console.Write("Nombre del paciente a consultar: ");
//             string nameToConsult = Console.ReadLine();
//             var appointment = clinic.consultClinic(nameToConsult);
//             if (appointment != null)
//             {
//                 Console.WriteLine($"Paciente: {appointment.namePatient}, Especialidad: {appointment.specialty}, Fecha: {appointment.dateAppointment:yyyy-MM-dd}");
//             }
//             else
//             {
//                 Console.WriteLine("Paciente no encontrado.");
//             }
//             break;
//
//         case 3:
//             Console.Write("Nombre del paciente para calcular días restantes: ");
//             string nameForDays = Console.ReadLine();
//             int daysLeft = clinic.missingDays(nameForDays);
//             Console.WriteLine($"Faltan {daysLeft} día(s) para la cita.");
//             break;
//
//         case 4:
//             runningClinic = false;
//             Console.WriteLine("Saliendo del sistema...");
//             break;
//
//         default:
//             Console.WriteLine("Opción no válida.");
//             break;
//     }
// }
