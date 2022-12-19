namespace CodePatternsAPI.Interfaces
{
    //ISP - Inherits the base product (IProductItem) and thesecond "base" product interface using interface segregation in order to build this interface, thus fullfilling ISP.

    //SRP - This interface will have properties that are compleltely unique to Dresses. Of course more could be added, kept it simple.

    //LSP -  This interface inherits only from other interfaces that are necessary, I.e, no properties that are unused are inherited here. 

    public interface IDress : IProductItem, IBaseProductAttributes

    {
        string Occasions { get; set; }
    }
}
