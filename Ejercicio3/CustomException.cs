using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    public class CustomException : Exception
    {
        public CustomException() : base("Mensaje personalizado para la excepción.")
        {

        }
    }
}
