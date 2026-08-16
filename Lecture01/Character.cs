namespace CSharpSummer2026;

public class Character
{
    private string name;
    private float HP;
    protected float damage;
    private E_WeaponType weaponType;

    public Character(
        string name, 
        float HP, 
        float damage, 
        E_WeaponType weaponType)
    {
        this.name = name;
        this.HP = HP;
        this.damage = damage;
    }

    public void Attack()
    {
        Console.WriteLine($"{this.name} is attacking");
    }

}