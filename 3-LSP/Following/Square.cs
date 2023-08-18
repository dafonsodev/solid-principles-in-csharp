namespace _3_LSP.Following
{
    public class Square : Shape
    {
        public double SideLength { get; set; }

        public override double Area()
        {
            return SideLength * SideLength;
        }
    }
}
