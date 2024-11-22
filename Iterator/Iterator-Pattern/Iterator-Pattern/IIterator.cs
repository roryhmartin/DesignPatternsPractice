namespace Iterator_Pattern;

public interface IIterator
{
    string Next(); // Move to the next item and return it.
    bool HasNext(); // Check if there are more items in the collection.
}