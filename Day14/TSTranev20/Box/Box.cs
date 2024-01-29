namespace Box
{
    public class Box<T>
    {
        private List<T> data { get; set; }

        public Box()
        {
            this.data = new List<T>();
        }

        public int Count => this.data.Count;

        public void Add(T item)
        {
            this.data.Add(item);
        }

        public T Remove()
        {
            var rem = this.data.Last();
            this.data.RemoveAt(this.data.Count - 1);
            return rem;
        }
    }
}