using CodePatternsAPI.Entities;
using CodePatternsAPI.Interfaces;

namespace CodePatternsAPI.Factories
{
    public class JacketEntityFactory : IJacketEntityFactory
    {
        public JacketEntity CreateJacket(string season, string name, string description, string category, int price, string imgurl, bool isOnSale, int saleProcent, string size, string color)
        {
            return new JacketEntity()
            {
                Season = season,
                Name = name,
                Description = description,
                Category = category,
                Price = price,
                ImageUrl = imgurl,
                IsOnSale = isOnSale,
                SaleProcent = saleProcent,
                Size = size,
                Color = color,
                SalePrice = price - (price * saleProcent / 100)
            };
        }
    }
}
