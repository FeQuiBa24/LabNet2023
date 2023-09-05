using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica4.EF.Logic
{
    internal interface InterfaceLogic<T>
    {
        List<T> GetAll();
    }
}
