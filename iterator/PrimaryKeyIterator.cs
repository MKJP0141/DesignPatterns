using System.Linq;

namespace iterator
{
    public class PrimaryKeyIterator : IAbstractIterator
    {
        private readonly Collection _collection;
        private int _current = 0;
        private int _steps = 1;

        public PrimaryKeyIterator(Collection collection)
        {
            this._collection = collection;
        }

        public bool IsFirst => _current == 0;
        public bool IsDone {
            get{
                var currentItme = _collection[_current] as Item;
                return currentItme.Id == _collection.Items().Max(x => ((Item)x).Id);
            }
        } 
        public Item CurrentItem => _collection[_current] as Item;

        public Item First()
        {
            _current = 0;
            return _collection.Items().Where(x => ((Item)x).Id == 0).Single() as Item;
        }

        public Item Next()
        {
            _current += _steps;
            if (!IsDone)
            {
                var item = _collection.Items().Where(x => ((Item)x).Id == _current + 1).First() as Item;
                return item;
            }
            else
            {
                return null;
            }
        }
    }
}