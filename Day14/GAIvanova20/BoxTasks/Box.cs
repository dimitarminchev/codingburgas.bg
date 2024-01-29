namespace BoxTasks
{
    public partial class Program
    {
        public class Box<T>
        {
            private T boxValue { get; set; }

            public Box(T value)
            {
                this.boxValue = value;
            }

            public override string ToString()
            {
                return $"{boxValue.GetType().FullName}: {boxValue}";
            }
        }
    }
}