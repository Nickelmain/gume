using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace gume
{
    public class Item 
    {
        public int Id { get; set; }
        public int InventoryPosition { get; set; }
        public string Name { get; set; }
        public string Rare { get; set; }
        public int Damage { get; set; }
        public int Defense { get; set; }
        public Object Bonus { get; set; }
        public string Description { get; set; }
        public string[] AttackText { get; set; }       
    }

}