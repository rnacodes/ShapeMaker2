using ShapesRFun.Bases;
using System;
using ShapesRFun.Interfaces;

namespace ShapesRFun   
{ 
    internal class ProgramHelpers
    {
    static int CreateShape(string shapeToBuild, int shapeSize)
        {
            int area = 0;

            switch (shapeToBuild)
            {
                case "circle":
                    Circle circleShape = new Circle();
                    circleShape.Radius = shapeSize;
                    area = circleShape.GetArea();
                    break;
                case "square":
                    Square squareShape = new Square();
                    squareShape.Length = shapeSize;
                    area = squareShape.GetArea();
                    break;
                default:
                    Console.WriteLine("That shape will be available in a future expansion pack!");
                    break;
            }

            return area;
        }
}

}
