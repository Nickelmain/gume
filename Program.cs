using gume;
using System.Linq;

var playerAct = new PlayerAction();
var display = new Display();
var inventory = new Inventory();
var player = new Player();
var itemCollection = new ItemCollection();

itemCollection.GenerateItems();
List<Item> gameItems = itemCollection.itemCollection;

//inventory.AddItem("Бронзовый шлем", gameItems);
List<Item> inventoryItems = inventory.GetItems().ToList();

display.StartingText();
player = player.ChoicePLayerClass();
display.Greeting(player);
playerAct.game(player, inventoryItems, inventory, gameItems);

