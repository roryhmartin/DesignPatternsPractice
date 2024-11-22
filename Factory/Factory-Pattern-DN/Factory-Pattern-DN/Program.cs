using Factory_Pattern_DN;

class Program
{
    static void Main(string[] args)
    {
        // Create a car using the CarFactory:
        IVehicleFactory carFactory = new CarFactory();
        IVehicle car = carFactory.CreateVehicle();
        car.Drive();
        
        // Create a motorbike using the motorbikeFactory
        IVehicleFactory MotorbikeFactory = new MotorbikeFactory();
        IVehicle motorbike = MotorbikeFactory.CreateVehicle();
        motorbike.Drive();
        
        //Create a Truck using the TruckFactory
        IVehicleFactory TruckFactoryVariable = new TruckFactory();
        IVehicle truck = TruckFactoryVariable.CreateVehicle();
        truck.Drive();
    }
}