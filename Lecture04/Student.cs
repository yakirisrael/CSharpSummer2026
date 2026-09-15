namespace Lecture04;

public class Student : IWalkable
{
    public string Name { get; set; }

    override public string ToString()
    {
        return Name;
    }

    public void Walk(int speed)
    {
       Console.WriteLine(Name + " is walking in a speed of " + speed);
    }

    public Student(string name)
    {
        this.Name = name;
    }
}