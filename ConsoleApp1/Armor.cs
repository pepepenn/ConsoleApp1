using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp1.Weapon;

// The armor class stores the different armor types and initializes any armor attributes given with zeros if the attributes are not given by the user. It also asks to set the armortype

namespace ConsoleApp1
{

    public class Armor : Item 
        {

        public Armor()
        {
            this.ArmorAttributes.Dexterity = 0;
            this.ArmorAttributes.Strength = 0;
            this.ArmorAttributes.Intelligence = 0;
        }

        // Armor types (enumerator)
        public enum ArmorType
        {
            Cloth,
            Leather,
            Mail,
            Plate
        }

        public ArmorType armortype { get; set; }


        public BaseAttribute ArmorAttributes { get; set; } = new BaseAttribute();
        

        




    }
}
