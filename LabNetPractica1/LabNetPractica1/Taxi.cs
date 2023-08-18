using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNetPractica1
{
    public class Taxi : Transporte
    {
        public override void Avanzar()
        {
            Console.WriteLine($"El taxi avanza con {cantidadPasajeros} pasajeros");
        }

        public override void Detenerse()
        {
            Console.WriteLine($"El taxi se detiene con {cantidadPasajeros} pasajeros");
        }
    }
}
