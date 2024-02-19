namespace StackOfStringsTask
{
    public partial class Program
    {
        public class StackOfStrings 
        {
            List<string> data;

            public StackOfStrings() 
            {
                data = new List<string>();
            }

            public void Push(string item) 
            {
                data.Add(item);
            }

            public string Pop()
            {
                string remove = Peek();
                data.Remove(remove);

                return remove;
            }

            public string Peek()
            {
                if (IsEmpty()) 
                {
                    throw new Exception("Empty list");
                }

                return data.Last();
            }

            public bool IsEmpty()
            {
                return (data.Count == 0);
            }
        }
    }
}