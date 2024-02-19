namespace StackOfStrings
{
    public class StackOfStrings
    {
        private List<String> l;

        public StackOfStrings()
        {
            this.l = new List<string>();
        }

        public void Push(string el)
        {
            this.l.Add(el);
        }

        public string Peek()
        {
            return this.l.Last();
        }

        public string Pop()
        {
            var el = Peek();
            this.l.Remove(el);
            return el;
        }

        public bool IsEmpty()
        {
            return this.l.Count == 0;
        }
    }
}
