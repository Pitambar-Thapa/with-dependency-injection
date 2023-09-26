using Microsoft.AspNetCore.Mvc;
using WithDependencyInjection.Repository;

namespace WithDependencyInjection.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeController(IEmployeeRepository employeeRepository) {
            _employeeRepository = employeeRepository;
        }
        public JsonResult Index()
        {
            return Json(_employeeRepository.GetAll());
        }

        public JsonResult Details(int id)
        {
            return Json(_employeeRepository.GetById(id));
        }
    }
}
