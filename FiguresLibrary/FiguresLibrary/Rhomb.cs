using System;
using static System.Console;

namespace FiguresLibrary
{
    public class Rhomb : Parallelogram
    {
        public override string NameFigure
        {
            get => "Ромб";
        }

        void OneSideAngle()
        {
            SideA = CorrectInput("Введите длину стороны: ");
            SideB = SideA;
            AngleBaseSide = CorrectInput("Введите величину острого угла " +
                                 "между сторонами (в градусах): ", EX_SHARP_ANGLE);
        }
        public override void InputData()
        {
            OneSideAngle();
        }
        public override void Draw(int posX, int posY, ConsoleColor consoleColor)
        {
            ForegroundColor = consoleColor;
            SetCursorPosition(posX, posY);
            WriteLine("      ────────────");
            WriteLine("     /           / ");
            WriteLine("    /           /  ");
            WriteLine("   /           /   ");
            WriteLine("  /           /    ");
            WriteLine(" ─────────────     ");
            ResetColor();
        }
    }
}
