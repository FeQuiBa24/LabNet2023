using labNetPractica4.EF.Entities;
using labNetPractica4.EF.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica4.EF.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerLogic customerLogic = new CustomerLogic();
            string varEj1;
            varEj1 = Console.ReadLine();

            Customers customers = customerLogic.ObjetoCustomer(varEj1);

            if(varEj1 != null)
            {
                Console.WriteLine($"{customers.CustomerID} - {customers.ContactName} de {customers.City}, {customers.Country}");
            }
            else
            {
                Console.WriteLine("Error!");
            }

            /*foreach (Customers c in customerLogic.GetAll())
            {
                Console.WriteLine($"{c.CustomerID}");
            }*/
            Console.ReadLine();

        }
    }
}
