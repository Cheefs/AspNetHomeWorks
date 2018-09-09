using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspProjekt.Models;
using AspProjekt.Infrastructure.Interfaces;

namespace AspProjekt.Infrastructure
{
    public class EmployeesData : IEmployeesData
    {
        private readonly List<EmployeeView> _employees;

        public EmployeesData()
        {
            _employees = new List<EmployeeView>
            {
                new EmployeeView
            {
                Id = 1,
                FirstName = "Иван",
                SurName = "Иванов",
                Patronymic = "Иванович",
                Age = 22,
                Birth="18.02.1996",
                Departament="GameDev",
                WorkRole="Unity Developer",
                WorkingSince="10.10.2016"
            },
                new EmployeeView
            {
                Id = 2,
                FirstName = "Владислав",
                SurName = "Петров",
                Patronymic = "Иванович",
                Age = 45,
                Birth="18.02.1979",
                Departament="Web",
                WorkRole="Senior Developer",
                WorkingSince="10.10.2005"
            },
                new EmployeeView
            {
                Id = 3,
                FirstName = "Николай",
                SurName = "Николаев",
                Patronymic = "николаевич",
                Age = 32,
                Birth="18.02.1989",
                Departament="Web",
                WorkRole="FrontEnd developer",
                WorkingSince="10.10.2014"
            },
                new EmployeeView
            {
                Id = 4,
                FirstName = "Петр",
                SurName = "Петров",
                Patronymic = "Петрович",
                Age = 35,
                Birth="18.02.1986",
                Departament="GameDev",
                WorkRole="Senior Unity Developer",
                WorkingSince="10.10.2010"
            }
            };
        }
        public IEnumerable<EmployeeView> GetAll()
        {
            return _employees;
        }
        public EmployeeView GetById(int id)
        {
            return _employees.FirstOrDefault(e => e.Id.Equals(id));
        }
        public void Edit()
        {

        }
        public void AddNew(EmployeeView model)
        {
            model.Id = _employees.Max(e => e.Id) + 1;
            _employees.Add(model);
        }
        public void Delete(int id)
        {
            var employee = GetById(id);
            if (employee != null)
            {
                _employees.Remove(employee);
            }
        }
    }
}