using ConsoleApp1;
using Microsoft.VisualStudio.TestPlatform.Utilities;

namespace TestProject1
{
    public class HeroCreationTests



        // 1 create hero

        // 2 inrease that heroes level

        // 3 create a weapon

        // 4 create armor

        // 5 equip weapon

        // 6 equip armor

        // 7 total attributes

        // 8 hero damage provison

        // 9    hero display
    {

        Warrior thewarrior = new Warrior() { Name = "Kaladin Stormblessed" };


        [Fact]
        public void HeroNameIsCorrect()
        {
            //Arrange
           
            //Act
            string nametest = "Kaladin Stormblessed";
           
         
            
            
            //Assert
            Assert.Equal(nametest, thewarrior.Name);
           
            
            
            



        }
        [Fact]
        public void HeroLevelIsCorrect()
        {
            int Leveltest = 1;


            Assert.Equal(Leveltest, thewarrior.Level);
        }


        [Fact]
        public void Test3()

            
        {
            BaseAttribute baseAttributetest = new BaseAttribute() { Dexterity = 2, Intelligence = 1, Strength = 5 };
            Assert.Equal(baseAttributetest.Dexterity, thewarrior.BaseAttributes.Dexterity);

        }
        [Fact]
        public void Test4()
        {
            BaseAttribute baseAttributetest = new BaseAttribute() { Dexterity = 2, Intelligence = 1, Strength = 5 };
            Assert.Equal(baseAttributetest.Intelligence, thewarrior.BaseAttributes.Intelligence);
        }
        [Fact]
        public void Test5()
        {
            BaseAttribute baseAttributetest = new BaseAttribute() { Dexterity = 2, Intelligence = 1, Strength = 5 };
            Assert.Equal(baseAttributetest.Strength, thewarrior.BaseAttributes.Strength);
        }

        [Fact]
        public void Test6()
        {

        }
        




    }

    public class LevelUpAttributesTest
    {
        Warrior thewarrior23 = new Warrior() { Name = "Kaladin Stormblessed" };
       


        [Fact]
        public void BaseLevelUpWorks()
        {
            thewarrior23.LevelUp();
            int leveltest2 = 2;
            Assert.Equal(thewarrior23.Level, leveltest2);


        }

        [Fact]
        public void LevelingBaseAttributesWorks()
        {
            thewarrior23.LevelUp();
            int dex = 4;
            int intel = 2;
            int str = 8;
            BaseAttribute baseAttributetest = new BaseAttribute() { Dexterity = dex, Intelligence = intel, Strength = str };
            Assert.Equal(thewarrior23.BaseAttributes, baseAttributetest);

            //it does have the same outcome
        }







    }
    public class WeaponAndArmorCreation {


        Weapon razor = new Weapon() { Name = "Mehrunes Razor", RequiredLevel = 1, Slot = Slot.Weapon, weapontype = Weapon.WeaponType.Daggers, weaponDamage = 5 };
        Armor masterbody = new Armor() { Name = "Common Plate Chest", RequiredLevel = 1, Slot = Slot.Body, armortype = Armor.ArmorType.Plate, ArmorAttributes = new BaseAttribute() { Dexterity = 0, Intelligence = 0, Strength = 1 } };
        [Fact]
        public void WeaponNameWorks()
        {
            string testName = "Mehrunes Razor";
            
            Assert.Equal(razor.Name, testName);

        }

        [Fact]
        public void WeaponReqLevelWorks()
        {
            
            int testval = 1;
            Assert.Equal(razor.RequiredLevel, testval);

        }
        [Fact]
        public void WeaponSlotWorks()
        {
            var testSlot = Slot.Weapon;

            Assert.Equal(razor.Slot, testSlot);

        }
        [Fact]
        public void WeaponTypeWorks()
        {
            var testType = Weapon.WeaponType.Daggers;

            Assert.Equal(razor.weapontype, testType);

        }
        [Fact]
        public void WeaponDamageWorks()
        {
            int testDamage =5;

            Assert.Equal(razor.Name, "Mehrunes Razor");

        }

        [Fact]
        public void ArmorNameWorks()
        {
            string testName = "Common Plate Chest";

            Assert.Equal(masterbody.Name, testName);

        }
        [Fact]
        public void ArmorLevelWorks()
        {
            int testLevel = 1;

            Assert.Equal(masterbody.RequiredLevel, testLevel);

        }
        [Fact]
        public void ArmorSlotWorks()
        {
           var testSlot = Slot.Body;

           Assert.Equal(masterbody.Slot, testSlot);

        }

        [Fact]
        public void ArmorTypeWorks()
        {
            var testType = Armor.ArmorType.Plate;

            Assert.Equal(masterbody.armortype, testType);
        }

