namespace CodePatternsAPI.Interfaces
{
    //SRP - This interface is used as an "addition" to the IProductItem. The thought here is that this interface should take "visual" properties of clothes. Many more properties could be added here.

    //ISP - The interface is segregated into it's own providing properties unique to itself.

    public interface IBaseProductAttributes
    {
        public string Size { get; set; }
        public string Color { get; set; }

    }
}
