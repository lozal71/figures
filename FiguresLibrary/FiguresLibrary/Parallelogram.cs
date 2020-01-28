using System;
using static System.Console;
using static System.Convert;
using static System.Math;

namespace FiguresLibrary
{
    public class Parallelogram : Figure
    {
        private double sideA;
        private double sideB;
        private double angle;
       public Parallelogram()
        {
            sideA = 0;
            sideB = 0;
            angle = 0;
            NameFigure = "Параллелограмм";
        }
        protected double SideA { get => sideA; set => sideA = value; }
        protected double SideB { get => sideB; set => sideB = value; }
        protected double Angle
        {
            get => angle;
            set => angle = Round((value * PI) / 180, 2);
        }

        protected void TwoSideAngle()
        {
            SideA = CorrectInput("Введите длину стороны A: ");
            SideB = CorrectInput("Введите длину смежной стороны B: ");
            Angle = CorrectInput("Введите величину острого угла " +
                                 "между сторонами A и B в градусах: ",EX_SHARP_ANGLE);
        }
        public override double CalculateArea()
        {
            double s = 0;
            s = Round(SideA * SideB * Sin(Angle), 2);
            return s;
        }
        public override double CalculatePerimeter()
        {
            return Round(2 * SideA + 2 * SideB, 2);
        }
        public override void InputData()
        {
            TwoSideAngle();
        }
    }
}
