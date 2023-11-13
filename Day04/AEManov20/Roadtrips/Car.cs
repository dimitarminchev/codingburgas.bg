namespace Roadtrips;

public class Car
{
    /// <summary>
    /// The model of the car.
    /// </summary>
    public string Model { get; set; }

    /// <summary>
    /// The amount of fuel left in the car. (in liters)
    /// </summary>
    public decimal FuelLeft { get; set; }

    /// <summary>
    /// The amount of fuel the car consumes per kilometer. (in liters)
    /// </summary>
    public decimal FuelPerKilometer { get; set; }

    /// <summary>
    /// The total distance the car has driven. (in kilometers)
    /// </summary>
    public decimal Mileage { get; set; }

    /// <summary>
    /// Drives the car for the specified amount of kilometers.
    /// </summary>
    /// <param name="kilometers">The amount of kilometers to drive.</param>
    public void Drive(decimal kilometers)
    {
        if (FuelLeft == 0)
        {
            Console.WriteLine("Insufficient fuel for the drive");
            return;
        }

        if (FuelLeft - kilometers * FuelPerKilometer >= 0)
        {
            FuelLeft -= kilometers * FuelPerKilometer;
            Mileage += kilometers;
        }
        else
        {
            Mileage += FuelLeft / FuelPerKilometer;
            FuelLeft = 0;
        }
    }

    public override string ToString()
    {
        return $"{Model} {FuelLeft:f2} {Mileage:f0}";
    }
}