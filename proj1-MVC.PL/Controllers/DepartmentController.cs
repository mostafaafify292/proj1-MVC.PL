using Microsoft.AspNetCore.Mvc;
using Proj1_MVC.PLL.Interfacies;
using Proj1_MVC.PLL.Repositories;

namespace proj1_MVC.PL.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentRepository _repository;

        public DepartmentController(IDepartmentRepository repository)
        {
            _repository = repository;
        }
        public IActionResult Index()
        {
            _repository.GetAll();
            return View();
        }
    }
}
