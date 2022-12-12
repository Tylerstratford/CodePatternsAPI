namespace CodePatternsAPI.Models
{
    //BaseProduct classed is used to comply with LSP - The parent class that both DressModel, JacketModel and any other future products that will be created.
    public class BaseProduct
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Category { get; set; } = null!;
        public int Price { get; set; }
        public string ImageUrl { get; set; } = null!;
        public bool IsOneSale { get; set; } = false;
        public int SaleProcent { get; set; } 
        public int SalePrice { get; set; }
    }
}
