using CodePatternsAPI.Data;
using CodePatternsAPI.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

//SRP - This controller is responible for getting all jackets from the database. I felt that this was the easiest way to seperate concerns between the two products within the database, as then the frontend can call a specific endpoint when displaying data. 

namespace CodePatternsAPI.Controllers.JacketController
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetJacketController : ControllerBase
    {

        private readonly SqlContext _context;

        public GetJacketController(SqlContext context) { _context = context; }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<JacketEntity>>> GetAllJackets()
        {
            return await _context.Jacket.ToListAsync();
        }

    }
}
