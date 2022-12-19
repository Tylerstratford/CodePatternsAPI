using CodePatternsAPI.Entities;


//DIP/SRP - Interface to be used in abstraction and an injection into the dress controller, the controller is dependeng on this interface rather than a concrete implementaion of DressEntity -  thus fulfilling DIP.

//ISP - The interface is segregated into it's own providing properties unique to itself.


namespace CodePatternsAPI.Interfaces
{
    public interface IDressEntityFactory
    {
        DressEntity CreateDress(string occasions, string name, string description, string category, int price, string imgurl, bool isOnSale, int saleProcent, string size, string color);
    }
}
