// See https://aka.ms/new-console-template for more information

using CSharpSummer2026;

Barbarian barbarian = new Barbarian(
    10, "Barbi", 30, 30, E_WeaponType.GREAT_AXE);
    
Archer archer = new Archer(0.7f, "Legulas", 300, 10, E_WeaponType.BOW);

barbarian.Attack();
archer.Attack();

barbarian.ApplyRage();
barbarian.Attack();
archer.Shoot();
archer.Shoot();
