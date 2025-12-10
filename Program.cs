class Rectangle
{

    public double side1;
    public double side2;



    public Rectangle(double side1, double side2)

    {
        this.side1 = side1;
        this.side2 = side2;

    }

    public double AreaCalculator()
    {


        return side1 * side2;

    }

    public double PerimetrCalculator()
    {
        return (side2 + side1) * 2;


    }

    public double Area
    {
        get

        {
            return side1 * side2;
        }


    }

    public double Perimetr
    {
        get

        {
            return (side2 + side1) * 2;
        }


    }
}
class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Введите длину первой стороны прямоугольника:");
        double side1 = double.Parse(Console.ReadLine());


        Console.WriteLine("Введите длину первой стороны прямоугольника:");
        double side2 = double.Parse(Console.ReadLine());


        Rectangle Area = new Rectangle(side1, side2);

        double CurrentArea = Area.AreaCalculator();
        //Console.WriteLine($"Площадь прямоугольника равна:{CurrentArea}");

        Rectangle Perimetr = new Rectangle(side1, side2);

        double CurrentPerimetr = Area.PerimetrCalculator();
        //Console.WriteLine($"Периметр прямоугольника равен:{CurrentPerimetr}");


        Console.WriteLine($"Площадь прямоугольника равна:{Area.Area}");
        Console.WriteLine($"Периметр прямоугольника равен:{Perimetr.Perimetr}");
    }


};