using System.Collections.Generic;
using AspProjekt.Models;

namespace AspProjekt.Infrastructure.Interfaces
{
   public interface IEmployeesData
    {
        IEnumerable<EmployeeView> GetAll();
        EmployeeView GetById(int id);
        void Edit();
        void AddNew(EmployeeView model);
        void Delete(int id);
   }
}
