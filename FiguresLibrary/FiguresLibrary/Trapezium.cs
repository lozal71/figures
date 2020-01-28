using System;
using static System.Math;
using static System.Console;

namespace FiguresLibrary
{
    public class Trapezium : Figure
    {
        private double baseSmall;
        private double baseBig;
        private double side;
        private double angleA;
        private double angleB;

        public Trapezium()
        {
            baseSmall = 0;
            baseBig = 0;
            side = 0;
            angleA = 0;
            angleB = 0;
            NameFigure = "Трапеция";
        }

        public double BaseSmall { get => baseSmall; set => baseSmall = value; }
        public double BaseBig { get => baseBig; set => baseBig = value; }
        public double Side { get => side; set => side = value; }
        public double AngleA 
        {
            get => Round((angleA * PI) / 180, 2);
            set => Round((angleA * PI) / 180, 2);
        }
        public double AngleB 
        {
            get => Round((angleB * PI) / 180, 2);
            set => Round((angleB * PI) / 180, 2);
        }

        void TwoBaseOneSideTwoAngle()
        {
            bool exist = false;
            do
            {
                try
                {
                    BaseBig = CorrectInput("Введите длину большего основания: ");
                    BaseSmall = CorrectInput("Введите длину меньшего основания: ");
                    Side = CorrectInput("Введите длину боковой стороны: ");
                    angleA = CorrectInput("Введите величину острого угла " +
                                           "между большим основанием " +
                                           "и боковой стороной (в градусах): ",EX_SHARP_ANGLE);
                    angleB = CorrectInput("Введите величину тупого угла " +
                                           "между меньшим основанием " +
                                           "и боковой стороной (в градусах): ",EX_OBTUSE_ANGLE);
                    if (angleA + angleB == 180)
                    {
                        exist = true;
                    }
                    else
                    {
                        throw new MyException(EX_TRAPEZIUM_NOT_EXIST);
                    }
                }
                catch (Exception ex)
                {
                    WriteLine(ex.Message);
                    WriteLine(TRY_AGAIN);
                }
            } while (!exist);

        }
        public override double CalculateArea()
        {
            double h = Side * Sin(AngleA);
            return Round(0.5 * h * (BaseBig + BaseSmall), 2);
        }

        public override double CalculatePerimeter()
        {
            double h = Side * Sin(AngleA);
            double big1 = Side * Sin(AngleB);
            double big2 = (BaseBig - BaseSmall - big1);
            double side1 = Sqrt(Pow(h, 2) + Pow(big2, 2));
            return Round(BaseBig + BaseSmall + Side + side1, 2);
       }


        public override void InputData()
        {
            TwoBaseOneSideTwoAngle();
        }
    }
}
