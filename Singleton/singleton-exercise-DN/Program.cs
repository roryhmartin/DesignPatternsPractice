using singleton_exercise_DN;

class Program
{
    static void Main(string[] args)
    {
        
        //Access the Singleton instance
        Singleton singletonInstance = Singleton.Instance; 
        
        // Test: See if it works by making multiple copies of the singleton instance
        Singleton singletonInstance2 = Singleton.Instance;
        
        //Check if both references point to the same object
        bool areEqual = ReferenceEquals(singletonInstance, singletonInstance2);
        
        // Call the sayHello method
        singletonInstance.SayHello(); 
        
        // Output the equality check
        Console.WriteLine($"Are both instances equal? { areEqual }");
    }
}