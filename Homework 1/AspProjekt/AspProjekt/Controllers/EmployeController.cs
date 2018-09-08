using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using AspProjekt.Models;

namespace AspProjekt.Controllers
{
    public class EmployeController : Controller
    {
        private readonly List<EmployeeView> _employees = new List<EmployeeView>
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

        public IActionResult Details(int id)
        {
            var employe = _employees.FirstOrDefault(t => t.Id.Equals(id));
            if (ReferenceEquals(employe, null))
                return NotFound();
            else return View(employe);
        }
       
    
        public IActionResult Delete(int id)
        {
    
          _employees.Remove((_employees.FirstOrDefault(d => d.Id.Equals(id))));

            return Redirect("Index");
         
        }

        public IActionResult Index()
        {
            return View(_employees);
        }
    }
}
