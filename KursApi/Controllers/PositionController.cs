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
    public class PositionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IEnumerable<Position> Get()
        {
            return DataAccess.GetPositions();
        }

        [HttpGet("{id}")]
        public ActionResult<Position> Get(int id)
        {
            var position = DataAccess.GetPosition(id);

            if (position == null)
                return NotFound();

            return position;
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var position = DataAccess.GetPosition(id);

            if (position is null)
                return NotFound();

            DataAccess.RemovePosition(id);

            return NoContent();
        }

        [HttpPost]
        public IActionResult Create(Position position)
        {
            DataAccess.AddPosition(position);
            return CreatedAtAction(nameof(Create), new { id = position.Id }, position);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Position position)
        {
            if (id != position.Id)
                return BadRequest();

            var existingPosition = DataAccess.GetPosition(id);
            if (existingPosition is null)
                return NotFound();

            DataAccess.EditPosition(id.ToString(), position);

            return NoContent();
        }


    }
}
