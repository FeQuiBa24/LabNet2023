using System;
using Ejercicio1.Ejercicio1;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número entero para el dividendo: ");
            int dividendo = int.Parse(Console.ReadLine());
            Division.Dividir(dividendo);
            
            Console.ReadKey();
        }
    }
}