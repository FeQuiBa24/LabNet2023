using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNetPractica1
{
    public abstract class Transporte
    {
        private int pasajeros;
        public int cantidadPasajeros 
        {
            get { return pasajeros; }
            set { pasajeros = value; }
        }

        public abstract void Avanzar();

        public abstract void Detenerse();
    }
}
