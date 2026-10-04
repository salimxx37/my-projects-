using System.Threading.Channels;

class Shipe
{
    public virtual void CalculateArea()
    {
        Console.WriteLine("Calculating area of Shipe");
    }


}
class Circle : Shipe
{ public Circle(double radius)
    {
        Radius = radius;
    }
    public double Radius;
    public override void CalculateArea()
    {
        double area = Math.PI * Radius * Radius;
        Console.WriteLine("Calculating area of Circle");
        Console.WriteLine("");
        Console.WriteLine($"PI = {Math.PI} , Radius = {Radius}");
        Console.WriteLine("");
        Console.WriteLine($" Area = PI * Radius * Radius");
        Console.WriteLine("");
        Console.WriteLine($"Area = {Math.PI} * {Radius} * {Radius}");
        Console.WriteLine("_________________________");
        Console.WriteLine($"Area: {area}");
        Console.WriteLine("_________________________");
    }
}
class Rectangle : Shipe
   
{
    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }
    public double Width;
    public double Height;
    public override void CalculateArea()
    {
        double area = Width * Height;
        Console.WriteLine("Calculating area of Rectangle"); 
        Console.WriteLine("");
        Console.WriteLine($"Width = {Width}, Height = {Height}"); Console.WriteLine("");
        Console.WriteLine($"Area = Width * Height");
        Console.WriteLine("");
        Console.WriteLine($"Area = {Width} * {Height}");
        Console.WriteLine("_________________________");
        Console.WriteLine($"Area: {area}");
        Console.WriteLine("_________________________");
    }
}
class program
{
    static void Main(string[] args)
    {

       
        Circle circle1 = new Circle(2.5);
     
        Rectangle rectangle1 = new Rectangle(3.2, 5.5);
     List<Shipe> membars = new List<Shipe>();
        membars.Add(circle1);
        membars.Add(rectangle1);
        foreach (var membar in membars)
        {
            membar.CalculateArea();
        }

    }
}
