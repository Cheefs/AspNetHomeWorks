using Microsoft.AspNetCore.Mvc;
using AspProjekt.Infrastructure.Interfaces;
using AspProjekt.Models;

namespace AspProjekt.Controllers
{
    [Route("users")]
    public class EmployeesController : Controller
    {
        
        private readonly IEmployeesData _employeesData;
        public EmployeesController(IEmployeesData employeesData)
        {
            _employeesData = employeesData;
        }

        public IActionResult Index()
        {
            return View(_employeesData.GetAll());
        }

        [Route("{id}")]
        public IActionResult Details(int id)
        {
            var employee = _employeesData.GetById(id);
            if (ReferenceEquals(employee, null))
                return NotFound();
            return View(employee);
        }

        [Route("delete/{id}")]
        public IActionResult DeLete(int id)
        {
            _employeesData.Delete(id);
            return RedirectToAction(nameof(Index));
        }

        [Route("edit/{id?}")]
        public IActionResult Edit(int? id)
        {
            EmployeeView model;
            if (id.HasValue)
            {
                model = _employeesData.GetById(id.Value);
                if (ReferenceEquals(model, null))
                    return NotFound();
            }
            else
            {
                model = new EmployeeView();
            }
            return View(model);
        }

        [HttpPost]
        [Route("edit/{id?}")]
        public IActionResult Edit(EmployeeView model)
        {
            if (model.Id > 0)
            {
                var employe = _employeesData.GetById(model.Id);
                if (ReferenceEquals(employe, null))
                    return NotFound();

                employe.FirstName = model.FirstName;
                employe.SurName = model.SurName;
                employe.Age = model.Age;
                employe.Patronymic = model.Patronymic;
                employe.Birth = employe.Birth;
                employe.Departament = employe.Departament;
                employe.WorkingSince = employe.WorkingSince;
                employe.WorkRole = employe.WorkRole;
            }
            else
            {
                _employeesData.AddNew(model);
            }
            _employeesData.Edit();
            return RedirectToAction(nameof(Index));
        }
    }    
}
