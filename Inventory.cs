using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace gume
{
    public class Inventory : ItemCollection
    {
        public int Count { get; set; }
        static public int LastItem = 1;
        private List<Item> inventoryItems; // Список предметов в инвентаре

        public Inventory() // Инициализируем список предметов
        {
            inventoryItems = new List<Item>();
        }
        public void AddItem(string itemName, List<Item> game_items) // Добавление предмета в инвентарь
        {           
            var receivedItem = game_items.FirstOrDefault(item => item.Name == itemName);        
            inventoryItems.Add(receivedItem);
        }
        public void AddItem(Item item) // Добавление предмета в инвентарь
        {          
            inventoryItems.Add(item);
        }
        public void RemoveItem(Item item) // Удаление предмета из инвентаря
        {
            inventoryItems.Remove(item);
        }
        public List<Item> GetItems() // Возвращаем список предметов в инвентаре
        {
            return inventoryItems;
        }

        public void InventoryManipulation()
        {
            var display = new Display();
            int choice;
            if (inventoryItems.Count == 0)
            {
                display.SetInventory(inventoryItems);
                return;
            }                
            else
                while (true)
                {
                    if (inventoryItems.Count == 0)
                    {
                        display.SetInventory(inventoryItems);
                        return;
                    }
                    display.SetInventory(inventoryItems);
                    Console.WriteLine("\nВыбери предмет для действия или введи 0, чтобы вернуться к походу:");
                    Console.Write("Ввод: ");
                    int choiceItem = int.Parse(Console.ReadLine());

                    if (choiceItem == 0)
                        return;
                    else if (choiceItem > inventoryItems.Count || choiceItem < 0)
                        continue;
                    else
                    {
                        display.StartingText();
                        Console.WriteLine($"Вы взяли в руки {inventoryItems[choiceItem - 1].Name}");
                        display.SetItem(inventoryItems[choiceItem - 1]);
                        Console.WriteLine("\nЧто с ним сделать?");
                        Console.WriteLine("<1> Положить обратно\n<2> Выбросить");
                        Console.Write("Ввод: ");
                        choice = int.Parse(Console.ReadLine());
                        if (choice == 1)
                            continue;
                        if (choice == 2)
                        {
                            display.StartingText();
                            Console.WriteLine("Вы в этом уверены?");
                            Console.WriteLine("<1> Да\n<2> Нет");
                            Console.Write("Ввод: ");
                            choice = int.Parse(Console.ReadLine());
                            if (choice == 1)
                                RemoveItem(inventoryItems[choiceItem - 1]);
                        }
                    }                       
                }
        }
        
    }
}
