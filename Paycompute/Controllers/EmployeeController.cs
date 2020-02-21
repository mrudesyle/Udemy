using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Paycompute.Services;

namespace Paycompute.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        public IActionResult Index()
        {
            return View();
        }

    }
}
