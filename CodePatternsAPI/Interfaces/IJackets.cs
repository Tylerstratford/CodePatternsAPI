namespace CodePatternsAPI.Interfaces
{
    public interface IJackets : IProductItem, IBaseProductAttributes
    {
        string Season { get; set; }
    }
}
