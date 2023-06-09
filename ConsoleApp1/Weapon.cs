using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

// sets all the relevant weapon properties and shows the set of weapons that are available
namespace ConsoleApp1
{
    public class Weapon : Item
    {
        public Weapon() {

        }

        public enum WeaponType
        {
            Axes,
            Bows,
            Daggers,
            Hammers,
            Staffs,
            Swords,
            Wands
        }
        public WeaponType weapontype {  get; set; }

        public int weaponDamage { get; set; } 
    
    }
}
