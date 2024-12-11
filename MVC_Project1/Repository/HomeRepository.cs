using MVC_Project1.Models;

namespace MVC_Project1.Repository;

public class HomeRepository
{
    private List<Home> homeList = new List<Home>()
    {
        new Home() {ID = 1, ImageUrl = "https://www.freeiconspng.com/thumbs/food-png/restaurant-food-dish-png-10.png", Header = "Foods", Text = "Yeni, təzə məhsullardan hazırlanmış, dadlı yeməklər"},
        new Home() {ID = 2, ImageUrl = "https://static.vecteezy.com/system/resources/previews/039/657/885/non_2x/ai-generated-diwali-plate-of-a-indian-traditional-sweets-png.png", Header = "Sweets", Text = "Yeni, təzə məhsullardan hazırlanmış, dadlı şirniyyatlar"},
        new Home() {ID = 3, ImageUrl = "https://png.pngtree.com/png-clipart/20230414/original/pngtree-summer-orange-juice-png-image_9054080.png", Header = "Jucies", Text = "Fresh, fruit jucies"}
    };

    public List<Home> GetHomeProducts()
    {
        return this.homeList;
    }
}