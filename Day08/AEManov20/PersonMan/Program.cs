namespace PersonMan;

class Program
{
    static void Main(string[] args)
    {
        // generate people
        Person p1 = new Person("John", 25);
        Person p2 = new Person("Mary", 30);
        Person p3 = new Person("Peter", 35);

        Console.WriteLine(Person.PersonInstancesCount);
    }
}
