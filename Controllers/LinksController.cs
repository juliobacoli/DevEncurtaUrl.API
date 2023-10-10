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


        /// <summary>
        /// Obter todos os links cadastrados
        /// </summary>
        /// <returns>Obter todos os links gerados</returns>
        ///<response code="200"> Sucesso </response>

        [HttpGet]
        public IActionResult GetAllLinks()
        {
            return Ok(_context.Links);
        }

        /// <summary>
        /// Obter link por Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Como resposta trás o link do banco de dados</returns>
        /// <response code="200"> Ok </response>
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

        /// <summary>
        /// Cadastrar um link encurtado
        /// </summary>
        /// <param name="model">Dados de link</param>
        /// <returns> Objeto recém criado </returns>
        /// <response code="201"> Criado </response>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public IActionResult Adicionar(AddOrUpdateShortenedLinkModel model)
        {
            var link = new ShortenedCustomLink(model.Title, model.DestinationLink);

            _context.Links.Add(link);
            _context.SaveChanges();

            //O primeiro parametro é a ação que retorna a criação e o segundo é o parametro necessario pra consulta (objeto anonimo)
            return CreatedAtAction("GetById", new {id = link.Id}, link);
        }

        /// <summary>
        /// Atualizar link gerado
        /// </summary>
        /// <param name="id"></param>
        /// <param name="model"></param>
        /// <returns>Link atualizado</returns>
        /// <response code="204"> NoContent </response>
        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, AddOrUpdateShortenedLinkModel model)
        {
            var link = _context.Links.SingleOrDefault(link => link.Id == id);

            if (link == null)
            {
                return NotFound();
            }

            link.Update(model.Title, model.DestinationLink);
            _context.Links.Update(link);
            _context.SaveChanges();

            return NoContent();
        }

        /// <summary>
        /// Deleta link
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Vazio pois o link foi deletado</returns>
        /// <response code="204"> NoContent </response>
        [HttpDelete("{id}")]
        public IActionResult DeletarLink(int id)
        {
            var link = _context.Links.SingleOrDefault(link => link.Id == id);

            if (link == null)
            {
                return NotFound();
            }

            _context.Links.Remove(link);
            _context.SaveChanges();


            return NoContent();
        }

        /// <summary>
        /// Link direcionado
        /// </summary>
        /// <param name="code">Dados de link direcionado</param>
        /// <returns> Objeto direcionado </returns>
        /// <response code="200"> Sucesso </response>
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
