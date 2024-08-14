namespace DI_Spaceship;

public class Spaceship
{
    public IEngine Engine { get; set; }
    public Spaceship() { }

    public void Fly()
    {
        Engine.Throttle(950);
    }
}

