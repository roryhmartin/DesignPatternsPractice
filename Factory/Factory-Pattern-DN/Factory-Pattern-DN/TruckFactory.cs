namespace Factory_Pattern_DN;

public class TruckFactory : IVehicleFactory
{
    public IVehicle CreateVehicle()
    {
        return new Truck();
    }
}