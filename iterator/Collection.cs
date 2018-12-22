using System.Collections;
using System.Collections.Generic;

namespace iterator
{
    public class Collection : IAbstractCollection
    {
        private ArrayList _items = new ArrayList();

        public Iterator CreateIterator()
        {
            return new Iterator(this);
        }

        public IAbstractIterator CreateIdIterator()
        {
            return new PrimaryKeyIterator(this);
        }

        public int Count
        {
            get {return _items.Count;}
        }

        public object this[int index]
        {
            get => _items[index];
            set { _items.Add(value);}
        }

        public IEnumerable<object> Items()
        {
            foreach (var item in _items)
            {
                yield return item;
            }
        }
    }
}