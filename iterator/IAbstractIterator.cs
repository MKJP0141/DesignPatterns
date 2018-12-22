namespace iterator
{
    public interface IAbstractIterator
    {
        Item First();
        Item Next();
        bool IsDone {get;}
        Item CurrentItem{get;}     
    }
}