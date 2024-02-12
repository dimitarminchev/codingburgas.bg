namespace ArrayCreator
{
    public static class ArrayCreator
    {
        public static T[] Create<T>(int len, T item)
        {
            T[] arr = new T[len];
            for (int i = 0; i < len; i++)
            {
                arr[i] = item;
            }
            return arr;
        }
    }
}
