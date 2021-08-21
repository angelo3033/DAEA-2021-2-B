using System;

namespace Helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola, como te llamas: ");
            string nombre = Console.ReadLine(); 
            Console.WriteLine("mucho gusto conocerte " + nombre);
        }
    }
}
