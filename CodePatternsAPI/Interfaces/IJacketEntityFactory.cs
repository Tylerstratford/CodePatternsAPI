using CodePatternsAPI.Entities;

//DIP/SRP - Interface to be used in abstraction and an injection into the jacket controller, the controller is dependeng on this interface rather than a concrete implementaion of JacketEntity -  thus fulfilling DIP.

//ISP - The interface is segregated into it's own providing properties unique to itself.


namespace CodePatternsAPI.Interfaces
{
    public interface IJacketEntityFactory
    {
        JacketEntity CreateJacket(string season, string name, string description, string category, int price, string imgurl, bool isOnSale, int saleProcent, string size, string color);
    }
}
