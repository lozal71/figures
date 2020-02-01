using System;
using static System.Console;

namespace FiguresLibrary
{
    public class Circle : Ellipse
    {

        public override string NameFigure
        {
            get => "Круг";
        }
        void OneAxis()
        {
            AxisSmall = CorrectInput("Введите радиус: ");
            AxisBig = AxisSmall;
        }

        public override void InputData()
        {
            OneAxis();
        }
        public override void Draw(int posX, int posY, ConsoleColor consoleColor)
        {
            ForegroundColor = consoleColor;
            SetCursorPosition(posX, posY);
            WriteLine("          ***        ");
            WriteLine("       **     **     ");
            WriteLine("     **         **  ");
            WriteLine("    *             * ");
            WriteLine("     **         **  ");
            WriteLine("       **     **     ");
            WriteLine("          ***        ");
            ResetColor();
        }
    }
}
