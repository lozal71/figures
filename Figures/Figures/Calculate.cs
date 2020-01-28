/* Разработать абстрактный класс «Геометрическая Фигура» с методами «Площадь Фигуры» и «Периметр Фигуры».
    Разработать классы-наследники: Треугольник, Квадрат,Ромб, Прямоугольник, Параллелограмм, 
    Трапеция, Круг, Эллипс.
    Реализовать конструкторы, которые однозначно определяют объекты данных классов.
    Реализовать класс «Составная Фигура», 
    который может состоять из любого количества «Геометрических Фигур». 
    Для данного класса определить метод нахождения площади фигуры.
    Создать диаграмму взаимоотношений классов.*/

using System;
using static System.Console;
using static System.Convert;
using FiguresLibrary;

namespace Figures
{
    class Calculate
    {
        const int N = 10;
        const string EX_N = "число фигур должно быть не меньше 0 и не больше {0}";
        static int CorrectInput(string inputMess, string exMess = EX_N)
        {
            bool sucssesInput = false;
            int param = 0;
            do
            {
                try
                {
                    Write(inputMess, N);
                    param = ToInt32(ReadLine());
                    if (param <=0 || param > N)
                    {
                        throw new MyException(exMess);
                    }
                    sucssesInput = true;
                }
                catch (Exception ex)
                {
                    WriteLine(ex.Message, N.ToString());
                    WriteLine("Попробуйте еще раз....");
                }
            } while (!sucssesInput);
            return param;
        }
        static void SetMenuFigures(ref Menu menuF)
        {
            menuF[0] = new MenuOption("Отказ от расчета и выход  - 0 -->");
            menuF[1] = new MenuOption("              Треугольник - 1");
            menuF[2] = new MenuOption("                     Ромб - 2");
            menuF[3] = new MenuOption("                  Квадрат - 3");
            menuF[4] = new MenuOption("            Параллелограм - 4");
            menuF[5] = new MenuOption("            Прямоугольник - 5");
            menuF[6] = new MenuOption("                 Трапеция - 6");
            menuF[7] = new MenuOption("                   Эллипс - 7");
            menuF[8] = new MenuOption("                     Круг - 8");
        }
        static void SetMenuCalcTarget(ref Menu menuT)
        {
            menuT[0] = new MenuOption(" Отказ от вычислений - 0 -->");
            menuT[1] = new MenuOption("             Площадь - 1");
            menuT[2] = new MenuOption("            Периметр - 2");
        }
        static void SetMenuNewCalc(ref Menu menuN)
        {
            menuN[0] = new MenuOption(" Выход из программы - 0 -->");
            menuN[1] = new MenuOption("       Новый расчет - 1");
        }

        static void Main(string[] args)
        {
            Menu menuFigures = new Menu(9);
            Menu menuCalcTarget = new Menu(3);
            Menu menuNewCalc = new Menu(2);
            SetMenuFigures(ref menuFigures);
            SetMenuCalcTarget(ref menuCalcTarget);
            SetMenuNewCalc(ref menuNewCalc);
            do
            {
                int n;
                n = CorrectInput("Введите количество фигур (не больше {0}): --->");
                ComplexFigure figure = new ComplexFigure(n);
                for (int i = 0; i < n; i++)
                {
                    TypeFigures typeFigures = 
                        (TypeFigures)menuFigures.SelectOption("Выбор {0}-ой фигуры:", i);
                    switch (typeFigures)
                    {
                        case TypeFigures.Triangle:
                            figure[i] = new Triangle();
                            break;
                        case TypeFigures.Rhomb:
                            figure[i] = new Rhomb();
                            break;
                        case TypeFigures.Quadrate:
                            figure[i] = new Quadrate();
                            break;
                        case TypeFigures.Parallelogram:
                            figure[i] = new Parallelogram();
                            break;
                        case TypeFigures.Rectangle:
                            figure[i] = new Rectangle();
                            break;
                        case TypeFigures.Trapezium:
                            figure[i] = new Trapezium();
                            break;
                        case TypeFigures.Ellipse:
                            figure[i] = new Ellipse();
                            break;
                        case TypeFigures.Circle:
                            figure[i] = new Circle();
                            break;
                        default:
                            figure[i] = new Parallelogram();
                        break;
                    }
                    WriteLine("************ Выбрана фигура: {0}. ", figure[i].NameFigure);
                    figure[i].InputData();
                    WriteLine(figure[i]);
                }
                if (n != 1)
                {
                    WriteLine("************ Составная фигура включает в себя : ");
                    for (int i = 0; i < n; i++)
                    {
                        WriteLine(figure[i]);
                    }
                    WriteLine("************ Площадь и периметр составной фигуры: ");
                    WriteLine(figure);
                }
                figure = null;
            } while (menuNewCalc.SelectOption("Выбор дальнейшего действия:") == 1);
        }
    }
}
