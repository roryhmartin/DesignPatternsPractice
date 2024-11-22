namespace Factory_Pattern_DN;

public class CarFactory : IVehicleFactory
{
    public IVehicle CreateVehicle()
    {
        return new Car();
    }
}