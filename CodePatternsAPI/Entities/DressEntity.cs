using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CodePatternsAPI.Entities
{
    public class DressEntity
    {
        [Key]
        public Guid Id { get; set; }
        public string Sleaves { get; set; } = null!;

        [Required]
        public string Name { get; set; } = null!;
        [Required]

        public string Description { get; set; } = null!;
        [Required]

        public string Category { get; set; } = null!;

        [Column(TypeName = "money")]
        public int Price { get; set; }
        [Required]

        public string ImageUrl { get; set; } = null!;
        public bool IsOneSale { get; set; } = false;
        public int SaleProcent { get; set; }

        private int salePrice;

        [Column(TypeName = "money")]
        public int SalePrice
        {
            get { return Price * SaleProcent/100; }
            set { salePrice = value; }
        }
        [Required]
        public string Size { get; set; } = null!;

        [Required]
        public string Color { get; set; } = null!;

    }
}
