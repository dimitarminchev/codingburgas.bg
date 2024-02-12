namespace BetterList
{
    public class BetterList<T> where T : IComparable<T>
    {
        private T[] _items;

        private int _count;

        public BetterList()
        {
            _items = new T[2];
        }
        public void Add(T item)
        {
            _items[_count] = item;
            _count++;
        }

        public T Get(int index)
        {
            return _items[index];
        }

        public int Count
        {
            get { return _count; }
        }


        public T Remove(int index)
        {
            T item = _items[index];
            for (int i = index; i < _count - 1; i++)
            {
                _items[i] = _items[i + 1];
            }
            _count--;
            return item;
        }

        public bool Contains(T element)
        {
            for (int i = 0; i < _count; i++)
            {
                if (_items[i].Equals(element))
                {
                    return true;
                }
            }
            return false;
        }

        public void Swap(int index1, int index2)
        {
            T temp = _items[index1];
            _items[index1] = _items[index2];
            _items[index2] = temp;
        }

        public int CountGreaterThan(T element)
        {
            int counter = 0;
            for (int i = 0; i < _count; i++)
            {
                if (_items[i].CompareTo(element) > 0)
                {
                    counter++;
                }
            }
            return 0;
        }

        public T Max()
        {
            return _items.Max<T>();
        }

        public T Min()
        {
            return _items.Min<T>();
        }
    }
}