using ShapesRFun.Bases;
using ShapesRFun.Interfaces;

internal class Square : Shape, IChangeShapes
{
    public override int GetArea()
    {        
       return Dimension * Dimension;
    }
    public int DoubleArea()
    {
        return Dimension * Dimension * 2;
    }

    public int HalveArea()
    {
        return Dimension * Dimension / 2;
    }
}


