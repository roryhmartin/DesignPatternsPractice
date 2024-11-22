using Iterator_Pattern;

class Program
{
    static void Main(string[] args)
    {
        // Create a collection and add elements to it.
        ConcreteCollection collection = new ConcreteCollection();
        collection.AddElement("Item 1");
        collection.AddElement("Item 2");
        collection.AddElement("item 3");
        
        // Create an iterator for the collection.
        IIterator iterator = collection.CreateIterator();

        // Use the iterator to go through the collection.
        while (iterator.HasNext())
        {
            string element = iterator.Next(); // Get the next element.
            Console.WriteLine(element); // Print the element.
        }
    }
}