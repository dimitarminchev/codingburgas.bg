using System.Collections;

namespace RandomListTask
{
    public partial class Program
    {
        public class RandomList : ArrayList
        {
            private Random rand;

            public RandomList()
            {
                rand = new Random();
            }

            public object RandomString() 
            {
                int index = rand.Next(0, this.Count);
                object element = this[index];
                this.Remove(element);

                return element;
            }
        }
    }
}