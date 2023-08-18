using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNetPractica1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Transporte> transportes = new List<Transporte>();

            for (int i = 0; i <= 5; i++)
            {
                Omnibus omnibus = new Omnibus();
                Console.WriteLine($"Ingrese la cantidad de pasajeros del {i}º omnibus: ");
                omnibus.cantidadPasajeros = Convert.ToInt32(Console.ReadLine());

                transportes.Add(omnibus);

                Console.WriteLine($"El {i}º omnibus tiene {omnibus.cantidadPasajeros} pasajeros");
                omnibus.Avanzar();
                omnibus.Detenerse();
            }

            for (int i = 0; i <= 5; i++)
            {
                Taxi taxi = new Taxi();
                Console.WriteLine($"Ingrese la cantidad de pasajeros del {i}º taxi: ");
                taxi.cantidadPasajeros = Convert.ToInt32(Console.ReadLine());

                transportes.Add(taxi);

                Console.WriteLine($"El {i}º taxi tiene {taxi.cantidadPasajeros} pasajeros");
                taxi.Avanzar();
                taxi.Detenerse();
            }
        }
    }
}
