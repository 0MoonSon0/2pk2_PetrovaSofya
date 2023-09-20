class Program
{
    static void Main()
    {
        Console.WriteLine("Введите тип фигуры (круг, прямоугольник, треугольник):");
        string shape = Console.ReadLine();

        switch (shape.ToLower())
        {
            case "круг":
                Console.WriteLine("Введите радиус круга:");
                double radius = double.Parse(Console.ReadLine());
                double circleArea = Math.PI * radius * radius;
                Console.WriteLine("Площадь круга: " + circleArea);
                break;

            case "прямоугольник":
                Console.WriteLine("Введите ширину прямоугольника:");
                double width = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите высоту прямоугольника:");
                double height = double.Parse(Console.ReadLine());
                double rectangleArea = width * height;
                Console.WriteLine("Площадь прямоугольника: " + rectangleArea);
                break;

            case "треугольник":
                Console.WriteLine("Введите основание треугольника:");
                double baseTriangle = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите высоту треугольника:");
                double heightTriangle = double.Parse(Console.ReadLine());
                double triangleArea = 0.5 * baseTriangle * heightTriangle;
                Console.WriteLine("Площадь треугольника: " + triangleArea);
                break;

            default:
                Console.WriteLine("Некорректный тип фигуры.");
                break;
        }
    }
}