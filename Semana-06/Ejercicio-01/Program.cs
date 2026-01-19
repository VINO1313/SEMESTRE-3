using System;

// Definición del Nodo
public class Nodo
{
    public int Dato { get; set; }
    public Nodo Siguiente { get; set; }
    
    public Nodo(int dato)
    {
        Dato = dato;
        Siguiente = null;
    }
}

public class ListaEnlazada
{
    private Nodo cabeza;
    
    // Método para agregar elementos
    public void Agregar(int dato)
    {
        Nodo nuevoNodo = new Nodo(dato);
        if (cabeza == null)
        {
            cabeza = nuevoNodo;
        }
        else
        {
            Nodo actual = cabeza;
            while (actual.Siguiente != null)
            {
                actual = actual.Siguiente;
            }
            actual.Siguiente = nuevoNodo;
        }
    }
    
    // Función que calcula el número de elementos (recorriendo la lista)
    public int CalcularLongitud()
    {
        int contador = 0;
        Nodo actual = cabeza;
        
        // Recorremos la lista hasta el final
        while (actual != null)
        {
            contador++;
            actual = actual.Siguiente; // "Saltamos" al siguiente nodo
        }
        
        return contador;
    }
    
    // Versión recursiva
    public int CalcularLongitudRecursiva()
    {
        return CalcularLongitudRecursiva(cabeza);
    }
    
    private int CalcularLongitudRecursiva(Nodo nodoActual)
    {
        if (nodoActual == null)
        {
            return 0;
        }
        return 1 + CalcularLongitudRecursiva(nodoActual.Siguiente);
    }
    
    // Método para mostrar la lista
    public void Mostrar()
    {
        Nodo actual = cabeza;
        Console.Write("Lista: ");
        while (actual != null)
        {
            Console.Write(actual.Dato + " -> ");
            actual = actual.Siguiente;
        }
        Console.WriteLine("null");
    }
}

// Programa principal
class Program
{
    static void Main(string[] args)
    {
        ListaEnlazada lista = new ListaEnlazada();
        
        Console.WriteLine("=== CALCULAR LONGITUD DE LISTA ===");
        
        // Caso 1: Lista vacía
        Console.WriteLine("\n1. Lista vacía:");
        lista.Mostrar();
        int longitud1 = lista.CalcularLongitud();
        Console.WriteLine($"Longitud: {longitud1}");
        Console.WriteLine($"Longitud recursiva: {lista.CalcularLongitudRecursiva()}");
        
        // Caso 2: Lista con un elemento
        Console.WriteLine("\n2. Agregando un elemento:");
        lista.Agregar(10);
        lista.Mostrar();
        int longitud2 = lista.CalcularLongitud();
        Console.WriteLine($"Longitud: {longitud2}");
        
        // Caso 3: Lista con varios elementos
        Console.WriteLine("\n3. Agregando más elementos:");
        lista.Agregar(20);
        lista.Agregar(30);
        lista.Agregar(40);
        lista.Agregar(50);
        lista.Mostrar();
        int longitud3 = lista.CalcularLongitud();
        Console.WriteLine($"Longitud: {longitud3}");
        Console.WriteLine($"Longitud recursiva: {lista.CalcularLongitudRecursiva()}");
    }
}