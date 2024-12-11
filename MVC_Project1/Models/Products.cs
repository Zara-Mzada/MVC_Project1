namespace MVC_Project1.Models;

public class Products
{
    public int ID { get; set; }
    public int CategoryID { get; set; }
    public string ImageURL { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public bool IsCool { get; set; }
}