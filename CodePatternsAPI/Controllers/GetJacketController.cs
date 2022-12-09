using CodePatternsAPI.Data;
using CodePatternsAPI.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CodePatternsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetJacketController : ControllerBase
    {
        //write code here

        private readonly SqlContext _context;

        public GetJacketController(SqlContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<JacketEntity>>> GetAllJackets()
        {
            return await _context.Jacket.ToListAsync();
        }

    }
}
