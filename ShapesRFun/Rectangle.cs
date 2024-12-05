using ShapesRFun.Bases;
using ShapesRFun.Interfaces;

public class Rectangle : SpecialShape, IChangeShapes
    {
    // Implement any additional members or override methods here
    public override int GetArea()
    {
        return Dimension * Dimension2;
    }

    public int DoubleArea()
    {
        return Dimension * Dimension2 * 2;
    }

    public int HalveArea()
    {
        return Dimension * Dimension2 / 2;
    }
}
