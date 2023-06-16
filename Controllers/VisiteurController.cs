using System.Diagnostics;
using APIExposant.Data;
using APIExposant.Models;
using Microsoft.AspNetCore.Mvc;

namespace APIExposant.SQLite.Controllers
{

    [Route("api/[controller]")]

    [ApiController]
    public class VisiteurController : Controller
    {

        private readonly ApiContext _context;
        public VisiteurController(ApiContext context)

        {
            _context = context;
        }


        [HttpPost]
        public IActionResult AddVisiteur(Visiteur visiteurs)
        {
            _context.visiteur.Add(visiteurs);
            _context.SaveChanges();

            Debug.WriteLine("Visiteur ajouté : " + visiteurs.FirstName + " " + visiteurs.LastName);

            return Ok();
        }

    }
}
