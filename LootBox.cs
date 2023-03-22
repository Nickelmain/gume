using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gume
{
    public class LootBox : Item
    {
        static public Item ChestLoot()
        {
            var itemCollection = new ItemCollection();
            itemCollection.GenerateItems();
            List<Item> gameItems = itemCollection.itemCollection;
            Random random = new Random();
            return gameItems.OrderBy(item => random.Next()).FirstOrDefault();           
        }
    }
}
