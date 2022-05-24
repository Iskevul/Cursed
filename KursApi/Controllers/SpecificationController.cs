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
    public class SpecificationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IEnumerable<Specification> Get()
        {
            return DataAccess.GetSpecifications();
        }

        [HttpGet("{id}")]
        public ActionResult<Specification> Get(int id)
        {
            var specification = DataAccess.GetSpecification(id);

            if (specification == null)
                return NotFound();

            return specification;
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var specification = DataAccess.GetSpecification(id);

            if (specification is null)
                return NotFound();

            DataAccess.RemoveSpecification(id);

            return NoContent();
        }

        [HttpPost]
        public IActionResult Create(Specification specification)
        {
            DataAccess.AddSpecification(specification);
            return CreatedAtAction(nameof(Create), new { id = specification.Id }, specification);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Specification specification)
        {
            if (id != specification.Id)
                return BadRequest();

            var existingSpecification = DataAccess.GetSpecification(id);
            if (existingSpecification is null)
                return NotFound();

            DataAccess.EditSpecification(id.ToString(), specification);

            return NoContent();
        }
    }
}
