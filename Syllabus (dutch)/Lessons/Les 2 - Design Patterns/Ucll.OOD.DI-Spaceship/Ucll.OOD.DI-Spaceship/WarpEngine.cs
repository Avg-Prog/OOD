namespace DI_Spaceship;

public class WarpEngine : IEngine
{
    public void Throttle(int distance)
    {
        Console.WriteLine("We warped.");
    }
}
