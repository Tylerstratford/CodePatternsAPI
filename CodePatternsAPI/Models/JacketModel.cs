using CodePatternsAPI.Interfaces;

namespace CodePatternsAPI.Models
{
    public class JacketModel : IJackets

    {
        private int salePrice;
        public string Season { get; set; } = null!;
        public Guid Id { get;set; }
        public string Name { get;set; } = null!;
        public string Description { get; set; } = null!; 
        public string Category { get; set; } = null!;
        public int Price { get;set; }
        public string ImageUrl { get; set; } = null!;
        public bool IsOneSale { get;set; }
        public int SaleProcent { get;set; }
        public int SalePrice
        {
            get { return salePrice; }
            set { salePrice = Price * SaleProcent / 100; }
        }
        public string Size { get; set; } = null!;
        public string Color { get; set; } = null!;
    }
}
