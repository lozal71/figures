using System;
using static System.Math;
using static System.Console;
using static System.Convert;

namespace FiguresLibrary
{
    public class Rhomb : Parallelogram
    {
        public Rhomb()
        {
            NameFigure = "Ромб";
        }

        void OneSideAngle()
        {
            SideA = CorrectInput("Введите длину стороны: ");
            SideB = SideA;
            Angle = CorrectInput("Введите величину острого угла " +
                                 "между сторонами (в градусах): ", EX_SHARP_ANGLE);
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
            OneSideAngle();
        }
    }
}
