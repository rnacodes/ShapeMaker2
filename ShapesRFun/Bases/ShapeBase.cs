using ShapesRFun.Interfaces;
namespace ShapesRFun.Bases;

    public abstract class Shape : ICalculateArea
    {
        // Property for size
        public int Dimension { get; set; }

        // Abstract method for getting the area
        public abstract int GetArea();
    }

