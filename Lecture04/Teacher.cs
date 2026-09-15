namespace Lecture04;

public class Teacher : IWalkable
{
    public void Teach()
    {
        Console.WriteLine("Blah blah, no one listening");
    }

    public void Walk(int speed)
    {
        Console.WriteLine("I running like a cheeta");
    }
}