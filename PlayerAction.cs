using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gume
{
    public class PlayerAction
    {
        public void game(Player player, List<Item> inventoryItems, Inventory inventory, List<Item> itemsGame)
        {
            var display = new Display();
            display.StartingText();
            while (true)
            {
                Console.WriteLine("\nВыбери действие:");
                Console.WriteLine("1. Идти дальше\n2. Посмотреть инвентарь\n3. Посмотреть характеристики\n4. Уйти");
                Console.Write("Ввод: ");
                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    display.StartingText();
                    GoAhead(player, ref inventoryItems, inventory, itemsGame);
                }
                else if (choice == 2)
                {
                    //display.StartingText();
                    //display.SetInventory(inventoryItems);
                    inventory.InventoryManipulation();
                }
                else if (choice == 3)
                {
                    display.StartingText();
                    display.SetCharacteristics(player);
                }
                else if (choice == 4)
                {
                    display.StartingText();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{player.fullName} ушёл в ближайший город. Пора отдохнуть в трактире с кружкой эля после такого похода.");
                    Console.ResetColor();
                    break;
                }
            }   
        }

        public void GoAhead(Player player, ref List<Item> inventoryItems, Inventory inventory, List<Item> itemsGame)
        {
            var levelManipulation = new LevelManipulation();
            player.passedCells++;
            Random random = new Random();
            int caughtScenario = random.Next(1, 4);

            if (caughtScenario == 1)
            {
                Console.WriteLine("Пусто");
                levelManipulation.ExperienceUp(player, 1);
            }
            else if (caughtScenario == 2)
            {
                Console.WriteLine("Бой");
                levelManipulation.ExperienceUp(player, 5); 
            }
            else
            {
                Console.WriteLine("Вы наткнулись на чей-то схрон!");
                levelManipulation.ExperienceUp(player, 3);
                Item item = (LootBox.ChestSelection(itemsGame));
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\nПолучен предмет: {item.Name}");
                inventory.AddItem(item);
                Console.ResetColor();
                inventoryItems = inventory.GetItems().ToList();
            }
        }
    }
}
