using CodePatternsAPI.Entities;
using CodePatternsAPI.Interfaces;

namespace CodePatternsAPI.Factories
{
    internal static class JacketFactory
    {
        public static JacketEntity CreateJacket(
             Guid id, string season, string name, string description, string category, int price, string imgurl, bool isOnSale, int saleProcent, string size, string color
            )
        {
            return new JacketEntity()
            {
                Id = id,
                Season = season,
                Name = name,
                Description = description,
                Category = category,
                Price = price,
                ImageUrl = imgurl,
                IsOneSale = isOnSale,
                SaleProcent = saleProcent,
                Size = size,
                Color = color,
                SalePrice = price - (price * saleProcent / 100),
            };
        }
    }
}
