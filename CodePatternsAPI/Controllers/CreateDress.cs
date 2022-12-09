using CodePatternsAPI.Data;
using CodePatternsAPI.Entities;
using CodePatternsAPI.Factories;
using CodePatternsAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace CodePatternsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreateDress : ControllerBase
    {
        public readonly SqlContext _context;

        public CreateDress(SqlContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<DressModel>> DressEntity(DressModel model)
        {
            //use GenericFactory DIP
            var _dress = DressFactory.CreateDress(
                Guid.NewGuid(),
                model.Sleaves,
                model.Name,
                model.Description,
                model.Category,
                model.Price,
                model.ImageUrl,
                model.IsOneSale,
                model.SaleProcent,
                model.Size,
                model.Color
                );

            _context.Dress.Add(_dress);

            await _context.SaveChangesAsync();

            return Ok(_dress);
        }
    }
}
