using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    public class Logic
    {
        public static void ThrowCustomException()
        {
            throw new CustomException("Excepcion Propia");
        }
    }
}
