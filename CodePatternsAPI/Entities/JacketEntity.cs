using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

//SRP - Responsible for the database and tables for the product Jacket


namespace CodePatternsAPI.Entities
{
    public class JacketEntity
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Season { get; set; } = null!;

        [Required]
        public string Name { get; set; } = null!;

        [Required]
        public string Description { get; set; } = null!;

        [Required]
        public string Category { get; set; } = null!;

        [Required]
        [Column(TypeName = "money")]
        public int Price { get; set; }

        [Required]
        public string ImageUrl { get; set; } = null!;

        [Required]
        public bool IsOnSale { get; set; }

        [Required]
        public int? SaleProcent { get; set; }

        [Required]
        [Column(TypeName = "money")]
        public int? SalePrice { get; set; }

        [Required]
        public string Size { get; set; } = null!;

        [Required]
        public string Color { get; set; } = null!;
    }
}
