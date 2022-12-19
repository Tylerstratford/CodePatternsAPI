using CodePatternsAPI.Entities;
using CodePatternsAPI.Interfaces;

namespace CodePatternsAPI.Models

    //SRP/DIP - Creating a new instance of DressEntity of which is then injected and used with IDressEntity into the controller for creation of a new product to be used with dependency inversion. 
{
    public class DressEntityFactory : IDressEntityFactory
    {

        public DressEntity CreateDress(string occasions, string name, string description, string category, int price, string imgurl, bool isOnSale, int saleProcent, string size, string color)
        {
            return new DressEntity()
            {
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
