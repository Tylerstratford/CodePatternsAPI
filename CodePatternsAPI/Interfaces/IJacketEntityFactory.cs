using CodePatternsAPI.Entities;

namespace CodePatternsAPI.Interfaces
{
    public interface IJacketEntityFactory
    {
        JacketEntity CreateJacket(string season, string name, string description, string category, int price, string imgurl, bool isOnSale, int saleProcent, string size, string color);
    }
}
