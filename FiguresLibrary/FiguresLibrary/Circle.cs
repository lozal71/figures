using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace FiguresLibrary
{
    public class Circle : Ellipse
    {
        public Circle()
        {
            NameFigure = "Круг";
        }

        void OneAxis()
        {
            AxisSmall = CorrectInput("Введите радиус: ");
            AxisBig = AxisSmall;
        }

        public override double CalculateArea()
        {
            return base.CalculateArea();
        }

        public override double CalculatePerimeter()
        {
            return Round(2 * PI * AxisSmall,2);
        }


        public override void InputData()
        {
            OneAxis();
        }
    }
}
