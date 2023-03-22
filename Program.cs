// See https://aka.ms/new-console-template for more information
using gume;
using System.Linq;



//List <Item> igit = Item.Items.Where(item => item.Type == "Оружие").OrderBy(c => c.Id).ToList();
var playerAct = new PlayerAction();
var display = new Display();
var inventory = new Inventory();
var player = new Player();

var itemCollection = new ItemCollection();
itemCollection.GenerateItems();
List<Item> gameItems = itemCollection.itemCollection;


//Console.ReadLine();
//foreach(var item in gameItems)
//{
//    Console.WriteLine(item.Name);
//}
Console.WriteLine("Count: " + itemCollection.itemCollection.Count());
Console.ReadLine();
inventory.AddItem("Бронзовый шлем");
List<Item> inventoryItems = inventory.GetItems().ToList();

display.StartingText();
player = player.ChoicePLayerClass();
display.Greeting(player);
playerAct.game(player, inventoryItems, inventory);

