using System;
using static System.Console;
using static System.Math;

namespace FiguresLibrary
{
    public class Triangle : Figure, IPoligon
    {
        private double sideA;
        private double sideB;
        private double sideC;
        public Triangle()
        {
            sideA = 0;
            sideB = 0;
            sideC = 0;
        }
        public override string NameFigure
        {
            get => "Треугольник";
        }
        public override double Area
        {
            get
            {
                double p = 0.5 * (SideA + SideB + SideC);
                double s = p * (p - sideA) * (p - sideB) * (p - SideC);
                return Round(Sqrt(s), 2);
            }
        }
        public override double Perimeter
        {
            get
            {
                return Round(SideA + SideB + SideC, 2);
            }
        }
        protected void ThreeSide()
        {
            bool exist = false;
            do
            {
                try
                {
                    SideA = CorrectInput("Введите длину стороны A: ");
                    SideB = CorrectInput("Введите длину стороны B: ");
                    SideC = CorrectInput("Введите длину стороны C: ");
                    if (SideA + SideB > SideC && SideA + SideC > SideB && SideB + SideC > sideA)
                    {
                        exist = true;
                    }
                    else
                    {
                        throw new MyException(EX_TRIANGLE_NOT_EXIST);
                    }
                }
                catch (Exception ex)
                {
                    WriteLine(ex.Message);
                    WriteLine(TRY_AGAIN);
                }
            } while (!exist);
        }
        public double SideC { get => sideC; set => sideC = value; }
        public double SideA { get => sideA; set => sideA = value; }
        public double SideB { get => sideB; set => sideB = value; }
        public double Base 
        { 
            get => sideA;
            set => sideA = value;
        }
        public double Side 
        { 
            get => sideB;
            set => sideB = value;
        }
        public double AngleBaseSide { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double BaseBig { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double BaseSmall { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double AngleBaseBigSide { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double AngleBaseSmallSide { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double AxisSmall { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double AxisBig { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void InputData()
        {
            ThreeSide();
        }
        public override void Draw(int posX, int posY, ConsoleColor consoleColor)
        {
            ForegroundColor = consoleColor;
            SetCursorPosition(posX, posY);
            WriteLine("       /\\    ");
            WriteLine("      /  \\    ");
            WriteLine("     /    \\    ");
            WriteLine("    /      \\   ");
            WriteLine("   /        \\  ");
            WriteLine("  /          \\ ");
            WriteLine(" ──────────────  ");
            ResetColor();
        }
    }
}
