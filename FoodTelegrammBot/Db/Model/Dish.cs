namespace FoodTelegrammBot.Db.Model;

public class Dish
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Price { get; set; }
    public string TypeDishId { get; set; }
}