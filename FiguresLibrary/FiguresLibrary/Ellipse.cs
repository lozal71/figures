using System;
using static System.Math;
using static System.Console;

namespace FiguresLibrary
{
    public class Ellipse : Figure, IPoligon
    {
        private double axisSmall;
        private double axisBig;

        public Ellipse()
        {
            axisSmall = 0;
            axisBig = 0;
        }
        public override string NameFigure
        {
            get => "Эллипс";
        }

        protected void TwoAxis()
        {
            bool correct = false;
            do
            {
                try
                {
                    AxisSmall = CorrectInput("Введите длину меньшей оси: ");
                    AxisBig = CorrectInput("Введите длину большей оси: ");
                    if (AxisSmall <= AxisBig)
                    {
                        correct = true;
                    }
                    else
                    {
                        throw new MyException(EX_ELLIPS);
                    }
                }
                catch (Exception ex)
                {
                    WriteLine(ex.Message);
                    WriteLine(TRY_AGAIN);
                }
            } while (!correct);
        }

        public double AxisSmall { get => axisSmall; set => axisSmall = value; }
        public double AxisBig { get => axisBig; set => axisBig = value; }
        public override double Area
        {
            get
            {
                return Round(2 * AxisSmall * AxisBig, 2);
            }
    }
        public override double Perimeter
        {
            get
            {
                double l = PI * AxisSmall * AxisBig;
                l += Pow(AxisBig - axisSmall, 2);
                l /= AxisSmall + AxisBig;
                return Round(4 * l, 2);
            }
        }

        public double Base { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double Side { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double SideA { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double SideB { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double SideC { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double BaseBig { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double BaseSmall { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double AngleBaseSide { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double AngleBaseBigSide { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double AngleBaseSmallSide { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void InputData()
        {
            TwoAxis();
        }

        public override void Draw(int posX, int posY, ConsoleColor consoleColor)
        {
            ForegroundColor = consoleColor;
            SetCursorPosition(posX, posY);
            WriteLine("          ***********      ");
            WriteLine("       **            **    ");
            WriteLine("     **                **  ");
            WriteLine("    *                    * ");
            WriteLine("     **                **  ");
            WriteLine("       **            **    ");
            WriteLine("          ***********      ");
            ResetColor();
        }
    }
}
