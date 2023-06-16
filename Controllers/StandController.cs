using Microsoft.AspNetCore.Mvc;
using static System.Reflection.Metadata.BlobBuilder;


using System;

using System.Collections.Generic;

using System.Linq;

using System.Threading.Tasks;

using Microsoft.AspNetCore.Http;

using Microsoft.AspNetCore.Mvc;

//using Microsoft.Build.Tasks;

using Microsoft.EntityFrameworkCore;

using APIExposant.Data;

using APIExposant.Models;

 

namespace APIExposant.SQLite.Controllers

{

    [Route("api/[controller]")]

    [ApiController]

    public class StandController : ControllerBase

    {

        private readonly ApiContext _context;



        public StandController(ApiContext context)

        {
            _context = context;
        }


        [HttpGet("GetStand")]

        public async Task<ActionResult<IEnumerable<Stand>>> GetStand()

        {

            return await _context.stand.ToListAsync();

        }

        

    }

}
