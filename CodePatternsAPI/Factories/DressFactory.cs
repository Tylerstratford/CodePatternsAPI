using CodePatternsAPI.Entities;
using CodePatternsAPI.Interfaces;
using CodePatternsAPI.Models;

namespace CodePatternsAPI.Factories
{
internal static class DressFactory
    {
        public static DressEntity CreateDress(
             string occasions, string name, string description, string category, int price, string imgurl, bool isOnSale, int saleProcent, string size, string color)
        {
            return new DressEntity()
            {
                //Id = id,
                Occasions = occasions,
                Name = name,
                Description = description,
                Category = category,
                Price = price,
                ImageUrl = imgurl,
                IsOnSale = isOnSale,
                SaleProcent = saleProcent,
                Size = size,
                Color = color,
                SalePrice = price - (price * saleProcent / 100),

            };
        }

    }

}
