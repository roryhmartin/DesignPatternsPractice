using System.Runtime.Intrinsics.X86;

namespace Iterator_Pattern;

public class ConcreteIterator : IIterator
{
    private ConcreteCollection collection; // The collection it will iterate over.
    private int index = 0; // Keeps track of the current position.

    public ConcreteIterator(ConcreteCollection collection)
    {
        this.collection = collection; // Assigns the collection to iterate over.
    }

    public string Next()
    {
        if (HasNext())
        {
            // Get the current element and move to the next position.
            string element = collection.GetElement(index);
            index++;
            return element;
        }

        else
        {
            return null; // If no more items, return null.
        }
    }

    public bool HasNext()
    {
        // Check if there are more items in the collection.
        return index < collection.Count();
    }
}