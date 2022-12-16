using CodePatternsAPI.Data;
using CodePatternsAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CodePatternsAPI.Entities;
using CodePatternsAPI.Factories;

namespace CodePatternsAPI.Controllers.JacketController
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreateJacket : ControllerBase
    {
        private readonly SqlContext _context;

        public CreateJacket(SqlContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<JacketModel>> JacketEntity(JacketModel model)
        {
            var _jacket = JacketFactory.CreateJacket(
                //Guid.NewGuid(),
                model.Season,
                model.Name,
                model.Description,
                model.Category,
                model.Price,
                model.ImageUrl,
                model.IsOnSale,
                model.SaleProcent,
                model.Size,
                model.Color
                );

            _context.Jacket.Add(_jacket);
            await _context.SaveChangesAsync();

            return Ok(_jacket);
        }
    }
}
