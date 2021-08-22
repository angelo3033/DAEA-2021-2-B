using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        //Función para calcular la suma de 2 números enteros
        static int Suma(int a, int b)
        {
            return a + b;
        }

        static int Resta(int a, int b)
        {
            return a - b;
        }

        static int Division(int a, int b)
        {
            int res = 0;

            if (b != 0)
            {
                res = a / b;
            }
            else
            {
                Console.WriteLine("esta division no es posible");
            }
            return res;
        }

        static int Multiplicacion(int a, int b)
        {
            return a * b;
        }

        //Procedimiento que imprime la raíz cuadrada de los 10 primeros números
        static void Raiz()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("La raíz cuadrada de {0} es: {1}", i, Math.Sqrt(i));
            }
        }

        static void Primos()
        {
            int cont = 0;
            for (int l = 2; l <= 30; l++)
            {
                for (int k = 1; k <= l; k++)
                {
                    if (l % k == 0)
                    {
                        cont = cont + 1;
                    }
                }
                if (cont <= 2)
                {
                    Console.WriteLine(l);
                }
                cont = 0;
            }
            Console.ReadKey();
        }

        static double Celsius(double f)
        {
            return (5*(f - 32))/9;
        }

        static double Fahrenheit(double c)
        {
            return ((9 * c)/5) + 32;
        }

        static void Main(string[] args)
        {
            Console.Title = "Procedimientos y funciones";
            string opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("[1] Suma de dos números");
                Console.WriteLine("[2] Resta de dos números");
                Console.WriteLine("[3] Division de dos números");
                Console.WriteLine("[4] Multiplicacion de dos números");
                Console.WriteLine("[5] Imprimir la raíz cuadrada de los 10 primeros números enteros");
                Console.WriteLine("[6] Imprimir los primeros 10 numeros primos");
                Console.WriteLine("[7] convertir De Fahrenheit a Celsius");
                Console.WriteLine("[8] convertir De Celsius a Fahrenheit");
                Console.WriteLine("[0] Salir");
                Console.WriteLine("Ingrese una opción y presione ENTER");
                opcion = Console.ReadLine();
                int a;
                int b;
                double c;
                double f;
                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Ingrese el primer número");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La suma de {0} y {1} es {2}", a, b, Suma(a, b));
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.WriteLine("Ingrese el primer número");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La resta de {0} y {1} es {2}", a, b, Resta(a, b));
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.WriteLine("Ingrese el primer número");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La division de {0} y {1} es {2}", a, b, Division(a, b));
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.WriteLine("Ingrese el primer número");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La multiplicacion de {0} y {1} es {2}", a, b, Multiplicacion(a, b));
                        Console.ReadKey();
                        break;
                    case "5":
                        Console.WriteLine("Calculando...");
                        Raiz();
                        Console.ReadKey();
                        break;
                    case "6":
                        Console.WriteLine("Calculando...");
                        Primos();
                        Console.ReadKey();
                        break;
                    case "7":
                        Console.WriteLine("Ingrese el valor de Fahrenheit");
                        f = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("El valor de Fahrenheit es {0} por lo cual el valor de Celsius es {1}", f, Celsius(f));
                        Console.ReadKey();
                        break;
                    case "8":
                        Console.WriteLine("Ingrese el valor de Celsius");
                        c = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("El valor de Celsius es {0} por lo cual el valor de Fahrenheit es {1}", c, Fahrenheit(c));
                        Console.ReadKey();
                        break;
                }
            } while (!opcion.Equals("0"));
        }
    }
}
