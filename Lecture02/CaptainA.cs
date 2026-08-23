namespace Gameplay.Soldiers;

public class CaptainA : Soldier
{
    public void FlickFlack()
    {
        Console.WriteLine($"Flick Flack with id = " + id);
    }

    public override void Attack()
    {
       base.Attack();
        
       Console.WriteLine($"Captain A doing an amazing Attack with id = " + id);
    }
}