namespace CSharpSummer2026;

public class Barbarian : Character
{
    private int rageMultiplier;
    
    public Barbarian(int rageMultiplier, string name, float HP, float damage, E_WeaponType weaponType) : 
        base(name, HP, damage, weaponType)
    {
       this.rageMultiplier = rageMultiplier;

       if (weaponType != E_WeaponType.GREAT_AXE && weaponType != E_WeaponType.MACE)
       {
           Console.WriteLine("Incorrect weapon type, revert to default");
           weaponType = E_WeaponType.GREAT_AXE;
       }
    }

    public void ApplyRage()
    {
        this.damage *= rageMultiplier;
        Console.WriteLine($"Applying Rage, now damage is {this.damage}");
    }
}