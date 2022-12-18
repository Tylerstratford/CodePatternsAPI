using CodePatternsAPI.Data;
using CodePatternsAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CodePatternsAPI.Entities;
using CodePatternsAPI.Factories;
using CodePatternsAPI.Interfaces;

namespace CodePatternsAPI.Controllers.JacketController
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreateJacket : ControllerBase
    {
        private readonly SqlContext _context;
        private readonly IJacketEntityFactory _factory;

        public CreateJacket(SqlContext context, IJacketEntityFactory factory)
        {
            _context = context;
            _factory = factory;
        }

        [HttpPost]
        public async Task<ActionResult<JacketModel>> JacketEntity(JacketModel model)
        {
            var _jacket = _factory.CreateJacket(
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
