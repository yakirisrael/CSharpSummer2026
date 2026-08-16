namespace CSharpSummer2026;

public class Archer : Character
{
    private float accuracy;
    public Archer(float accuracy, string name, float HP, float damage, E_WeaponType weaponType) :
        base(name, HP, damage, weaponType)
    {
        this.accuracy = accuracy;
    }

    public void Shoot()
    {
        
        this.damage *= this.accuracy;
        Console.WriteLine($"Shooting, make damage = {this.damage}");
    }
}