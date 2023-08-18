using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNetPractica1
{
    public class Omnibus : Transporte
    {
        public override void Avanzar()
        {
            Console.WriteLine($"El omnibus avanza con {cantidadPasajeros} pasajeros");
        }

        public override void Detenerse()
        {
            Console.WriteLine($"El omnibus se detiene con {cantidadPasajeros} pasajeros");
        }
    }
}
