using labNetPractica3.EF.Data;
using labNetPractica3.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica3.EF.Logic
{
    public class EmployeesLogic : BaseLogic, IABMLogic<Employees>
    {      
        public List<Employees> GetAll()
        {
            return context.Employees.ToList();
        }

        public void Add(Employees newItem)
        {
            context.Employees.Add(newItem);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var employeeToDelete = context.Employees.First(e => e.EmployeeID == id);
            context.Employees.Remove(employeeToDelete);
            context.SaveChanges();
        }

        public void Update(Employees item)
        {
            var updateItem = context.Employees.Find(item.EmployeeID);

            updateItem.FirstName = item.FirstName;
            updateItem.LastName = item.LastName;

            context.SaveChanges();
        }
    }
}
