using System.Collections;

namespace RandomList
{
    /// <summary>
    /// Колекция съдържаща метод за връщане на произволен елемент от колекцията
    /// </summary>
    public class RandomList : ArrayList
    {
        private Random random;

        /// <summary>
        /// Конструктор на класа
        /// </summary>
        public RandomList()
        {
            random = new Random();
        }

        /// <summary>
        /// Метод за връщане на произволен елемент от колекцията
        /// </summary>
        public object RandomString()
        {
            int index = random.Next(0, this.Count);
            object element = this[index];
            this.RemoveAt(index);
            return element;
        }
    }
}
