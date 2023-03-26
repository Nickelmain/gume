using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gume
{
    public class LootBox : Item
    {
        static public Item TerribleChest(List<Item> item_list)
        {
            Console.WriteLine("Это оказался сундук со ржавым замком. Приложив немного усилий, вы смогли его сломать.");
            Random random = new Random();
            return item_list.OrderBy(item => item.Rare == "Обычная").ToList().OrderBy(item => random.Next()).FirstOrDefault();           
        }
        
        static public Item NormalChest(List<Item> item_list)
        {
            Console.WriteLine("Это оказался сундук с крепким железным замком. Приложив кое-какие усилия, вы смогли его сломать.");
            Random random = new Random();
            return item_list.OrderBy(item => item.Rare == "Обычная" && item.Rare == "Необычная").OrderBy(item => random.Next()).FirstOrDefault();
        }
        static public Item GoodChest(List<Item> item_list)
        {
            Console.WriteLine("Это оказался сундук с двумя замками. Приложив немало усилий, вы смогли их сломать.");
            Random random = new Random();
            return item_list.OrderBy(item => item.Rare == "Редкая").OrderBy(item => random.Next()).FirstOrDefault();
        }
        static public Item BeautifulChest(List<Item> item_list)
        {
            Console.WriteLine("Это оказался сундук с тремя большими позолочеными замками. Приложив пару часов усилий, вы смогли их сломать.");
            Random random = new Random();
            return item_list.OrderBy(item => item.Rare == "Эпическая").OrderBy(item => random.Next()).FirstOrDefault();
        }
        static public Item LegendaryChest(List<Item> item_list)
        {
            Console.WriteLine("Это оказался сундук с двумя странными головоломками на замках. Приложив полдня усилий, вы смогли их разгадать.");
            Random random = new Random();
            return item_list.OrderBy(item => item.Rare == "Легендарная" && item.Rare == "Героическая").OrderBy(item => random.Next()).FirstOrDefault();
        }
        static public Item WeaponChest(List<Item> weapon_list)
        {
            Console.WriteLine("Это оказался сундук с эмблемой меча на замке. Приложив час усилий, вы смогли его сломать.");
            Random random = new Random();
            return weapon_list.OrderBy(item => random.Next()).FirstOrDefault();
        }
        static public Item ArmorChest(List<Item> armor_list)
        {
            Console.WriteLine("Это оказался сундук с эмблемой щита на замке. Приложив час усилий, вы смогли его сломать.");
            Random random = new Random();
            return armor_list.OrderBy(item => random.Next()).FirstOrDefault();
        }
        static public Item AccessoryChest(List<Item> accessory_list)
        {
            Console.WriteLine("Это оказался сундук с эмблемой кольца на замке. Приложив час усилий, вы смогли его сломать.");
            Random random = new Random();
            return accessory_list.OrderBy(item => random.Next()).FirstOrDefault();
        }
    }
}
