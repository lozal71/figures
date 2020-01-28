using System;
using static System.Console;
using static System.Convert;

namespace FiguresLibrary
{
    public class Quadrate :Parallelogram
    {
        public Quadrate()
        {
            NameFigure = "Квадрат";
        }

        void OneSide()
        {
            SideA = CorrectInput("Введите длину стороны A: ");
            SideB = SideA;
            Angle = 90;
        }

        public override double CalculateArea()
        {
            //throw new NotImplementedException();
            return base.CalculateArea();
        }

        public override double CalculatePerimeter()
        {
            //throw new NotImplementedException();
            return base.CalculatePerimeter();
        }


        public override void InputData()
        {
            OneSide();
        }
    }
}
