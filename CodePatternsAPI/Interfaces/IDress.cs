namespace CodePatternsAPI.Interfaces
{
    //**IDress inherites from IproductItem, which has attributes, BaseProductAttributes has fashion attributes
    public interface IDress : IProductItem, IBaseProductAttributes

    {
        string Sleaves { get; set; }
    }
}
