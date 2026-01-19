using System;

public class ListaPersonalizada
{
    private class Nodo
    {
        public object Dato { get; set; }
        public Nodo Siguiente { get; set; }
        
        public Nodo(object dato)
        {
            Dato = dato;
            Siguiente = null;
        }
    }
    
    private Nodo cabeza;
    private int cantidad;
    
    public int Cantidad { get { return cantidad; } }
    
    // Constructor
    public ListaPersonalizada()
    {
        cabeza = null;
        cantidad = 0;
    }
    
    // Agregar al final
    public void Agregar(object dato)
    {
        Nodo nuevo = new Nodo(dato);
        
        if (cabeza == null)
        {
            cabeza = nuevo;
        }
        else
        {
            Nodo actual = cabeza;
            while (actual.Siguiente != null)
            {
                actual = actual.Siguiente;
            }
            actual.Siguiente = nuevo;
        }
        cantidad++;
    }
    
    // Método principal de búsqueda
    public int Buscar(object datoBuscado)
    {
        return Buscar(datoBuscado, mostrarMensaje: true);
    }
    
    // Método sobrecargado para controlar si muestra mensaje
    public int Buscar(object datoBuscado, bool mostrarMensaje)
    {
        if (cabeza == null)
        {
            if (mostrarMensaje) Console.WriteLine("La lista está vacía");
            return 0;
        }
        
        int contador = 0;
        Nodo actual = cabeza;
        
        while (actual != null)
        {
            // Comparación segura con null
            if (actual.Dato == null && datoBuscado == null)
            {
                contador++;
            }
            else if (actual.Dato != null && actual.Dato.Equals(datoBuscado))
            {
                contador++;
            }
            
            actual = actual.Siguiente;
        }
        
        if (mostrarMensaje)
        {
            if (contador == 0)
            {
                Console.WriteLine($"El dato '{datoBuscado}' no fue encontrado en la lista");
            }
            else
            {
                Console.WriteLine($"El dato '{datoBuscado}' se encontró {contador} vez/veces");
            }
        }
        
        return contador;
    }
    
    // Método para mostrar todos los elementos
    public void Mostrar()
    {
        if (cabeza == null)
        {
            Console.WriteLine("Lista vacía");
            return;
        }
        
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

// Programa de prueba
class Programa
{
    static void Main()
    {
        ListaPersonalizada lista = new ListaPersonalizada();
        
        Console.WriteLine("=== PRUEBA DEL MÉTODO BUSCAR ===");
        
        // Caso 1: Lista vacía
        Console.WriteLine("\n1. Buscar en lista vacía:");
        lista.Buscar(5);
        
        // Caso 2: Datos encontrados múltiples veces
        Console.WriteLine("\n2. Agregando elementos...");
        lista.Agregar(10);
        lista.Agregar(20);
        lista.Agregar(10);
        lista.Agregar(30);
        lista.Agregar(10);
        lista.Agregar(40);
        
        lista.Mostrar();
        
        Console.WriteLine("\nBuscando el número 10:");
        int resultado1 = lista.Buscar(10);
        Console.WriteLine($"Resultado: {resultado1}");
        
        // Caso 3: Dato no encontrado
        Console.WriteLine("\nBuscando el número 99:");
        int resultado2 = lista.Buscar(99);
        Console.WriteLine($"Resultado: {resultado2}");
        
        // Caso 4: Búsqueda sin mensaje
        Console.WriteLine("\nBúsqueda silenciosa del número 20:");
        int resultado3 = lista.Buscar(20, mostrarMensaje: false);
        Console.WriteLine($"Resultado: {resultado3}");
        
        // Caso 5: Con strings
        Console.WriteLine("\n3. Probando con strings:");
        ListaPersonalizada listaStrings = new ListaPersonalizada();
        listaStrings.Agregar("apple");
        listaStrings.Agregar("banana");
        listaStrings.Agregar("apple");
        listaStrings.Agregar("orange");
        
        listaStrings.Mostrar();
        listaStrings.Buscar("apple");
        listaStrings.Buscar("grape");
    }
}