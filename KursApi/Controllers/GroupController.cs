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
    public class GroupController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IEnumerable<Group> Get()
        {
            return DataAccess.GetGroups();
        }

        [HttpGet("{id}")]
        public ActionResult<Group> Get(int id)
        {
            var group = DataAccess.GetGroup(id);

            if (group == null)
                return NotFound();

            return group;
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var group = DataAccess.GetGroup(id);

            if (group is null)
                return NotFound();

            DataAccess.RemoveGroup(id);

            return NoContent();
        }
    }
}
