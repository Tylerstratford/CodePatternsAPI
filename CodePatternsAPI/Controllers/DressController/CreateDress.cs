using CodePatternsAPI.Data;
using CodePatternsAPI.Entities;
using CodePatternsAPI.Factories;
using CodePatternsAPI.Interfaces;
using CodePatternsAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;


//SRP - To keep things simple, I decided to have seperate controllers for creating different products to fulfill SRP. Could also have a controller for creating any type product as both createDress and createJacket are very similar, they however use different Factories.

//DIP This controller also fulfills dependency inversion principle with the injection of IDressEntityFactory

namespace CodePatternsAPI.Controllers.DressController
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreateDress : ControllerBase
    {
        public readonly IDressEntityFactory _factory;
        public readonly SqlContext _context;

        public CreateDress(SqlContext context, IDressEntityFactory factory) {
            _context = context;
            _factory = factory;    
        }

        [HttpPost]
        public async Task<ActionResult<DressModel>> DressEntity(DressModel model)
        {
            var _dress = _factory.CreateDress(
                model.Occasions,
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

            _context.Dress.Add(_dress);

            await _context.SaveChangesAsync();

            return Ok(_dress);
        }
    }
}
