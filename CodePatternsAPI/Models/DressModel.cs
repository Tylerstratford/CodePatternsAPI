using CodePatternsAPI.Interfaces;

//SRP - Class for Jacket  - self explanitory.

//LSP/OCP - The class inherits from only those that are necessary -  the Base product and further IJacket, which has properties unique to Dresse using the IDress interface that used other other interfaces
//The idea was to "simulate" that baseproduct was created and then a developer was to implement dresses without modifying existing code

namespace CodePatternsAPI.Models
{
    public class DressModel : BaseProduct, IDress
    {
        public string Occasions { get; set; } = null!;
        public string Size { get; set; } = null!;
        public string Color { get; set; } = null!;
    }
}
