public class Planet
{
	private string name;

	public string Name
	{
		get { return name; }
		set { name = value; }
	}

	private int metal;

	public int Metal
	{
		get { return metal; }
		set { metal = value; }
	}

	private int mineral;

	public int Mineral
	{
		get { return mineral; }
		set { mineral = value; }
	}

	private List<Mine> mines = new List<Mine>();

    public List<Mine> Mines
    {
        get { return mines; }
        set { mines = value; }
    }

	public void AddMine (Mine mine)
	{
		mines.Add(mine);
        Console.WriteLine($"On {name} was builded {mine.Name}");
    }

	private List<Ship> ships = new List<Ship>();

    public List<Ship> Ships
    {
        get { return ships; }
        set { ships = value; }
    }

	public void AddShip (Ship ship, int counter)
	{
		ships.Add(ship);
        Console.WriteLine($"On {name} was builded {ship.Name} {counter}");
    }

	


}