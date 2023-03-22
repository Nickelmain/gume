using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gume
{
    public class WeaponItem : Item
    {
        public int damagePoint { get; set; }
        public WeaponItem(string name, int damagePoint)
        {
            this.Name = name;
            this.damagePoint = damagePoint;
        }
    }
}
