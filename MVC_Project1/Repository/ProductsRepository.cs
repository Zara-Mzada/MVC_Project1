using MVC_Project1.Models;

namespace MVC_Project1.Repository;

public class ProductsRepository
{
    private List<Products> products = new List<Products>()
    {
        new Products()
        { CategoryID = 1, ID = 1, ImageURL = "/img/product1.jpg", Name = "Adana kabab", Price = 17, IsCool = false},
        new Products()
        { CategoryID = 1, ID = 2, ImageURL = "/img/product2.jpg", Name = "Quzu basdirma kabab", Price = 17, IsCool = true},
        new Products() 
        { CategoryID = 1, ID = 3, ImageURL = "/img/product3.jpg", Name = "Gobelekli toyuq qovurma", Price = 15, IsCool = true},
        new Products() 
        { CategoryID = 1, ID = 4, ImageURL = "/img/product4.jpg", Name = "Toyuq izqara", Price = 12, IsCool = false},
        new Products() 
            { CategoryID = 2, ID = 5, ImageURL = "/img/product5.jpg", Name = "Tiramisu", Price = 10 },
        new Products() 
            { CategoryID = 2, ID = 6, ImageURL = "/img/product6.jpg", Name = "Cizkeyk kadayif", Price = 14 },
        new Products() 
            { CategoryID = 2, ID = 7, ImageURL = "/img/product7.jpg", Name = "Profitrol", Price = 8 },
        new Products() 
            { CategoryID = 2, ID = 8, ImageURL = "/img/product8.jpg", Name = "Sokoladli sufle", Price = 11 },
        new Products() 
            { CategoryID = 3, ID = 9, ImageURL = "/img/product9.jpg", Name = "Oreolu milksheyk", Price = 10 },
        new Products() 
            { CategoryID = 3, ID = 10, ImageURL = "/img/product10.jpg", Name = "Flowers rose latte", Price = 7 },
        new Products() 
            { CategoryID = 3, ID = 11, ImageURL = "/img/product11.jpg", Name = "Icetea marakuya", Price = 7 },
        new Products() 
            { CategoryID = 3, ID = 12, ImageURL = "/img/product12.jpg", Name = "Smuzi manqo", Price = 10 },
    };

    public List<Products> GetProducts()
    {
        return this.products;
    }

    public List<Products> GetByCategory(int categID)
    {
        Console.WriteLine(categID);
        
        List<Products> selectedproduct = new();

        for (int i = 0; i < this.products.Count; i++)
        {
            if (categID == this.products[i].CategoryID)
            {
                selectedproduct.Add(this.products[i]);
            }
        }
        return selectedproduct;
    }
    
}