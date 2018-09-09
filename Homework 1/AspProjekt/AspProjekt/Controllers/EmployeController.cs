using Microsoft.AspNetCore.Mvc;
using AspProjekt.Infrastructure.Interfaces;

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
    }
    
}
