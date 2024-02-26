namespace Cars
{
    /// <summary>
    /// Интерфейс автомобил
    /// </summary>
    public interface ICar
    {
        string Model { get; }
        string Color { get; }
        string Start();
        string Stop();
    }
}
