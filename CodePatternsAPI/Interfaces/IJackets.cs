namespace CodePatternsAPI.Interfaces
{
    //ISP - Inherits the base product (IProductItem) and the second "base" product interface using interface segregation in order to build this interface, thus fullfilling ISP. 

    //SRP - this interface will have properties that are compleltely unique to jackets. Of course, more properties could be added, kept it simple.

    

    public interface IJackets : IProductItem, IBaseProductAttributes
    {
        string Season { get; set; }
    }
}
