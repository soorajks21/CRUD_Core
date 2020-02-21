using EmployeeManagement.Models;
using EmployeeManagement.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmployeeInterface _employeeRepository;

        public HomeController(IEmployeeInterface employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        [Route(" ")]
        [Route("Home")]
        [Route("Home/Index")]
        public ViewResult Index()
        {
            return View(_employeeRepository.GetEmployee(101));
        }

        public ViewResult Details()
        {
            var model = _employeeRepository.GetAllEmployee();
            ViewBag.PageTitle = "Welcome to asp .net core";
            return View(model);
        }

        [Route("Home/Data/{id?}")]
        public ViewResult Data(int? id)
        {
            HomeDataViewModel dataViewModel = new HomeDataViewModel()
            {
                Employee = _employeeRepository.GetEmployee(id??102),
                PageTitile = "Welcome to ViewModel data"
            };
            return View(dataViewModel);
        }
    }
}
