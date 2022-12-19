namespace CodePatternsAPI.Interfaces
{
    //This interface is the base for all current and future products. Motivation is that all products must have at least have these properties. 
    //OCP - This fulfills OCP -  Open to extension but closed to modification. All other product interfaces will use this as their base, adding other interfaces with further properties if needed.

    //SRP - This interface will have properties that are used for the creation of a product, nothing more.

    //ISP - The interface is segregated into it's own providing properties unique to itself.

    public interface IProductItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public int Price { get; set; }
        public string ImageUrl { get; set; }
        public bool IsOnSale { get; set; }
        public int SaleProcent { get; set; }
        public int SalePrice { get; set; }
    }
}
