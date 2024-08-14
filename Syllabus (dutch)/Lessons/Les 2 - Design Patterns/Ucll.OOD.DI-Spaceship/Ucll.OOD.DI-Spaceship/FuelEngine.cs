namespace DI_Spaceship;

public class FuelEngine : IEngine
{
    private int ammountofFuel = 0;

    public FuelEngine(int ammountofFuel)
    {
        this.ammountofFuel = ammountofFuel;
    }

    public void Throttle(int distance)
    {
        if (ammountofFuel > distance)
        {
            Console.WriteLine("We flew.");
        }
        else
        {
            Console.WriteLine("Grounded.");
        }
    }
}