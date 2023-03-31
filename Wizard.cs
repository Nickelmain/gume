using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gume
{
    public class Wizard : Player
    {
        public Wizard()
        {
            this.className = "Колдун";
            this.health = this.maxHealth = 15;
            this.mana = this.maxMana = 25;
            this.level = 1;
            this.experience = 50;
            this.requiredExperience = 15;
            this.Description = 
                "Хиленький, но толковый страж башни.\n" +
                "Под удар лучше не подставляться, но фокусами владеет отлично.\n" +
                "Быстро учится и начинает с 50 очками опыта.\n" +
                "Имеет за пазухой свиток огненного шара";
        }
    }
}
