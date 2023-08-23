using System;

namespace labNetPractica2.Ejercicio2
{
    public class Division
    {
        public static void Dividir(Decimal i, Decimal j)
        {
            try
            {
                Decimal cociente = i / j;
                Console.WriteLine("\nEl cociente es: " + cociente);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("\n¡Solo Chuck Norris divide por cero!");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("\nTerminó de realizarse la operación.");
            }
        }
    }
}
