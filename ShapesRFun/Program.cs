namespace ShapesRFun
{
    internal class Program
    {
        static void Main()
        {
            int area = 0;
            Console.WriteLine("Welcome to the shape builder! Which shape can I make for you today?");

            string shapeToBuild = Console.ReadLine();

            Console.WriteLine("Thank you for choosing a " + shapeToBuild + "! What size would you like the shape to be?");

            int shapeSize = int.Parse(Console.ReadLine());
            int shapeSize2 = 0;

            if (shapeToBuild == "rectangle")
            {
                Console.WriteLine("What is the second dimension of the " + shapeToBuild +"?");
                shapeSize2 = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Thank you! I will now calculate the area of the shape.");

            Console.WriteLine("Calculating.....................");
            if (shapeToBuild == "rectangle")
            {
                area = CreateShape(shapeToBuild, shapeSize, shapeSize2);
            } else
                area = CreateShape(shapeToBuild, shapeSize);

            Console.WriteLine("The area of the " + shapeToBuild + " is " + area + ".");
        }
    
    static int CreateShape(string shapeToBuild, int shapeSize, int shapeSize2 = 0)
        {
            int area = 0;

            switch (shapeToBuild)
            {
                case "circle":
                    Circle circleShape = new Circle();
                    circleShape.Dimension = shapeSize;
                    area = circleShape.GetArea();
                    break;
                case "square":
                    Square squareShape = new Square();
                    squareShape.Dimension = shapeSize;
                    area = squareShape.GetArea();
                    break;
                case "rectangle":
                    Rectangle rectangleShape = new Rectangle();

                    rectangleShape.Dimension = shapeSize;
                    rectangleShape.Dimension2 = shapeSize2;
                    area = rectangleShape.GetArea();
                    break;
                default:
                    Console.WriteLine("That shape will be available in a future expansion pack!");
                    break;
            }

            return area;
        }
    }

}
