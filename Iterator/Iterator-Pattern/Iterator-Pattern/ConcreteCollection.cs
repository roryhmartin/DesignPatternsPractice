namespace Iterator_Pattern;

public class ConcreteCollection : IIterableCollection
{
    private List<string> elements = new List<string>(); // Stores the items in the collection.

    public IIterator CreateIterator()
    {
        // Returns a new iterator for this collection.
        return new ConcreteIterator(this);
    }
    
    // Methods to manage the collection
    public void AddElement(string element)
    {
        elements.Add(element); // Adds an element to the collection.
    }

    public string GetElement(int index)
    {
        return elements[index]; // Retrieves an element by index.
    }

    public int Count()
    {
        return elements.Count; // Returns the total number of elements in the collection.
    }
}