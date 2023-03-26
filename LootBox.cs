using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gume
{
    public class LootBox : Item
    {
        static public Item ChestLoot(List<Item> item_list)
        {
            Random random = new Random();
            return item_list.OrderBy(item => random.Next()).FirstOrDefault();           
        }
    }
}
