namespace Lecture03;

public class Vector2D
{
    private int x { get; set; }
    private int y { get; set; }
    
    public Vector2D(int x, int y)
    {
        this.x = x;
        this.y = y;
    }


    override public string ToString()
    {
        return $"({x}, {y}) haha control the world";
    }

    public override bool Equals(object? obj)
    {
        if (obj == null)
            return false;
        
        if (obj.GetType() != GetType())
            return false;
        
        Vector2D v = (Vector2D)obj;
        return this.x == v.x && this.y == v.y;
    }

    override public int GetHashCode()
    {
        return HashCode.Combine(x, y);
    }
}