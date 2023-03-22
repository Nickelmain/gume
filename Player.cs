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
        public int maxLevel { get { return 60; } }
        public int experience { get; set; }
        public int requiredExperience { get; set; }
        public int passedCells { get; set; }


        public Player ChoicePLayerClass()
        {
            var display = new Display();

            while (true)
            {
                Console.WriteLine("Выбери класс:");
                Console.WriteLine("1. Паладин\n2. Колдун");
                Console.Write("Ввод: ");

                int choice = int.Parse(Console.ReadLine());
                display.StartingText();
                Console.WriteLine("Введите имя:");

                if (choice == 1)
                {
                    return new Paladin();
                }
                else if (choice == 2)
                {
                    return new Wizard();
                }
                else
                {                
                    display.StartingText();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Такой вариант отсутствует...\n");
                    Console.ResetColor();
                }
            }           
        }        
    }
}
