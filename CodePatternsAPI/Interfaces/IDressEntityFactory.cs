using CodePatternsAPI.Entities;


//Interface in order to fulfill DIP -  The create jacket controller is dependent in this interface rather than an conrete implemenation of DressEntity, thus fulfilling DIP

namespace CodePatternsAPI.Interfaces
{
    public interface IDressEntityFactory
    {
        DressEntity CreateDress(string occasions, string name, string description, string category, int price, string imgurl, bool isOnSale, int saleProcent, string size, string color);
    }
}
