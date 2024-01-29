namespace BoxForEverything
{
    public class Box<T>
    {
        private T value { get; set; }

        public Box(T value)
        {
            this.value = value;
        }

        public override string ToString()
        {
            return $"{value.GetType().FullName}: {value}";
        }
    }
}