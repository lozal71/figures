using System;
using static System.Console;

namespace FiguresLibrary
{
    public class Quadrate :Parallelogram
    {
        public override string NameFigure
        {
            get => "Квадрат";
        }

        void OneSide()
        {
            SideA = CorrectInput("Введите длину стороны A: ");
            SideB = SideA;
            AngleBaseSide = 90;
        }

        public override void InputData()
        {
            OneSide();
        }

        public override void Draw(int posX, int posY, ConsoleColor consoleColor)
        {
            ForegroundColor = consoleColor;
            SetCursorPosition(posX, posY);
            WriteLine("┌─────────────┐");
            WriteLine("│             │");
            WriteLine("│             │");
            WriteLine("│             │");
            WriteLine("│             │");
            WriteLine("│             │");
            WriteLine("└─────────────┘");
            ResetColor();
        }
    }
}
