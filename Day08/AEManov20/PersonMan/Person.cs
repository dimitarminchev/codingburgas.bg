namespace PersonMan;

public class Person
{
    private string name;
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    
    private int age;
    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    private static int personInstancesCount = 0;

    public static int PersonInstancesCount
    {
        get { return personInstancesCount; }
    }

    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
        personInstancesCount++;
    }
}