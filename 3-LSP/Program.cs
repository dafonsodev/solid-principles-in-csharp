// Bad Example (Violating LSP)
var squareBad = new _3_LSP.Violating.Square()
{
    Height = 20,
    Width = 20
};
var resultSquareBad = squareBad.Area();
Console.WriteLine("Bad Example (Violating LSP)");
Console.WriteLine($"Square area is {resultSquareBad}");

var rectangleBad = new _3_LSP.Violating.Rectangle()
{
    Height = 10,
    Width = 20
};
var resultRectangleBad = rectangleBad.Area();
Console.WriteLine($"Rectangle area is {resultRectangleBad}");
// Bad Example (Violating LSP)

Console.WriteLine();

// Good Example(Following OCP)
var squareGood = new _3_LSP.Following.Square()
{
    SideLength = 20
};
var resultSquareGood = squareGood.Area();
Console.WriteLine("Good Example(Following OCP)");
Console.WriteLine($"Square area is {resultSquareGood}");

var rectangleGood = new _3_LSP.Following.Rectangle()
{
    Height = 10,
    Width = 20
};
var resultRectangleGood = rectangleGood.Area();
Console.WriteLine($"Rectangle area is {resultRectangleGood}");
// Good Example(Following OCP)