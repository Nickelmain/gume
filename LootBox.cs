using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gume
{
    public class LootBox : Item
    {
        static public Item ChestSelection(List<Item> item_list)
        {
            Random random = new Random();
            int num = random.Next(1,251);
            if (num <= 5)//5 - 2%
                return LegendaryChest(item_list);
            else if (num <= 21)//15 - 6%
                return BeautifulChest(item_list); 
            else if (num <= 57)//35 - 14%
                return GoodChest(item_list); 
            else if (num <= 148)//90 - 36%
                return NormalChest(item_list); 
            else//105 - 42%
                return TerribleChest(item_list); 
        }

        static public Item TerribleChest(List<Item> item_list)
        {
            Console.WriteLine("Это оказался сундук со ржавым замком. Приложив немного усилий, вы смогли его сломать.");
            Random random = new Random();
            return item_list.Where(item => item.Rare == "Обычная").ToList().OrderBy(item => random.Next()).FirstOrDefault();           
        }     
        static public Item NormalChest(List<Item> item_list)
        {
            Console.WriteLine("Это оказался сундук с крепким железным замком. Приложив кое-какие усилия, вы смогли его сломать.");
            Random random = new Random();
            return item_list.Where(item => item.Rare == "Обычная" || item.Rare == "Необычная").ToList().OrderBy(item => random.Next()).FirstOrDefault();
        }
        static public Item GoodChest(List<Item> item_list)
        {
            Console.WriteLine("Это оказался сундук с двумя замками. Приложив немало усилий, вы смогли их сломать.");
            Random random = new Random();
            return item_list.Where(item => item.Rare == "Редкая").ToList().OrderBy(item => random.Next()).FirstOrDefault();
        }
        static public Item BeautifulChest(List<Item> item_list)
        {
            Console.WriteLine("Это оказался сундук с тремя большими позолочеными замками. Приложив пару часов усилий, вы смогли их сломать.");
            Random random = new Random();
            return item_list.Where(item => item.Rare == "Эпическая").ToList().OrderBy(item => random.Next()).FirstOrDefault();
        }
        static public Item LegendaryChest(List<Item> item_list)
        {
            Console.WriteLine("Это оказался сундук с двумя странными головоломками на замках. Приложив полдня усилий, вы смогли их разгадать.");
            Random random = new Random();
            return item_list.Where(item => item.Rare == "Легендарная" || item.Rare == "Героическая").ToList().OrderBy(item => random.Next()).FirstOrDefault();
        }
        static public Item WeaponChest(List<Item> weapon_list)
        {
            Console.WriteLine("Это оказался сундук с эмблемой меча на замке. Приложив час усилий, вы смогли его сломать.");
            Random random = new Random();
            return weapon_list.OrderBy(item => random.Next()).ToList().FirstOrDefault();
        }
        static public Item ArmorChest(List<Item> armor_list)
        {
            Console.WriteLine("Это оказался сундук с эмблемой щита на замке. Приложив час усилий, вы смогли его сломать.");
            Random random = new Random();
            return armor_list.OrderBy(item => random.Next()).ToList().FirstOrDefault();
        }
        static public Item AccessoryChest(List<Item> accessory_list)
        {
            Console.WriteLine("Это оказался сундук с эмблемой кольца на замке. Приложив час усилий, вы смогли его сломать.");
            Random random = new Random();
            return accessory_list.OrderBy(item => random.Next()).ToList().FirstOrDefault();
        }
    }
}
