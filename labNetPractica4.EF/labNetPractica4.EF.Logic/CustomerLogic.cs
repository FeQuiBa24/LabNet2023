using labNetPractica4.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica4.EF.Logic
{
    public class CustomerLogic : BaseLogic, InterfaceLogic<Customers>
    {
        public List<Customers> GetAll()
        {
            return context.Customers.ToList();
        }
    //Ejercicio1
    public Customers ObjetoCustomer(string customer_id)
    {
        var query = context.Customers.Where(c => c.CustomerID == customer_id);
        return query.FirstOrDefault();
    }
    }

}
