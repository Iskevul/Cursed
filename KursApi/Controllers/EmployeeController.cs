using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using Core;
using Core.ADO;

namespace KursApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return DataAccess.GetEmployees();
        }

        [HttpGet("{id}")]
        public ActionResult<Employee> Get(int id)
        {
            var employee = DataAccess.GetEmployee(id);

            if (employee == null)
                return NotFound();

            return employee;
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var employee = DataAccess.GetEmployee(id);

            if (employee is null)
                return NotFound();

            DataAccess.RemoveEmployee(id);

            return NoContent();
        }
    }
}
