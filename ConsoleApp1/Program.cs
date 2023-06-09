// See https://aka.ms/new-console-template for more information
using ConsoleApp1;





Weapon mastersword = new Weapon() { Name = "Common Axe", RequiredLevel = 1, Slot = Slot.Weapon, weapontype = Weapon.WeaponType.Axes, weaponDamage = 2};

Armor masterbody = new Armor() { Name = "Common Plate Chest", RequiredLevel = 1, Slot = Slot.Body, armortype = Armor.ArmorType.Plate, ArmorAttributes = new BaseAttribute() {Dexterity = 0, Intelligence = 0, Strength = 1} };

Warrior thewarrior = new Warrior() { Name = "Kaladin Stormblessed" };

thewarrior.LevelUp();
thewarrior.Damage();
thewarrior.EquipWeapon(mastersword);
thewarrior.Damage();
thewarrior.EquipArmor(masterbody);
thewarrior.Damage();

