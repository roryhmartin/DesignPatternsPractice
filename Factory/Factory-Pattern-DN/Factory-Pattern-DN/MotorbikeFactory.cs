namespace Factory_Pattern_DN;

public class MotorbikeFactory : IVehicleFactory
{
    public IVehicle CreateVehicle()
    {
       return new Motorbike();
    }
}