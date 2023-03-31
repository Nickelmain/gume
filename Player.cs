using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gume
{
    public class Player : Entity
    {
        
        public string className { get; set; }
        public string fullName { get { return className + " " + name; } }
        public int defense { get; set; }
        public int maxLevel { get { return 10; } }
        public int experience { get; set; }
        public int requiredExperience { get; set; }
        public int passedCells { get; set; }

        private bool CLassConfirmation(int choice/*, string className, string classDescription*/, object player_)
        { 
            var display = new Display();
            Player player = (Player)player_;
            Console.WriteLine(player.Description);
            display.SetCharacteristics(player);

            while (true)
            {
                //display.StartingText();
                Console.WriteLine($"\nХотите обучиться на класс {player.className}?");
                Console.WriteLine("<1> Да\n<2> Нет");
                Console.Write("Ввод: ");
                choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    display.StartingText();
                    Console.WriteLine("Введите имя:");
                    player.name = Console.ReadLine();
                    return false;
                }
                else if (choice == 2)
                    return true;
                else
                    continue;
            }
        }
        public Player ChoicePLayerClass()
        {
            var display = new Display();
            bool flag = true;
            Player player = null;

            while(flag)
            {
                display.StartingText();
                Console.WriteLine("Выбери класс:");
                Console.WriteLine("<1> Паладин\n<2> Колдун");
                Console.Write("Ввод: ");
                int choice = int.Parse(Console.ReadLine());
                display.StartingText();
                if (choice == 1)
                {
                    player = new Paladin();
                    flag = CLassConfirmation(choice, player);
                }
                else if (choice == 2)
                {
                    player = new Wizard();
                    flag = CLassConfirmation(choice, player);
                }
                else
                {
                    display.StartingText();
                }
            }

            return player;
        }        
    }
}
