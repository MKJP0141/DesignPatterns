namespace iterator
{
    public class Iterator:IAbstractIterator
    {
        private Collection _collection;
        private int _current = 0;
        private int _step = 1;

        public Iterator(Collection collection)
        {
            this._collection = collection;
        }

        public bool IsFirst => _current == 0;
        public bool IsDone => _current >= _collection.Count;

        public Item CurrentItem => _collection[_current] as Item;

        public Item First()
        {
            _current = 0;
            return _collection[_current] as Item;
        }

        public Item Last()
        {
            _current = _collection.Count - 1;
            return _collection[_current] as Item;
        }

        public Item Next()
        {
            _current += _step;
            if (!IsDone)
            {
                return _collection[_current] as Item;
            }
            else
            {
                return null;
            }
        }

        public Item Prev()
        {
            _current -= _step;
            if (!IsFirst)
            {
                return _collection[_current] as Item;
            }
            else
            {
                return null;
            }
        }

        public int Step
        {
            get => _step;
            set { _step = value;}
        }
    }
}