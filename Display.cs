using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gume
{
    public class Display
    {
        public void StartingText()
        {
            Console.Clear();
            Console.WriteLine("\n\t\t--== CONSOLE RPG ==--\n\n");
        }
        public void Greeting(Player player)
        {
            StartingText();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Новый авантюрист {player.fullName}");
            Console.ResetColor();
            SetCharacteristics(player);
            Console.WriteLine("\nНажмите любую кнопку, чтобы начать...");
            Console.ReadLine();
        }
        public void SetInventory(List<Item> inventory)
        {
            StartingText();
            Console.WriteLine("\nИнвентарь:");
            if (inventory.Count() == 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Ваш инвентарь пуст!");
                Console.ResetColor();
            }            
            else
            {
                StartingText();
                foreach (var item in inventory)
                {

                    item.InventoryPosition = Inventory.LastItem++;
                    Console.WriteLine($"<{item.InventoryPosition}>{item.Name}");
                }
                Inventory.LastItem = 1;
            }         
        }

        public void SetCharacteristics(Player player)
        {
            Console.WriteLine("\nХарактеристики:");
            Console.WriteLine($"Имя: {player.name}");
            Console.WriteLine($"Класс: {player.className}");
            Console.WriteLine($"Здоровье: {player.health}/{player.maxHealth}");
            Console.WriteLine($"Мана: {player.mana}/{player.maxMana}");
            Console.WriteLine($"Уровень: {player.level}/{player.maxLevel}");
            Console.WriteLine($"Опыт: {player.experience}/{player.requiredExperience}");
            Console.WriteLine($"Пройденный путь: {player.passedCells} км");
        }

        public void SetItems(List<Item> items)
        {
            Console.WriteLine("\nИнвентарь:");
            foreach (var item in items)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
