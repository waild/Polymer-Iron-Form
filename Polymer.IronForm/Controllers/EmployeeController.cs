using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Polymer.IronForm.Models;

namespace Polymer.IronForm.Controllers
{
    public class EmployeeController : Controller
    {
        [HttpPost]
        public IActionResult AddNewEmployee(EmployeeInfo info)
        {
            return new ObjectResult(info);
        }
    }
}