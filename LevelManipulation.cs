using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace gume
{
    public class LevelManipulation
    {
        public void ExperienceUp(Player player, int exp)
        {
            player.experience += exp;
            LevelUp(player);
        }
        public bool SufficientExperience(Player player) // Проверка на то, достаточно ли опыта для повышения уровня
        {
            if (player.experience >= player.requiredExperience) return true;            

            return false;
        }

        public void LevelUp(Player player) // Повышение уровня, если соблюдены условия
        {
            var levels = new LevelManipulation();
            if(SufficientExperience(player) && (player.level < player.maxLevel))
            {
                player.level++;
                player.experience -= player.requiredExperience;
                player.requiredExperience = (player.requiredExperience * 2) + (player.requiredExperience / 4);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Level Up!");
                Console.ResetColor();
                //levels.test(player);
            }
            //else
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine("NO!");
            //    Console.ResetColor();
            //    var display = new Display();
            //    display.SetCharacteristics(player);
            //}
        }

        //public void test(Player player)
        //{
        //    var display = new Display();
        //    display.SetCharacteristics(player);
        //}

    }
}
