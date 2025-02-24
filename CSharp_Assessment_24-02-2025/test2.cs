using System;
public class Student
{
    private string _name;
    private int _rollNo;

    public string Name
    {
        get { return _name; }
        set
        {
            if (value == null)
            {
                throw new ArgumentNullException("Name cannot be null");
            }
            _name = value;
        }
    }

    public int RollNo
    {
        get { return _rollNo; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException("RollNo cannot be less than or equal to 0");
            }
            _rollNo = value;
        }
    }

    public Student(string name, int rollno)
    {
        Name = name;
        RollNo = rollno;
    }
}

public class MainClass
{
    public static void Main()
    {
        Student s = new Student("John", 1);
        Student s1 = new Student(null, 0);
    }
}
