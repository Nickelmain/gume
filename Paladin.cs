using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gume
{
    public class Paladin : Player
    {
        public Paladin()
        {
            this.className = "Паладин";
            this.name = Console.ReadLine();
            this.health = this.maxHealth = 40;
            this.mana = this.maxMana = 10;
            this.level = 1;
            this.experience = 0;
            this.requiredExperience = 20;
            this.Description = "Воин святого ордена.\nКрепкий малый, но в магии не силён.\nИмеет на вооружении щит ордена";
        }
    }
}
