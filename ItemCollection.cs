using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gume
{
    public class ItemCollection
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
        //static private List<Item> ConcatList(params List<Item>[] lists)
        //{
        //    List<Item> result = new List<Item>();
        //    for (int i = 0; i < lists.Count(); i++)
        //        result.AddRange(lists[i]);
        //    return result;
        //}

        public void GenerateItems()
        {
            var path = Directory.GetCurrentDirectory() + "\\DatebaseOfItems.json";//@"D:\VSproject\Csharp\gume\DatebaseOfItems.json";
            string json = File.ReadAllText(path);
            //ItemCollection items = JsonConvert.DeserializeObject<ItemCollection>(json);
            Dictionary<string, List<Item>> items_ = JsonConvert.DeserializeObject<Dictionary<string, List<Item>>>(File.ReadAllText(path));
            List<Item> weapons = items_["Оружие"];
            List<Item> armors = items_["Броня"];
            List<Item> accessories = items_["Аксессуар"];

            // объединяем списки элементов в один список
            //itemCollection = new List<Item>();
            itemCollection.AddRange(weapons);
            itemCollection.AddRange(armors);
            itemCollection.AddRange(accessories);
        }

        
    }
}
