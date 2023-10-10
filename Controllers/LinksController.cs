using DevEncurtaUrl.API.Entities;
using DevEncurtaUrl.API.Models;
using DevEncurtaUrl.API.Persistence;
using Microsoft.AspNetCore.Mvc;

namespace DevEncurtaUrl.API.Controllers
{
    [ApiController]
    [Route("api/shortenedLinks")]
    public class LinksController : ControllerBase
    {
        private readonly DevEncurtaUrlDbContext _context;

        public LinksController(DevEncurtaUrlDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAllLinks()
        {
            return Ok(_context.Links);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var link = _context.Links.SingleOrDefault(link => link.Id == id);

            if (link == null)
            {
                return NotFound();
            }

            return Ok(link);
        }

        [HttpPost]
        public IActionResult Adicionar(AddOrUpdateShortenedLinkModel model)
        {
            var link = new ShortenedCustomLink(model.Title, model.DestinationLink);

            _context.Add(link);

            //O primeiro parametro é a ação que retorna a criação e o segundo é o parametro necessario pra consulta (objeto anonimo)
            return CreatedAtAction("GetById", new {id = link.Id}, link);
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, AddOrUpdateShortenedLinkModel model)
        {
            var link = _context.Links.SingleOrDefault(link => link.Id == id);

            if (link == null)
            {
                return NotFound();
            }

            link.Update(model.Title, model.DestinationLink);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletarLink(int id)
        {
            var link = _context.Links.SingleOrDefault(link => link.Id == id);

            if (link == null)
            {
                return NotFound();
            }

            _context.Links.Remove(link);

            return NoContent();
        }

        [HttpGet("/{code}")]
        public IActionResult Redirecionamento(string code)
        {
            var link = _context.Links.SingleOrDefault(link => link.Code == code);

            if (link == null)
            {
                return NotFound();
            }

            return Redirect(link.DestinationLink);
        }
    }
}
