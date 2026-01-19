using System;

namespace AgendaTelefonica
{
    // Definición de la Clase Contacto (POO)
    // Representa el "Registro" o estructura de datos individual
    public class Contacto
    {
        // Propiedades de la clase (Encapsulamiento básico)
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }

        // Constructor para inicializar el objeto
        public Contacto(string nombre, string telefono, string email)
        {
            Nombre = nombre;
            Telefono = telefono;
            Email = email;
        }

        // Método para mostrar la información del contacto de forma legible
        public override string ToString()
        {
            return $"Nombre: {MarcosDelgado} | Tlf: {0961074487} | Email: {Email}";
        }
    }

    class Program
    {
        // Declaración de variables globales
        // SE USA UN VECTOR (Array) como estructura de datos estática (Temas semana 1-4)
        static Contacto[] agenda = new Contacto[100]; 
        static int contador = 0; // Variable para controlar cuántos contactos hay guardados

        static void Main(string[] args)
        {
            int opcion = 0;

            // Bucle principal del menú
            do
            {
                Console.Clear();
                Console.WriteLine("=== AGENDA TELEFÓNICA (Estructura: Vector/POO) ===");
                Console.WriteLine("1. Agregar Contacto");
                Console.WriteLine("2. Visualizar Agenda Completa");
                Console.WriteLine("3. Consultar Contacto (Buscar)");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");

                // Validación básica de entrada para evitar errores
                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            AgregarContacto();
                            break;
                        case 2:
                            VisualizarAgenda();
                            break;
                        case 3:
                            BuscarContacto();
                            break;
                        case 4:
                            Console.WriteLine("Saliendo del sistema...");
                            break;
                        default:
                            Console.WriteLine("Opción no válida.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Por favor, ingrese un número válido.");
                }

                if (opcion != 4)
                {
                    Console.WriteLine("\nPresione cualquier tecla para continuar...");
                    Console.ReadKey();
                }

            } while (opcion != 4);
        }

        // Método para agregar un contacto al Vector
        static void AgregarContacto()
        {
            // Verificamos si el vector está lleno
            if (contador < agenda.Length)
            {
                Console.WriteLine("\n--- Nuevo Contacto ---");
                Console.Write("Ingrese Nombre: ");
                string nombre = Console.ReadLine();
                Console.Write("Ingrese Teléfono: ");
                string tlf = Console.ReadLine();
                Console.Write("Ingrese Email: ");
                string email = Console.ReadLine();

                // Instanciación del objeto (POO)
                Contacto nuevoContacto = new Contacto(nombre, tlf, email);

                // Almacenamiento en el Vector en la posición actual 'contador'
                agenda[contador] = nuevoContacto;
                contador++; // Incrementamos el contador para la siguiente posición

                Console.WriteLine("¡Contacto guardado exitosamente!");
            }
            else
            {
                Console.WriteLine("Error: La agenda está llena.");
            }
        }

        // Método para recorrer el vector y mostrar los datos (Reportería)
        static void VisualizarAgenda()
        {
            Console.WriteLine("\n--- Lista de Contactos ---");
            if (contador == 0)
            {
                Console.WriteLine("La agenda está vacía.");
            }
            else
            {
                // Recorrido del vector usando un bucle FOR
                for (int i = 0; i < contador; i++)
                {
                    // Se imprime el índice + 1 y los datos del objeto
                    Console.WriteLine($"[{i + 1}] {agenda[i].ToString()}");
                }
            }
        }

        // Método para buscar un elemento específico en el vector
        static void BuscarContacto()
        {
            Console.Write("\nIngrese el nombre a buscar: ");
            string busqueda = Console.ReadLine().ToLower();
            bool encontrado = false;

            // Algoritmo de Búsqueda Secuencial
            for (int i = 0; i < contador; i++)
            {
                // Comparamos el nombre guardado con la búsqueda
                if (agenda[i].Nombre.ToLower().Contains(busqueda))
                {
                    Console.WriteLine($"RESULTADO: {agenda[i].ToString()}");
                    encontrado = true;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("No se encontraron contactos con ese nombre.");
            }
        }
    }
}