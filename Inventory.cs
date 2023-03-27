using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace gume
{
    public class Inventory : ItemCollection
    {
        public int Count { get; set; }
        private List<Item> inventoryItems; // Список предметов в инвентаре

        public Inventory() // Инициализируем список предметов
        {
            inventoryItems = new List<Item>();
        }
        public void AddItem(string itemName, List<Item> game_items) // Добавление предмета в инвентарь
        {           
            var receivedItem = game_items.FirstOrDefault(item => item.Name == itemName);        
            inventoryItems.Add(receivedItem);
        }
        public void AddItem(Item item) // Добавление предмета в инвентарь
        {          
            inventoryItems.Add(item);
        }
        public void RemoveItem(Item item) // Удаление предмета из инвентаря
        {
            inventoryItems.Remove(item);
        }
        public List<Item> GetItems() // Возвращаем список предметов в инвентаре
        {
            return inventoryItems;
        }
        
    }
}
