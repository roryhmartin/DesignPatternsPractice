namespace Iterator_Pattern;

public interface IIterableCollection
{
    IIterator CreateIterator(); // Create and return an iterator for the collection.
}