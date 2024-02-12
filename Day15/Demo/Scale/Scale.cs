namespace Scale
{
    /// <summary>
    /// Електронна везна
    /// </summary>
    /// <typeparam name="T">Тип на сравняваните елементи</typeparam>
    public class Scale<T> where T : IComparable<T>
    {
        private T left;
        private T right;

        /// <summary>
        /// Конструктор на класа
        /// </summary>
        /// <param name="left">Ляв</param>
        /// <param name="right">Десен</param>
        public Scale(T left, T right)
        {
            this.left = left;
            this.right = right;
        }

        /// <summary>
        /// Метод за сравняване на два елемента
        /// </summary>
        /// <returns>Връща по тежкия</returns>
        public T GetHeavier()
        {
            // left > right : left
            if (left.CompareTo(right) > 0)
            {
                return left;
            }
            // left < right : right
            else if (left.CompareTo(right) < 0)
            {
                return right;
            }
            // left = right : default (null or 0)
            else
            {
                return default(T);
            }
        }
    }
}
