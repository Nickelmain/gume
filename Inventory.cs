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
        private List<Item> items; // Список предметов в инвентаре

        public Inventory() // Инициализируем список предметов
        {
            items = new List<Item>();
        }
        public void AddItem(string itemName, List<Item> game_items) // Добавление предмета в инвентарь
        {
            //var itemCollection = new ItemCollection();
            
            var itemCollection_ = game_items.FirstOrDefault(item => item.Name == itemName);
         
            items.Add(itemCollection_);
        }
        public void RemoveItem(Item item) // Удаление предмета из инвентаря
        {
            items.Remove(item);
        }
        public List<Item> GetItems() // Возвращаем список предметов в инвентаре
        {
            return items;
        }
        
    }
}
