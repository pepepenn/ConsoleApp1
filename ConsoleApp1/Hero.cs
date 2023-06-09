using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApp1
{

    public abstract class Hero
    {


        public Hero()
        {

            Console.WriteLine("A hero was created");

            //Setting inventory to null initially

            this.Inventory = new Dictionary<Slot, Item>()
            {
                {Slot.Weapon, null },
                {Slot.Head, null },
                {Slot.Body, null },
                {Slot.Legs, null }
                
            };


        }
        public BaseAttribute BaseAttributes { get; set; } = new BaseAttribute();

        public string Name { get; set; } = "Unknown Hero";
        public int Level { get; set; } = 1;

        public Dictionary<Slot, Item > Inventory { get; set; }






        




        // Methods

        public abstract void LevelUp();

        

        // Weapon is equipped if the type is real and if the level requirement is met
        public void EquipWeapon(Weapon weapon)
        {
            bool containsType = Enum.IsDefined(typeof(Weapon.WeaponType), weapon.weapontype);

            if (containsType != true | this.Level < weapon.RequiredLevel)
            {
                throw new ArgumentException("Wrong Item type equipped or level too low");

            }
            else
            {
                Inventory[Slot.Weapon] = weapon;
                Console.WriteLine("Weapon equipped: " + weapon.Name);
            }


        }

        

        public abstract void Damage();


        // Total attributes are calculated as a sum of general attributes and ones gained through armor in the inventory
        public int[] CalculateAttributes()

        {
            int AttributesSum = BaseAttributes.Dexterity + BaseAttributes.Strength + BaseAttributes.Intelligence;

            int TotalDex = BaseAttributes.Dexterity;
            int TotalStr = BaseAttributes.Strength;
            int TotalInt = BaseAttributes.Intelligence;

            if (Inventory[Slot.Legs] != null)
            {
                Armor legattributes = (Armor)Inventory[Slot.Legs];
                TotalDex += legattributes.ArmorAttributes.Dexterity;
                TotalStr += legattributes.ArmorAttributes.Strength;
                TotalInt += legattributes.ArmorAttributes.Intelligence;

            }
            if (Inventory[Slot.Body] != null)
            {
                Armor bodyattributes = (Armor)Inventory[Slot.Body];
                TotalDex += bodyattributes.ArmorAttributes.Dexterity;
                TotalStr += bodyattributes.ArmorAttributes.Strength;
                TotalInt += bodyattributes.ArmorAttributes.Intelligence;
            }
            if (Inventory[Slot.Head] != null)
            {
                Armor headattributes = (Armor)Inventory[Slot.Head];
                TotalDex += headattributes.ArmorAttributes.Dexterity;
                TotalStr += headattributes.ArmorAttributes.Strength;
                TotalInt += headattributes.ArmorAttributes.Intelligence;
            }


            int[] totals = new int[3] {TotalDex,TotalStr,TotalInt};

            return totals;

        }

        public void TotalAttributes()
        {

            int[] result = CalculateAttributes();  
            

            Console.WriteLine("Total attributes are: " + result[0] +" dexterity, " + result[1] + " strength and "+ result[2] + " intelligence.");//TotalAttributeSum);
            
        }

        // Displays all of the relevant variables through a string builder, damage does not work
        public void Display()
        {

            int[] result = CalculateAttributes();



            StringBuilder stringBuilder = new StringBuilder();

            string stringname = this.Name;
            string className = this.GetType().Name;
            int leveldisplay = this.Level;
            int totalStrength = result[0];
            int totalDexterity = result[1];
            int totalIntelligence = result[2];

            stringBuilder.AppendLine("Name: " + stringname);
            stringBuilder.AppendLine("Class: " + className);
            stringBuilder.AppendLine("Level: " + leveldisplay);
            stringBuilder.AppendLine("Total Strength: " + totalStrength);
            stringBuilder.AppendLine("Total Dexterity: " + totalDexterity);
            stringBuilder.AppendLine("Total Intelligence: " + totalIntelligence);

            string display = stringBuilder.ToString();
            Console.WriteLine(display);
        }
    }

}
