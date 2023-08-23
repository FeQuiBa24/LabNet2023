using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    public class CustomException : Exception
    {
        public CustomException(string message) : base("¡Error!"+message) {}
        public override string Message => base.Message;
    }
}
