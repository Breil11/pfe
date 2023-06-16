using APIExposant.Data;
using Microsoft.AspNetCore.Mvc;
using APIExposant.Models;

namespace APIExposant.Controllers
{

    [Route("api/[controller]")]

    [ApiController]

    public class AchatController : Controller
    {
        private readonly ApiContext _context;



        public AchatController(ApiContext context)

        {
            _context = context;
        }


        [HttpPost]

        public IActionResult AddAchat(Achat achats)

        {

            _context.achat.Add(achats);

            _context.SaveChanges();

            return Ok();

        }

    }
}
