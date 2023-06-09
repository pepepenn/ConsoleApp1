using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Mage class is used for child classes since the behaviour is the same amongst them
namespace ConsoleApp1
{
    internal class Ranger : Hero
    {
        public Ranger()
        {
            this.BaseAttributes.Strength = 1;
            this.BaseAttributes.Dexterity = 7;
            this.BaseAttributes.Intelligence = 1;

        }

        public enum ValidWeaponTypes
        {
            Bow
        }

        public enum ValidArmorTypes
        {
            Leather,
            Mail
        }

        public override void LevelUp()
        {

            // Increasing the heroes level
            Level++;

            // Increasing the base attributes per level gained
            this.BaseAttributes.Strength = this.BaseAttributes.Strength + 1;
            this.BaseAttributes.Dexterity = this.BaseAttributes.Dexterity + 5;
            this.BaseAttributes.Intelligence = this.BaseAttributes.Intelligence + 1;


        }
        public override void Damage()
        {
            int[] result = CalculateAttributes();
            double WeaponDamage = 1;
            double DamagingAttribute = result[0]; //dexterity
            if (Inventory[Slot.Weapon] != null)
            {
                Weapon theweapon = (Weapon)Inventory[Slot.Weapon];
                double WeaponDamage2 = (double)theweapon.weaponDamage;
                WeaponDamage = WeaponDamage2;
            }

            float HeroDamage = (float)(WeaponDamage * (1 + DamagingAttribute / 100));
            Console.WriteLine("Total damage is " + HeroDamage);
        }

        public void EquipArmor(Armor armor)
        {
            //allowed armor names
            bool containsType = Enum.IsDefined(typeof(Armor.ArmorType), armor.armortype);
            if (containsType != true)
            {
                throw new ArgumentException("Invalid armor name");

            }

            if ((armor.armortype.ToString() != "Mail" & armor.armortype.ToString() != "Leather") | this.Level < armor.RequiredLevel)
            {
                throw new ArgumentException("Invalid armor Type for this class or level too low");

            }

            else
            {
                Slot armorslot = (Slot)armor.Slot;
                Inventory[armorslot] = armor;
                this.BaseAttributes.Dexterity += armor.ArmorAttributes.Dexterity;
                this.BaseAttributes.Strength += armor.ArmorAttributes.Strength;
                this.BaseAttributes.Intelligence += armor.ArmorAttributes.Intelligence;



            }
        }

    }
}
