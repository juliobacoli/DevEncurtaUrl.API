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

        [HttpPost]
        public IActionResult Post(AddOrUpdateShortenedLinkModel model)
        {

        }
    }
}
