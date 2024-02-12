namespace AdvancedList
{
    public partial class Program
    {
        public class AdvancedList<T> where T : IComparable<T>
        {
            private T[] list;
            private int count;

            public AdvancedList() 
            { 
                list = new T[2];
            }

            public int Count() 
            {
                return count;
            }

            public void Add(T item)
            {
                if (count == list.Length)
                {
                    T[] largerArray = new T[list.Length * 2];
                    for (int i = 0; i < count; i++)
                    {
                        largerArray[i] = list[i];
                    }
                    list = largerArray;
                }

                list[count] = item;
                count++;
            }

            public T Remove(int index) 
            {
                if (index < 0 || index >= count)
                {
                    throw new IndexOutOfRangeException();
                }
                T item = list[index];
                for (int i = index; i < count - 1; i++)
                {
                    list[i] = list[i + 1];
                }
                count--;
                return item;
            }

            public bool Contains(T itemSearch) {
                bool found = false;

                foreach (T item in list)
                {
                    if (item.Equals(itemSearch)) 
                    { 
                        found = true;
                    }
                }

                return found;
            }

            public void Swap(int i1, int i2) 
            {
                if (i1 < 0 || i1 >= count || i2 < 0 || i2 >= count)
                {
                    throw new IndexOutOfRangeException();
                }

                T temp = list[i1]; 
                list[i1] = list[i2];
                list[i2] = temp;
            }

            public int CountGreaterThan(T itemGiven) 
            {
                int count = 0;

                foreach (T item in list)
                {
                    if (item.CompareTo(itemGiven) > 0) 
                    {
                        count++;
                    }
                }

                return count;
            }

            public T Min() 
            {
                return list.Min<T>();
            }

            public T Max()
            {
                return list.Max<T>();
            }
        }
    }
}