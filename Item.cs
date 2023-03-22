using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace gume
{
    public class Item : ItemCollection
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Damage { get; set; }
        public int Defense { get; set; }
        public int Bonus { get; set; }
        public string Description { get; set; }
        public string[] AttackText { get; set; }
        
        


       


        //static public Item ItemExists(string itemName)
        //{
        //    var item = Items.SingleOrDefault(item => item.Name == itemName);

        //    if (item != null) return item;
        //    else
        //    return item;
        //}
        //public Item() // Инициализируем список предметов
        //{
        //    Items = GenerateItems().ToList();
        //}
        //public List<Item> GetItems_() // Возвращаем список предметов в инвентаре
        //{
        //    return Items;
        //}
    }


}