using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleton_exercise_DN;

public class Singleton
{
    public static Singleton instance; // Holds the single instance

    // Private constructor to prevent external instantiation
    private Singleton()
    {
        // Initialise code if any
    }

    public static Singleton Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }
    }
    
    // add other methods or properties as needed
    // such as
    public void SayHello()
    {
        Console.WriteLine("Hello there");
    }
    
}
