namespace Lecture04;


public class Students
{
    private readonly int capacity;
    Student[] students_array = null;

    public override string ToString()
    {
        string result = "";
        foreach (var s in students_array)
        {
            result += s + " ";
        }

        return result;
    }

    public Students(int capacity)
    {
        this.capacity = capacity;
        students_array =  new Student[this.capacity];
    }

    public void Walk(int speed)
    {
        foreach (var s in students_array)
        {
            s.Walk(speed);
        }
    }

    public Student this[int index]
    {
        get
        {
            if (IsValidIndex(index))
               throw new ArgumentOutOfRangeException("This is not a valid index!");
            
            return students_array[index];
        }
        set
        {
            if (IsValidIndex(index))
                throw new ArgumentOutOfRangeException("This is not a valid index!");
            
            students_array[index] = value;
        }
    }

    private bool IsValidIndex(int index)
    {
        return index < 0 || index >= this.capacity;
    }
}