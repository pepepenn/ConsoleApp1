using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

// Mage class is used for child classes since the behaviour is the same amongst them
namespace ConsoleApp1
{

    // Make overloaded constructor
    internal class Mage:Hero
    {
        public Mage()
        {
            
            this.BaseAttributes.Strength = 1;
            this.BaseAttributes.Dexterity = 1;
            this.BaseAttributes.Intelligence = 8;
        }

        // set the mages ValidWeaponTypes, this is unfortunately not used
        public enum ValidWeaponTypes
        {
           Staff,
           Wand
        }

        // set the mages ValidArmorTypes, this is used
        public enum ValidArmorTypes
        {
            Cloth
        }

        // Levelling the base level and the attributes per class, 1 1 5 in this case
        public override void LevelUp()
        {   

            // Increasing the heroes level
            Level++;

            // Increasing the base attributes per level gained
            this.BaseAttributes.Strength = BaseAttributes.Strength + 1;
            this.BaseAttributes.Dexterity = BaseAttributes.Dexterity + 1;
            this.BaseAttributes.Intelligence = BaseAttributes.Intelligence + 5; 
        }


        // Using the function calculate attributes which combines attributes with item attributes, calculates the total damage including weapon damage and intelligence (mage) bonus
        public override void Damage()
        {
            int[] result = CalculateAttributes();
            double WeaponDamage = 1;
            double DamagingAttribute = result[2]; //intelligence
            if (Inventory[Slot.Weapon] != null) 
            {
                Weapon theweapon =  (Weapon)Inventory[Slot.Weapon];
                double WeaponDamage2 = (double)theweapon.weaponDamage;
                WeaponDamage = WeaponDamage2;

            }
            double HeroDamage = WeaponDamage * (1 + DamagingAttribute / 100);
            
            Console.WriteLine("Total damage is " + HeroDamage);
        }


        // equipping armor, made per class due to class restrictions.
        // checks if the armor name is valid, and checks if the armor type requiremens and level requirements are met, otherwise throws an arugmentexception
        public void EquipArmor(Armor armor)
        {
            //allowed armor names
            bool containsType = Enum.IsDefined(typeof(Armor.ArmorType), armor.armortype);
            if (containsType != true)
            {
                throw new ArgumentException("Invalid armor name");

            }

            if (armor.armortype.ToString() != "Cloth" | this.Level < armor.RequiredLevel)
            {
                throw new ArgumentException("Invalid armor Type for this class or level too low");
            }

            else
            {
                // casting to slot by typecasting armor slot to a slot, which gives the key for the intended slot
                Slot armorslot = (Slot)armor.Slot;
                Inventory[armorslot] = armor;

                // adding these attributes to the total, this unfortunately does mean that equipping another item in the same slot will stack.
                this.BaseAttributes.Dexterity += armor.ArmorAttributes.Dexterity;
                this.BaseAttributes.Strength += armor.ArmorAttributes.Strength;
                this.BaseAttributes.Intelligence += armor.ArmorAttributes.Intelligence;

            }
        }

    }
}
