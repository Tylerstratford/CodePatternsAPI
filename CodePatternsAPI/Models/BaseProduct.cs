namespace CodePatternsAPI.Models
{
    //SRP - Class for baseproducts

    // LSP - BaseProduct classed is used to comply with LSP - The parent class that both DressModel, JacketModel and any other future products that will be created will have this as their base class. All of these properties are neccessary, and any other future properties that will be added to their own interface/class.

    // OCP - This also fullfills OCP as this is the base class that is closed to modification but open to extenstion through further classes/interfaces if the products require further properties.
    public class BaseProduct
    {
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Category { get; set; } = null!;
        public int Price { get; set; }
        public string ImageUrl { get; set; } = null!;
        public bool IsOnSale { get; set; } = false;
        public int SaleProcent { get; set; } 
        public int SalePrice { get; set; }
    }
}
