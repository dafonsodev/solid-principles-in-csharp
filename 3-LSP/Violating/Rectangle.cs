namespace _3_LSP.Violating
{
    public class Rectangle
    {
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }

        public double Area()
        {
            return Width * Height;
        }
    }
}
