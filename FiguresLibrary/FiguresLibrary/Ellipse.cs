using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;
using static System.Console;

namespace FiguresLibrary
{
    public class Ellipse : Figure
    {
        private double axisSmall;
        private double axisBig;

        public Ellipse()
        {
            axisSmall = 0;
            axisBig = 0;
            NameFigure = "Эллипс";
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

        public override double CalculateArea()
        {
            return Round(2 * axisSmall * AxisBig, 2);
        }

        public override double CalculatePerimeter()
        {
            double l = PI * AxisSmall * AxisBig;
            l += Pow(AxisBig - axisSmall, 2);
            l /= AxisSmall + AxisBig;
            return Round(4 * l, 2);
        }

        public override void InputData()
        {
            TwoAxis();
        }
    }
}
