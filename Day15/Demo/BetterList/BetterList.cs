namespace BetterList
{
    /// <summary>
    /// Списък с елементи
    /// </summary>
    /// <typeparam name="T">Тип на елементите</typeparam>
    public class BetterList<T> where T : IComparable<T>
    {
        private T[] _items;

        private int _count;

        /// <summary>
        /// Конструктор
        /// </summary>
        public BetterList()
        {
            _items = new T[2];
        }

        /// <summary>
        /// Добавяне на елемент към списъка
        /// </summary>
        /// <param name="item">Елемент за добавяне</param>
        public void Add(T item)
        {
            if (_count == _items.Length)
            {
                T[] largerArray = new T[_items.Length * 2];
                for (int i = 0; i < _count; i++)
                {
                    largerArray[i] = _items[i];
                }
                _items = largerArray;
            }
            _items[_count] = item;
            _count++;
        }

        /// <summary>
        /// Взимане на елемент от списъка
        /// </summary>
        /// <param name="index">Позиция на елемента</param>
        /// <returns>Връща елемента</returns>
        /// <exception cref="IndexOutOfRangeException">Грешка ако сме извън обхват</exception>
        public T Get(int index)
        {
            if (index < 0 || index >= _count)
            {
                throw new IndexOutOfRangeException();
            }
            return _items[index];
        }

        /// <summary>
        /// Брой елементи в списъка
        /// </summary>
        public int Count
        {
            get { return _count; }
        }

        /// <summary>
        /// Премахване на елемент от списъка
        /// </summary>
        /// <param name="index">Позиция на елемента</param>
        /// <returns>Връща елемента</returns>
        /// <exception cref="IndexOutOfRangeException">Грешка ако сме извън обхват</exception>
        public T Remove(int index)
        {
            if (index < 0 || index >= _count)
            {
                throw new IndexOutOfRangeException();
            }
            T item = _items[index];
            for (int i = index; i < _count - 1; i++)
            {
                _items[i] = _items[i + 1];
            }
            // TODO: Свиване на масива, когато броя на елементите намалее 
            _count--;
            return item;
        }

        /// <summary>
        /// Създържа ли се елемент в списъка
        /// </summary>
        /// <param name="element">Елемента който търсим</param>
        /// <returns>Да / Не</returns>
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

        /// <summary>
        /// Размяна на елементите на две позиции
        /// </summary>
        /// <param name="index1">Първа позиция</param>
        /// <param name="index2">Втора позиция</param>
        /// <exception cref="IndexOutOfRangeException">Грешка ако сме извън обхват</exception>
        public void Swap(int index1, int index2)
        {
            if (index1 < 0 || index1 >= _count || index2 < 0 || index2 >= _count)
            {
                throw new IndexOutOfRangeException();
            }
            T temp = _items[index1];
            _items[index1] = _items[index2];
            _items[index2] = temp;
        }

        /// <summary>
        /// Брой елементи по-големи от даден елемент
        /// </summary>
        /// <param name="element">Елемента който сравняваме</param>
        /// <returns>Брой елементи</returns>
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

        /// <summary>
        /// Максимален елемент
        /// </summary>
        /// <returns>Максимален елемент</returns>
        public T Max()
        {
            return _items.Max<T>();
        }

        /// <summary>
        /// Минимален елемент
        /// </summary>
        /// <returns>Минимален елемент</returns>
        public T Min()
        {
            return _items.Min<T>();
        }
    }
}
