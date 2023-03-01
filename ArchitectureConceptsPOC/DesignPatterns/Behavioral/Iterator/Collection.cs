using System.Collections.Generic;

namespace ArchitectureConceptsPOC.DesignPatterns.Behavioral.Iterator
{
    public class Collection : IAbstractCollection
    {
        private IList<Item> _items = new List<Item>();

        public Iterator CreateIterator()
        {
            return new Iterator(this);
        }

        public int Count
        {
            get
            {
                return _items.Count;
            }
        }

        public Item this[int index]
        {
            get { return _items[index]; }
            set { _items.Add(value); }
        }

    }
}
