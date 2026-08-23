using Gameplay.Soldiers;

namespace Lecture02;

public class Falcon : CaptainA
{
    public override void Attack()
    {
        base.Attack();
        
        Console.WriteLine($"Falcon doing an super duper amazing Attack with id = " + id);
    }
}