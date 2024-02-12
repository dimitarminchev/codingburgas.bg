namespace ArrayCreator
{
    public partial class Program
    {
        public static class ArrayCreator
        {
            public static T[] addItems<T>(int size, T item) 
            {
                T[] items = new T[size];

                for (int i = 0; i < size; i++) 
                {
                    items[i] = item;
                }
                return items;
            }
        }
    }
}