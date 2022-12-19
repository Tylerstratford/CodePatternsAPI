using CodePatternsAPI.Data;
using CodePatternsAPI.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


//SRP - This controller is responible for getting all dresses from the database. I felt that this was the easiest way to seperate concerns between the two products within the database, as then the frontend can call a specific endpoint when displaying data. 
namespace CodePatternsAPI.Controllers.DressController
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetDressController : ControllerBase
    {

        private readonly SqlContext _context;

        public GetDressController(SqlContext context) { _context = context; }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<DressEntity>>> GetAllDress()
        {
            return await _context.Dress.ToListAsync();
        }
    }
}
