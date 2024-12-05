using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapesRFun.Interfaces;
using ShapesRFun.Bases;

internal class Circle : Shape
{
    public override int GetArea()
    {
        return (int)(Math.PI * Dimension * Dimension);
    }
}


