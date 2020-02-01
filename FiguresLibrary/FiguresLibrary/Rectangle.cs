using System;
using static System.Console;

namespace FiguresLibrary
{
    public class Rectangle : Parallelogram
    {
        public override string NameFigure
        {
            get => "Прямоугольник";
        }

        void TwoSide()
        {
            SideA = CorrectInput("Введите длину стороны A: ");
            SideB = CorrectInput("Введите длину стороны B: ");
            AngleBaseSide = 90;
        }

        public override void InputData()
        {
            TwoSide();
        }
        public override void Draw(int posX, int posY, ConsoleColor consoleColor)
        {
            ForegroundColor = consoleColor;
            SetCursorPosition(posX, posY);
            WriteLine("┌───────────────────────┐");
            WriteLine("│                       │");
            WriteLine("│                       │");
            WriteLine("│                       │");
            WriteLine("└───────────────────────┘");
            ResetColor();

            //int posX1 = 10;
            //int posY1 = 5;
            //int posY2 = (int)figure[i].SideA;
            //int posX2 = (int)figure[i].SideB;
            //ForegroundColor = ConsoleColor.Blue;
            //SetCursorPosition(posX1, posY1);
            //Write("╔");
            //for (int x = posX1; x < posX1 + posX2; x++)
            //{
            //    Write("═");
            //}
            //WriteLine("╗");

            //for (int y = posY1 + 1; y < posY1 + posY2 - 1; y++)
            //{
            //    SetCursorPosition(posX1, y);
            //    Write("║");
            //    for (int x = posX1; x < posX1 + posX2; x++)
            //    {
            //        Write(" ");
            //    }
            //    WriteLine("║");
            //}

            //SetCursorPosition(posX1, posY1 + posY2-1);
            //Write("╚");
            //for (int x = posX1; x < posX1 + posX2; x++)
            //{
            //    Write("═");
            //}
            //WriteLine("╝");
        }

    }
}
