using Ejercicio4;
using System;

namespace Ejercicio4
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Logic.ThrowCustomException();
            }
            catch (CustomException ex)
            {
                Console.WriteLine("Mensaje: " + ex.Message);
                Console.WriteLine("\nTipo de excepcion: " + ex.GetType().Name);
            }
            Console.ReadLine();
        }
    }
}
