# sprint-1-activity-3

# Proyecto: Objetos en C#

## Descripción
Este proyecto en **C# (.NET 8.0)** implementa un conjunto de clases que representan distintos objetos de la vida real (Banco, Restaurante, Estudiantes, Hotel, etc.).  
Cada clase encapsula atributos y métodos relacionados, y el programa principal (`Program.cs`) permite interactuar con ellos mediante un **menú en consola**.

El objetivo es practicar:
- **Programación Orientada a Objetos (POO)** en C#.
- Creación y uso de clases.
- Abstracción de problemas reales a código.
- Gestión de múltiples entidades desde un programa principal.

---

## Estructura del Proyecto
Objetos/
│── Objetos.csproj # Configuración del proyecto .NET
│── Program.cs # Programa principal con el menú
│── Class/ # Carpeta con todas las clases
│ ├── Bank.cs
│ ├── Calculator.cs
│ ├── Cinema.cs
│ ├── Clinic.cs
│ ├── Hotel.cs
│ ├── Library.cs
│ ├── Parking.cs
│ ├── Pets.cs
│ ├── Restaurant.cs
│ ├── Store.cs
│ ├── Students.cs

## Instalación y Ejecución

1. Clonar este repositorio o descomprimir el `.zip`:
   ```bash
   git clone <URL_REPO>
   cd Objetos
2. Compilar el proyecto:

- bash
- Copiar código
- dotnet build

3. Ejecutar en consola:

- bash
- dotnet run

# Clases Implementadas

Cada clase representa un objeto del mundo real:

- Bank → Manejo de cuentas y depósitos.

- Calculator → Operaciones matemáticas.

- Cinema → Gestión de funciones y entradas.

- Clinic → Control de pacientes y citas médicas.

- Hotel → Reservas y habitaciones.

- Library → Gestión de préstamos de libros.

- Parking → Administración de parqueadero.

- Pets → Registro y control de mascotas.

- Restaurant  → Pedidos y gestión de mesas.

- Store → Manejo de inventario.

- Students → Registro de notas y estudiantes.

# Próximos pasos
- Implementar persistencia de datos con archivos o base de datos.

- Agregar pruebas unitarias.

- Mejorar la interfaz de usuario en consola.
