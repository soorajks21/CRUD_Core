using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnAsp.netCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmployeeInterface _employeeRepository;

        public HomeController(IEmployeeInterface employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public string Index()
        {
            return _employeeRepository.GetEmployee(101).Name;
        }

        public ViewResult Details()
        {
            var model = _employeeRepository.GetEmployee(102);
            //return View(model);
            //ViewBag.Emp = model;
            ViewBag.PageTitle = "Welcome to asp .net core";
            return View(model);
        }
    }
}