        [Fact]
        public void ArmorAttributesDexWorks()
        {

            int testval = 0;


            Assert.Equal(masterbody.ArmorAttributes.Dexterity, testval);

        }

        [Fact]
        public void ArmorAttributesIntWorks()
        {

            int testval = 0;


            Assert.Equal(masterbody.ArmorAttributes.Intelligence, testval);

        }

        [Fact]
        public void ArmorAttributeStrWorks()
        {

            int testval = 1;


            Assert.Equal(masterbody.ArmorAttributes.Strength, testval);

        }


        






    }

    public class EquipTests
    {

        Weapon razor = new Weapon() { Name = "Mehrunes Razor", RequiredLevel = 5, Slot = Slot.Weapon, weapontype = Weapon.WeaponType.Daggers, weaponDamage = 5 };
        Armor masterbody = new Armor() { Name = "Common Plate Chest", RequiredLevel = 5, Slot = Slot.Body, armortype = Armor.ArmorType.Plate, ArmorAttributes = new BaseAttribute() { Dexterity = 0, Intelligence = 0, Strength = 1 } };
        Warrior thewarrior = new Warrior() { Name = "Kaladin Stormblessed" };
        [Fact]
        public void WeaponLevelExceptionWorks()
        {


            thewarrior.EquipWeapon(razor);

            

        }

        [Fact]
        public void ArmorLevelExceptionWorks()
        {


            thewarrior.EquipArmor(masterbody);



        }

        Weapon razor1 = new Weapon() { Name = "Mehrunes Razor", RequiredLevel = 1, Slot = Slot.Weapon, weapontype = Weapon.WeaponType.Staffs, weaponDamage = 5 };
        Armor masterbody1 = new Armor() { Name = "Common Plate Chest", RequiredLevel = 1, Slot = Slot.Body, armortype = Armor.ArmorType.Cloth, ArmorAttributes = new BaseAttribute() { Dexterity = 0, Intelligence = 0, Strength = 1 } };

        [Fact]
        public void WeaponTypeExceptionWorks()
        {


            thewarrior.EquipWeapon(razor1);



        }

        [Fact]
        public void ArmorTypeExceptionWorks()
        {


            thewarrior.EquipArmor(masterbody1);



        }

       


    }
    public class TotalAttributeTests
    {
        Warrior thewarrior = new Warrior() { Name = "Kaladin Stormblessed" };
        Weapon razor = new Weapon() { Name = "Mehrunes Razor", RequiredLevel = 1, Slot = Slot.Weapon, weapontype = Weapon.WeaponType.Daggers, weaponDamage = 5 };
        Armor masterbody = new Armor() { Name = "Common Plate Chest", RequiredLevel = 1, Slot = Slot.Body, armortype = Armor.ArmorType.Plate, ArmorAttributes = new BaseAttribute() { Dexterity = 1, Intelligence = 1, Strength = 1 } };
        Armor masterhelmet = new Armor() { Name = "Common Plate Helmet", RequiredLevel = 1, Slot = Slot.Head, armortype = Armor.ArmorType.Plate, ArmorAttributes = new BaseAttribute() { Dexterity = 1, Intelligence = 1, Strength = 1 } };


        [Fact]
        public void OneItemWstrorks()
        {
            thewarrior.EquipArmor(masterbody);
            int checkstr = thewarrior.BaseAttributes.Strength;
            int checkint = thewarrior.BaseAttributes.Intelligence;
            int checkdex = thewarrior.BaseAttributes.Dexterity;

            int teststr = 5 + 1;
            int testint = 1 + 1;
            int testdex = 2 + 1;
            
            Assert.Equal(teststr, checkstr);


           

            
        }
        [Fact]
        public void OneItemIntWorks()
        {
            thewarrior.EquipArmor(masterbody);
            int checkstr = thewarrior.BaseAttributes.Strength;
            int checkint = thewarrior.BaseAttributes.Intelligence;
            int checkdex = thewarrior.BaseAttributes.Dexterity;

            int teststr = 5 + 1;
            int testint = 1 + 1;
            int testdex = 2 + 1;

            Assert.Equal(teststr, checkstr);





        }

        [Fact]
        public void OneItemDexWorks()
        {
            thewarrior.EquipArmor(masterbody);
            int checkstr = thewarrior.BaseAttributes.Strength;
            int checkint = thewarrior.BaseAttributes.Intelligence;
            int checkdex = thewarrior.BaseAttributes.Dexterity;

            int teststr = 5 + 1;
            int testint = 1 + 1;
            int testdex = 2 + 1;

            Assert.Equal(teststr, checkstr);





        }

