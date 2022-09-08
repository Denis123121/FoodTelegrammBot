using FoodTelegrammBot.Bot;
using FoodTelegrammBot.Db;
using FoodTelegrammBot.Db.Model;

/*DbManager dbManager = DbManager.GetInstance();

List<TypeDish> typesDishes = dbManager.TableTypesDishes.GetAllTypesDishes();

foreach (TypeDish typeDish in typesDishes)
{
    Console.WriteLine($"id:{typeDish.Id} name:{typeDish.Name}");
}*/

Bot bot = new Bot();
bot.Start();

Console.WriteLine("Bot started");
Console.WriteLine($"Start listening for @{bot.GetBotName()}");
Console.WriteLine("Press enter for stop");
Console.ReadKey();

bot.Stop();