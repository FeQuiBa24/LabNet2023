using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using labNetPractica3.EF.Entities;
using labNetPractica3.EF.Logic;

namespace labNetPractica3.EF.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeesLogic employeesLogic = new EmployeesLogic();


            /*employeesLogic.Add(new Employees
            {
                EmployeeID = 95,
                FirstName = "Federico",
                LastName = "Quiroz"
            });

            employeesLogic.Delete(10);*/

            employeesLogic.Update(new Employees
            {
                EmployeeID = 9,
                FirstName = "Juan",
                LastName = "Perez"
            });

            foreach (Employees employees in employeesLogic.GetAll())
            {
                Console.WriteLine($"{employees.EmployeeID} - {employees.LastName}, {employees.FirstName} ");
            }
            Console.ReadLine();
        }
    }
}
