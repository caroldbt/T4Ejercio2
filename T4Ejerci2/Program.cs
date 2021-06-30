using System;

namespace T4Ejerci2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ingrese nombre: ");
            string nombre = System.Console.ReadLine();
            Console.WriteLine("Ingrese ciudad: ");
            string ciudad = Console.ReadLine();
            Console.WriteLine("Hola " + nombre + " bienvenido a " + ciudad);
        }
    }
}
