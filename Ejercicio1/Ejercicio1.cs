using System;

namespace Ejercicio1.Ejercicio1
{
    public class Division
    {
        public static void Dividir(int i)
        {
            try
            {
                int cociente = i / 0;
                Console.WriteLine("\nEl cociente es: " + cociente);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("\nTerminó de realizarse la operación.");
            }
        }
    }
}
