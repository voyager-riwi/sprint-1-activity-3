# 🎯 Sprint 1 - Activity 3

Este proyecto en **C# (.NET 6.0)** contiene una colección de **10 ejercicios prácticos** que simulan sistemas reales (banco, tienda, cine, restaurante, clínica, etc.), aplicando conceptos de **Programación Orientada a Objetos (POO)** como encapsulación, abstracción y modularidad.

---

## 📂 Project Structure

```
Sprint-1-activity-3/
│── Clases/
│   ├── Bank.cs
│   ├── Cinema.cs
│   ├── Clinic.cs
│   ├── Hotel.cs
│   ├── Library.cs
│   ├── Parking.cs
│   ├── Pets.cs
│   ├── Restaurant.cs
│   ├── Store.cs
│   ├── Students.cs
│
│── Program.cs
│── README.md
```

---

## ⚙️ Installation & Setup

### 🔹 Requirements
- [.NET SDK 6.0+](https://dotnet.microsoft.com/download)
- IDE o editor de texto (Visual Studio, Rider, VS Code)

### 🔹 Run the Program
Clona el repositorio y ejecuta el programa desde la terminal:

bash
git clone https://github.com/voyager-riwi/sprint-1-activity-3.git
cd Sprint-1-activity-3
dotnet run


---

## 🚀 Features (10 ejercicios incluidos)

1. **Students 👩‍🎓**  
   Registrar estudiantes, almacenar datos (nombre, edad, grado) y listarlos.  

2. **Bank 🏦**  
   Abrir cuentas, consultar saldo y realizar depósitos.  

3. **Store 🛍️**  
   Registrar productos, consultar detalles y realizar ventas.  

4. **Library 📚**  
   Registrar libros, consultar información y validar si superan 300 páginas.  

5. **Restaurant 🍽️**  
   Registrar pedidos, calcular totales por mesa y mostrar platos.  

6. **Parking 🚗**  
   Registrar entrada/salida de vehículos y calcular cobros.  

7. **Cinema 🎬**  
   Registrar películas, consultar info, validar duración (>120 min) y listar todas.  

8. **Pets 🐶**  
   Registrar mascotas, consultar datos y verificar si son cachorros (<2 años).  

9. **Hotel 🏨**  
   Registrar reservas, consultar información y calcular costos de estadía.  

10. **Clinic 🏥**  
    Registrar citas médicas, consultar citas y calcular días restantes.  

---

## 🖥️ Usage Flow

Cuando ejecutes el programa, desde `Program.cs` podrás acceder a cada ejercicio según el menú correspondiente.  
Cada módulo tiene su propio **sub-menú interactivo en consola**.

Ejemplo (Banco 🏦):  
- Abrir una nueva cuenta  
- Consultar saldo  
- Depositar dinero  
- Salir  

---

## 🧑‍💻 OOP Justification

Este proyecto demuestra cómo aplicar **POO** para modelar situaciones reales:

- **Clases como entidades:** `Student`, `Account`, `Book`, `Movie`, etc.  
- **Encapsulación:** Cada módulo administra sus propios datos de manera aislada.  
- **Abstracción:** La lógica se maneja en clases, manteniendo `Program.cs` como punto de entrada.  
- **Escalabilidad:** Fácil de extender (más funcionalidades por módulo o nuevos sistemas).  

---

## 🛠️ Technologies Used

- **C# 10 / .NET 6.0**  
- **List<T>** para colecciones dinámicas  
- **Console-based UI**  

---

## ✨ Authors

Desarrollado con ❤️ por **[Brahiam Ruiz Alzate]**
