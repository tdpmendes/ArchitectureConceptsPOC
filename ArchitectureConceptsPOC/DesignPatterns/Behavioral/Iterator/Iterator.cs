using System;

namespace ArchitectureConceptsPOC.DesignPatterns.Behavioral.Iterator
{
    public class Iterator : IAbstractIterator
    {
        private Collection _targetCollection;
        private int _current = 0;
        private int _step = 1;

        public Iterator(Collection collection)
        {
            _targetCollection = collection ?? throw new ArgumentNullException(nameof(collection));
        }

        public Item CurrentItem
        {
            get { return _targetCollection[_current]; }
        }

        public Item First()
        {
            _current = 0;
            return _targetCollection[_current];
        }

        public bool IsDone
        {
            get { return _current >= _targetCollection.Count; }
        }

        public Item Next()
        {
            _current += _step;
            if (!IsDone)
                return _targetCollection[_current];
            else
                return null;
        }

        public int Step
        {
            get { return _step; }
            set { _step = value; }
        }
    }
}
