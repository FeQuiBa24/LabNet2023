using System;
using labNetPractica2.Ejercicio2;

namespace labNetPractica2
{
    class Program
    {
        static void Main(string[] args)
        { 
            try{
                Console.WriteLine("Ingrese un número entero para el dividendo: ");
                Decimal dividendo = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("\nIngrese un número entero para el divisor: ");
                Decimal divisor = Convert.ToDecimal(Console.ReadLine());
                Division.Dividir(dividendo, divisor);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("\n¡Seguro ingresó una letra o no ingresó nada!");
            }
            Console.ReadKey();
        }
    }
}