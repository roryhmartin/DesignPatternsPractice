namespace Factory_Pattern_DN;

public interface IVehicleFactory
{
    IVehicle CreateVehicle(); // All factories must implement this method.
}