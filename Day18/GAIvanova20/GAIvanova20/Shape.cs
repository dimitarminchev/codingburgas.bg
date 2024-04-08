namespace GAIvanova20
{
    public partial class Program
    {
        public abstract class Shape 
        {
            public abstract double calculatePerimeter();
            public abstract double calculateArea();
            public virtual string Draw() 
            {
                return "Shape";
            }
        }
    }
}