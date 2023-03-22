using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gume
{
    public class Game
    {
        public Game()
        {
            var itemsCollection = new ItemCollection();
            itemsCollection.GenerateItems();
            List<Item> gameItems = itemsCollection.itemCollection;
            var playerAct = new PlayerAction();
            var display = new Display();
            var inventory = new Inventory();
        }
    }
}
