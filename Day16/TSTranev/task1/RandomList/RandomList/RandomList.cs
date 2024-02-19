using System.Collections;

namespace RandomList
{
    public class RandomList : ArrayList
    {
        private Random ran;

        public RandomList()
        {
            ran = new Random();
        }

        public object RandString()
        {
            int index = ran.Next(0, this.Count);
            object element = this[index];
            this.RemoveAt(index);
            return element;
        }
    }
}
