using labNetPractica3.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica3.EF.Logic
{
    internal interface IABMLogic<T>
    {
        List<T> GetAll();

        void Add(T newItem);

        void Delete(int id);
        void Update(Employees item);
    }
}
