using System;
using static System.Console;
using static System.Math;

namespace FiguresLibrary
{
    public class Parallelogram : Figure, IPoligon
    {
        private double sideA;
        private double sideB;
        private double angle;
        public Parallelogram()
        {
            sideA = 0;
            sideB = 0;
            angle = 0;
        }

        public override double Area
        {
            get { return Round(SideA * SideB * Sin(AngleBaseSide), 2); }
        }
        public override double Perimeter
        {
            get { return Round(2 * SideA + 2 * SideB, 2); }
        }

        public override string NameFigure
        {
            get => "Параллелограмм";
        }
        public double Base { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double Side { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double SideA { get => sideA; set => sideA = value; }
        public double SideB { get => sideB; set => sideB = value; }
        public double SideC { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double BaseBig { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double BaseSmall { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double AngleBaseSide { get => angle; set => angle = Round((value * PI) / 180, 2); }
        public double AngleBaseBigSide { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double AngleBaseSmallSide { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double AxisSmall { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double AxisBig { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        protected void TwoSideAngle()
        {
            SideA = CorrectInput("Введите длину стороны A: ");
            SideB = CorrectInput("Введите длину смежной стороны B: ");
            AngleBaseSide = CorrectInput("Введите величину острого угла " +
                                 "между сторонами A и B (в градусах): ", EX_SHARP_ANGLE);
        }
        public override void InputData()
        {
            TwoSideAngle();
        }

        public override void Draw(int posX, int posY, ConsoleColor consoleColor)
        {
            ForegroundColor = consoleColor;
            SetCursorPosition(posX, posY);
            WriteLine("      ───────────────────────");
            WriteLine("     /                     / ");
            WriteLine("    /                     /  ");
            WriteLine("   /                     /   ");
            WriteLine("  /                     /    ");
            WriteLine(" ───────────────────────     ");
            ResetColor();
        }
    }
}
