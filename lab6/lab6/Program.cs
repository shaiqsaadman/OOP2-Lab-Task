using System;

class Student
{
    private int id;
    private string name;
    private string department;
    private float cgpa;


    public void SetName(string n)
    {
        name = n;
    }
    public string GetName()
    {
        return name;
    }

    public void SetId(int r)
    {
        id = r;
    }
    public int GetId()
    {
        return id;
    }
}

class Test
{
    static void Main(string[] args)
    {
        Student s = new Student();
        s.SetId(1);

        s.SetName("Shaiq");

        string a = s.GetName();

        Console.WriteLine(a);
    }
}