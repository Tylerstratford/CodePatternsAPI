namespace CodePatternsAPI.Interfaces
{
    public interface IProductItem
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public int Price { get; set; }
        public string ImageUrl { get; set; }
        public bool IsOneSale { get; set; }
        public int SaleProcent { get; set; }
        //public int SalePrice { get; set; }
    }
}
