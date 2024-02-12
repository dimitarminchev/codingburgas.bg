namespace ArrayCreator
{
    /// <summary>
    /// Клас за създаване на масив с еднотипни елемнти
    /// </summary>
    public static class ArrayCreator
    {
        /// <summary>
        /// Метод за създаване на масив с еднотипни елементи
        /// </summary>
        /// <typeparam name="T">Тип на елемента</typeparam>
        /// <param name="lenght">Дължина на масива</param>
        /// <param name="item">Елемент който добавяме</param>
        /// <returns>Масив от еднотипни елементи</returns>
        public static T[] Create<T>(int lenght, T item)
        {
            T[] array = new T[lenght];
            for (int i = 0; i<lenght; i++)
            {
                array[i] = item;
            }
            return array;
        }
    }
}