        [Fact]
        public void TwoItemWstrorks()
        {
            thewarrior.EquipArmor(masterbody);
            thewarrior.EquipArmor(masterhelmet);
            int checkstr = thewarrior.BaseAttributes.Strength;
            int checkint = thewarrior.BaseAttributes.Intelligence;
            int checkdex = thewarrior.BaseAttributes.Dexterity;

            int teststr = 5 + 2;
            int testint = 1 + 2;
            int testdex = 2 + 2;

            Assert.Equal(teststr, checkstr);





        }
        [Fact]
        public void TwoItemIntWorks()
        {
            thewarrior.EquipArmor(masterbody);
            thewarrior.EquipArmor(masterhelmet);
            int checkstr = thewarrior.BaseAttributes.Strength;
            int checkint = thewarrior.BaseAttributes.Intelligence;
            int checkdex = thewarrior.BaseAttributes.Dexterity;

            int teststr = 5 + 2;
            int testint = 1 + 2;
            int testdex = 2 + 2;

            Assert.Equal(teststr, checkstr);





        }

        [Fact]
        public void TwoItemDexWorks()
        {
            thewarrior.EquipArmor(masterbody);
            thewarrior.EquipArmor(masterhelmet);
            int checkstr = thewarrior.BaseAttributes.Strength;
            int checkint = thewarrior.BaseAttributes.Intelligence;
            int checkdex = thewarrior.BaseAttributes.Dexterity;

            int teststr = 5 + 2;
            int testint = 1 + 2;
            int testdex = 2 + 2;

            Assert.Equal(teststr, checkstr);





        }







    }

    public class HeroDamageTests
    {
        // This test needs to be performed manually 

        Warrior thewarrior = new Warrior() { Name = "Kaladin Stormblessed" };
        Weapon razor = new Weapon() { Name = "Mehrunes Razor", RequiredLevel = 1, Slot = Slot.Weapon, weapontype = Weapon.WeaponType.Daggers, weaponDamage = 2 };
        Armor masterbody = new Armor() { Name = "Common Plate Chest", RequiredLevel = 1, Slot = Slot.Body, armortype = Armor.ArmorType.Plate, ArmorAttributes = new BaseAttribute() { Dexterity = 0, Intelligence = 0, Strength = 1 } };
        Armor masterhelmet = new Armor() { Name = "Common Plate Helmet", RequiredLevel = 1, Slot = Slot.Head, armortype = Armor.ArmorType.Plate, ArmorAttributes = new BaseAttribute() { Dexterity = 1, Intelligence = 1, Strength = 1 } };
        //[Fact]
        //public void WeapDamageWorks()
        //{
        //    thewarrior.EquipWeapon(razor);
        //    int testDamage2 = 2 * (1 + (5 / 100));

        //    //This is a way to check if the writeline outputs are correct
        //    using (var sw2 = new StringWriter())
        //    {
        //        Console.SetOut(sw2);

        //        thewarrior.Damage();

        //        string consoleOutput2 = sw2.ToString();

        //        Assert.Contains(("Total damage is " + testDamage2), consoleOutput2);



        //    }
        //}

        Warrior thewarrior2 = new Warrior() { Name = "Kaladin Stormblessed" };
        Weapon razor2 = new Weapon() { Name = "Mehrunes Razor", RequiredLevel = 1, Slot = Slot.Weapon, weapontype = Weapon.WeaponType.Daggers, weaponDamage = 2 };
        Armor masterbody2 = new Armor() { Name = "Common Plate Chest", RequiredLevel = 1, Slot = Slot.Body, armortype = Armor.ArmorType.Plate, ArmorAttributes = new BaseAttribute() { Dexterity = 0, Intelligence = 0, Strength = 1 } };
        Armor masterhelmet2 = new Armor() { Name = "Common Plate Helmet", RequiredLevel = 1, Slot = Slot.Head, armortype = Armor.ArmorType.Plate, ArmorAttributes = new BaseAttribute() { Dexterity = 1, Intelligence = 1, Strength = 1 } };
            



        //[Fact]
        ////public void WeapAndArmorDamageWorks()
        //{
        //    thewarrior2.EquipArmor(masterbody2);
        //    thewarrior2.EquipWeapon(razor2);
            
        //    int testDamage = 2 * (1 + ((5 + 1) / 100));

        //    //This is a way to check if the writeline outputs are correct
        //    using (var sw = new StringWriter())
        //    {
        //        Console.SetOut(sw);

        //        thewarrior2.Damage();

        //        string consoleOutput = sw.ToString();

        //        Assert.Contains(("Total damage is " + testDamage), consoleOutput);



        //    }

            //Doing these individually will give the correct results


        //}
       




    }



}