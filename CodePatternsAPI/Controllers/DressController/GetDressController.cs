using CodePatternsAPI.Data;
using CodePatternsAPI.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
