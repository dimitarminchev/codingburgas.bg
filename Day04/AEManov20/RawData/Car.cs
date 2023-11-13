namespace RawData;

public class Engine
{
    public int Speed { get; set; }
    public int Power { get; set; }
}

public class Tire
{
    public double Pressure { get; set; }
    public int Age { get; set; }
}

public class Load
{
    public int Weight { get; set; }
    public string Type { get; set; }
}

public class Model
{
    public string Name { get; set; }
}

public class Car
{
    public Engine Engine { get; set; }
    public Model Model { get; set; }
    public Load Load { get; set; }
    public List<Tire> Tires { get; set; }

    public Car(Model model, Engine engine, Load load, List<Tire> tires)
    {
        Engine = engine;
        Model = model;
        Load = load;
        Tires = tires;
    }
}
