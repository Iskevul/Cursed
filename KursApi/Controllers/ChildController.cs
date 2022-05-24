using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Core;
using Core.ADO;

namespace KursApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ChildController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IEnumerable<Child> Get()
        {
            return DataAccess.GetChilds();
        }

        [HttpGet("{id}")]
        public ActionResult<Child> Get(int id)
        {
            var child = DataAccess.GetChild(id);

            if (child == null)
                return NotFound();

            return child;
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var child = DataAccess.GetChild(id);

            if (child is null)
                return NotFound();

            DataAccess.RemoveChild(id);

            return NoContent();
        }

    }
}
