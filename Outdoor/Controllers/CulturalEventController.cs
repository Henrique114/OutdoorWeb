using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Outdoor.Interfaces;
using Outdoor.Models;

namespace Outdoor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CulturalEventController : ControllerBase
    {
        private readonly IRepository<CulturalEventModel> _repo;

        public CulturalEventController(IRepository<CulturalEventModel> repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IActionResult ListAllEvents() => Ok(_repo.ListAllEvents());

        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            var m = _repo.GetById(id);
            if (m == null) return NotFound();
            return Ok(m);
        }

        [HttpPost]
        public IActionResult Create(CulturalEventModel m)
        {
            _repo.AddEvent(m);
            return CreatedAtAction(nameof(Get), new { id = m.Id }, m);
        }

        [HttpPut("{id}")]
        public IActionResult Update(Guid id, CulturalEventModel m)
        {
            if (_repo.GetById(id) == null) return NotFound();
            m.Id = id;
            _repo.Update(m);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            if (_repo.GetById(id) == null) return NotFound();
            _repo.Delete(id);
            return NoContent();
        }
    }
}
