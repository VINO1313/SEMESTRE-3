using System;

// Namespace para organizar las clases
namespace CalculoDeFiguras
{
    /// <summary>
    /// Clase Circulo: Encapsula el radio y proporciona métodos para calcular área y perímetro.
    /// </summary>
    public class Circulo
    {
        // ----------------------------------------------------
        // ENCAPSULAMIENTO DE DATOS PRIMITIVOS
        // ----------------------------------------------------

        // El 'radio' es el dato primitivo clave para definir el círculo.
        // Se declara como 'private' para encapsularlo (solo accesible desde dentro de la clase).
        private double radio;

        // Propiedad pública (Radius) para acceder y modificar el valor del radio de forma controlada.
        // Esto permite la encapsulación.
        public double Radius
        {
            // El 'get' permite obtener el valor del radio.
            get { return radio; }
            // El 'set' permite establecer el valor del radio, con una validación simple (opcional).
            set
            {
                if (value > 0)
                {
                    radio = value;
                }
                else
                {
                    // Manejo de error simple si el radio no es positivo
                    Console.WriteLine("El radio debe ser un valor positivo.");
                }
            }
        }

        // ----------------------------------------------------
        // CONSTRUCTOR
        // ----------------------------------------------------

        // Constructor de la clase Circulo.
        // Se utiliza para inicializar la clase con un radio inicial.
        public Circulo(double radioInicial)
        {
            // Llama al setter de la propiedad 'Radius' para asegurar la validación.
            Radius = radioInicial;
        }

        // ----------------------------------------------------
        // MÉTODOS DE CÁLCULO
        // ----------------------------------------------------

        /// <summary>
        /// Método para calcular el área del círculo.
        /// Fórmula: Area = π * radio²
        /// </summary>
        /// <returns>El área del círculo como un valor double.</returns>
        public double CalcularArea()
        {
            // Math.PI proporciona el valor de Pi.
            // La función devuelve el valor double resultante de la operación.
            return Math.PI * radio * radio;
        }

        /// <summary>
        /// Método para calcular el perímetro (circunferencia) del círculo.
        /// Fórmula: Perímetro = 2 * π * radio
        /// </summary>
        /// <returns>El perímetro del círculo como un valor double.</returns>
        public double CalcularPerimetro()
        {
            // La función devuelve el valor double resultante de la operación.
            return 2 * Math.PI * radio;
        }
    }

    /// <summary>
    /// Clase Rectangulo: Encapsula el largo y el ancho, y proporciona métodos para calcular área y perímetro.
    /// </summary>
    public class Rectangulo
    {
        // ----------------------------------------------------
        // ENCAPSULAMIENTO DE DATOS PRIMITIVOS
        // ----------------------------------------------------

        // Los datos primitivos 'largo' y 'ancho' se declaran como 'private'.
        private double largo;
        private double ancho;

        // Propiedad pública 'Largo' para encapsular el campo 'largo'.
        public double Largo
        {
            get { return largo; }
            set { largo = value > 0 ? value : 0; } // Asignación con chequeo simple
        }

        // Propiedad pública 'Ancho' para encapsular el campo 'ancho'.
        public double Ancho
        {
            get { return ancho; }
            set { ancho = value > 0 ? value : 0; } // Asignación con chequeo simple
        }

        // ----------------------------------------------------
        // CONSTRUCTOR
        // ----------------------------------------------------

        // Constructor que requiere el largo y el ancho para inicializar la clase.
        public Rectangulo(double largoInicial, double anchoInicial)
        {
            Largo = largoInicial;
            Ancho = anchoInicial;
        }

        // ----------------------------------------------------
        // MÉTODOS DE CÁLCULO
        // ----------------------------------------------------

        /// <summary>
        /// Método para calcular el área del rectángulo.
        /// Fórmula: Área = Largo * Ancho
        /// </summary>
        /// <returns>El área del rectángulo como un valor double.</returns>
        public double CalcularArea()
        {
            // El método utiliza los campos internos de la clase (largo y ancho).
            return largo * ancho;
        }

        /// <summary>
        /// Método para calcular el perímetro del rectángulo.
        /// Fórmula: Perímetro = 2 * (Largo + Ancho)
        /// </summary>
        /// <returns>El perímetro del rectángulo como un valor double.</returns>
        public double CalcularPerimetro()
        {
            // La función devuelve el valor double resultante.
            return 2 * (largo + ancho);
        }
    }

    // ----------------------------------------------------
    // CLASE PRINCIPAL (OPCIONAL: para probar el código)
    // ----------------------------------------------------

    public class Program
    {
        // Método principal donde se ejecuta la aplicación.
        public static void Main(string[] args)
        {
            // Crear una instancia de Circulo con un radio de 5.
            Circulo miCirculo = new Circulo(5.0);

            // Se accede al radio a través de la propiedad pública 'Radius'.
            Console.WriteLine($"\n--- Círculo (Radio: {miCirculo.Radius}) ---");

            // Llamar al método para calcular el área.
            // CalcularArea es una función que devuelve un valor double, se utiliza para calcular el área del círculo.
            double areaCirculo = miCirculo.CalcularArea();
            Console.WriteLine($"Área del Círculo: {areaCirculo:F2}");

            // Llamar al método para calcular el perímetro.
            // CalcularPerimetro es una función que devuelve un valor double, se utiliza para calcular el perímetro del círculo.
            double perimetroCirculo = miCirculo.CalcularPerimetro();
            Console.WriteLine($"Perímetro del Círculo: {perimetroCirculo:F2}");

            // Crear una instancia de Rectangulo con largo 10 y ancho 4.
            Rectangulo miRectangulo = new Rectangulo(10.0, 4.0);

            Console.WriteLine($"\n--- Rectángulo (Largo: {miRectangulo.Largo}, Ancho: {miRectangulo.Ancho}) ---");

            // Llamar al método para calcular el área.
            // CalcularArea es una función que devuelve un valor double, se utiliza para calcular el área del rectángulo.
            double areaRectangulo = miRectangulo.CalcularArea();
            Console.WriteLine($"Área del Rectángulo: {areaRectangulo:F2}");

            // Llamar al método para calcular el perímetro.
            // CalcularPerimetro es una función que devuelve un valor double, se utiliza para calcular el perímetro del rectángulo.
            double perimetroRectangulo = miRectangulo.CalcularPerimetro();
            Console.WriteLine($"Perímetro del Rectángulo: {perimetroRectangulo:F2}");
        }
    }
}