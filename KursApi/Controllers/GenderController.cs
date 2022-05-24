using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Core;
using Core.ADO;

namespace KursApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GenderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IEnumerable<Gender> Get()
        {
            return DataAccess.GetGenders();
        }

        [HttpGet("{id}")]
        public ActionResult<Gender> Get(int id)
        {
            var gender = DataAccess.GetGender(id);

            if (gender == null)
                return NotFound();

            return gender;
        }
    }
}
