using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gume
{
    public class ItemCollection : Item
    {
        [JsonProperty("Оружие")]
        public List<Item> Weapons { get; set; }
        [JsonProperty("Броня")]
        public List<Item> Armors { get; set; }
        [JsonProperty("Аксессуар")]
        public List<Item> Accessories { get; set; }
        public List<Item> itemCollection { get; set; }
        
        public ItemCollection()
        {
            itemCollection = new List<Item>();
        }

        public void GenerateItems()
        {
            var path = Directory.GetCurrentDirectory() + "\\DatebaseOfItems.json";
            string json = File.ReadAllText(path);
            Dictionary<string, List<Item>> items_ = JsonConvert.DeserializeObject<Dictionary<string, List<Item>>>(File.ReadAllText(path));

            List<Item> weapons = items_["Оружие"];
            foreach (var weapon in weapons)
                weapon.ItemType = "Оружие";
            List<Item> armors = items_["Броня"];
            foreach (var armor in armors)
                armor.ItemType = "Броня";
            List<Item> accessories = items_["Аксессуар"];
            foreach (var accessory in accessories)
                accessory.ItemType = "Аксессуар";

            // объединяем списки элементов в один список
            itemCollection.AddRange(weapons);
            itemCollection.AddRange(armors);
            itemCollection.AddRange(accessories);
        }

        
    }
}
