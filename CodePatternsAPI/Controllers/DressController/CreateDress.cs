﻿using CodePatternsAPI.Data;
using CodePatternsAPI.Entities;
using CodePatternsAPI.Factories;
using CodePatternsAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;


//SRP - To keep things simple, I decided to have seperate controllers for creating different products to fulfill SRP. Could also have a controller for creating any type product as both createDress and createJacket are very similar, they however use different Factories.

namespace CodePatternsAPI.Controllers.DressController
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreateDress : ControllerBase
    {
        public readonly SqlContext _context;

        public CreateDress(SqlContext context) { _context = context; }

        [HttpPost]
        public async Task<ActionResult<DressModel>> DressEntity(DressModel model)
        {
            //use Factory DIP
            var _dress = DressFactory.CreateDress(
                //Guid.NewGuid(),
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
