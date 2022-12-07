using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CodePatternsAPI.Entities
{
    public class JacketEntity
    {
        [Key]
        public Guid Id { get; set; }
        public string Season { get; set; } = null!;

        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Category { get; set; } = null!;

        [Column(TypeName = "money")]
        public int Price { get; set; }
        public string ImageUrl { get; set; } = null!;
        public bool IsOneSale { get; set; }
        public int? SaleProcent { get; set; }

        [Column(TypeName = "money")]
        public int? SalePrice { get; set; }
        public string Size { get; set; } = null!;
        public string Color { get; set; } = null!;
    }
}
