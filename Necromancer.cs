using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gume
{
    public class Necromancer : Player
    {
        public Necromancer()
        {
            this.className = "Некромант";
            this.name = Console.ReadLine();
            this.health = this.maxHealth = 12;
            this.mana = this.maxMana = 18;
            this.level = 1;
            this.experience = 0;
            this.requiredExperience = 20;
            this.Description = "С ним мало кто пьёт, разве что призванная им нежить. Любит призывать скелетиков. Неплох в магии";
        }

        public void SummonSkeleton()
        {

        }
    }
}
