namespace StackOfStrings
{
    /// <summary>
    /// Стек от стрингове
    /// </summary>
    public class StackOfStrings
    {
        /// <summary>
        /// Колекция от елементи
        /// </summary>
        private List<String> data;

        /// <summary>
        /// Конструктор на класа
        /// </summary>
        public StackOfStrings()
        {
            this.data = new List<string>();
        }

        /// <summary>
        /// Добавяне на елемент към колекцията
        /// </summary>
        public void Push(string element)
        {
            this.data.Add(element);
        }

        /// <summary>
        /// Изваждане на елемент от колекцията
        /// </summary>
        public string Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("No elements");
            }
            var element = Peek();
            this.data.Remove(element);
            return element;
        }

        /// <summary>
        /// Извеждане на последния елемент от колекцията
        /// </summary>
        public string Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("No elements");
            }
            return this.data.Last();
        }

        /// <summary>
        /// Проверка дали колекцията е празна
        /// </summary>
        public bool IsEmpty()
        {
            return this.data.Count == 0;
        }
    }
}
