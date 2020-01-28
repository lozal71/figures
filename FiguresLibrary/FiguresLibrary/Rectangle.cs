using System;
using static System.Console;
using static System.Convert;

namespace FiguresLibrary
{
    public class Rectangle : Parallelogram
    {
        public Rectangle()
        {
            NameFigure = "Прямоугольник";
        }

        void TwoSide()
        {
            SideA = CorrectInput("Введите длину стороны A: ");
            SideB = CorrectInput("Введите длину стороны B: ");
            Angle = 90;
        }

        public override double CalculateArea()
        {
            return base.CalculateArea();
        }

        public override double CalculatePerimeter()
        {
            return base.CalculatePerimeter();
        }

        public override void InputData()
        {
            TwoSide();
        }

    }
}
