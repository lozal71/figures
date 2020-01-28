/* Разработать абстрактный класс «Геометрическая Фигура» с методами «Площадь Фигуры» и «Периметр Фигуры».
    Разработать классы-наследники: Треугольник, Квадрат, Ромб, Прямоугольник, Параллелограмм, 
    Трапеция, Круг,Эллипс.
    Реализовать конструкторы, которые однозначно определяют объекты данных классов.
    Реализовать класс «Составная Фигура», 
    который может состоять из любого количества «Геометрических Фигур». 
    Для данного класса определить метод нахождения площади фигуры.
    Создать диаграмму взаимоотношений классов.*/

using System;
using static System.Console;
using static System.Convert;

namespace FiguresLibrary

{

    public enum TypeFigures
    {
        Undefined, Triangle, Rhomb, Quadrate, Parallelogram, Rectangle, 
        Trapezium, Ellipse, Circle
    }
    public enum CalculationTarget
    {
        Undefined, Area, Perimeter
    }

    public abstract class Figure
    {
        public const string EX_SIDE = "Эта величина не может быть " +
                                            "нулевым или отрицательным значением";
        public const string EX_SHARP_ANGLE = "Величина острого угла в градусах должна " +
                                                   "быть в пределах от 0 до 90";
        public const string EX_OBTUSE_ANGLE = "Величина тупого угла в градусах должна " +
                                                    "быть в пределах от 90 до 180";
        public const string EX_TRIANGLE_NOT_EXIST = "Такой треугольник не существует. " +
                                                    "Сумма любых двух сторон должна быть " +
                                                    "больше третьей";
        public const string EX_TRAPEZIUM_NOT_EXIST = "Такая трапеция не существует. " +
                                                     "Сумма углов трапеции, прилежащих " +
                                                     "к боковой стороне " +
                                                     " должна быть равна 180 градусам";
        public const string EX_ELLIPS = "Данные некорректны. Длина меньшей оси " +
                                        "больше длины большей оси";
        public const string TRY_AGAIN = "Попробуйте еще раз....";
        private string nameFigure;
        protected Figure()
        {
            nameFigure = "не определено";
        }
        public string NameFigure { get => nameFigure; set => nameFigure = value; }
        protected double CorrectInput(string inputMess, string exMess = EX_SIDE)
        {
            bool sucssesInput = false;
            double param = 0;
            do
            {
                try
                {
                    Write(inputMess);
                    param = ToDouble(ReadLine());
                    if (exMess == EX_SIDE)
                    {
                        if (param <= 0)
                        {
                            throw new MyException(exMess);
                        }
                    }
                    else if (exMess == EX_SHARP_ANGLE)
                    {
                        if (param <= 0 || param >= 90)
                        {
                            throw new MyException(exMess);
                        }
                    }
                    else
                    {
                        if (param <= 90 || param >= 180)
                        {
                            throw new MyException(exMess);
                        }
                    }
                    sucssesInput = true;
                }
                catch (Exception ex)
                {
                    WriteLine(ex.Message);
                }
            } while (!sucssesInput);
            return param;
        }
        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();
        public abstract void InputData();
        public override string ToString()
        {
           return $" Фигура: {NameFigure}. " +
                  $"Площадь: {Convert.ToString(CalculateArea())}\n" +
                  $" Фигура: {NameFigure}. " +
                  $"Периметр:{Convert.ToString(CalculatePerimeter())}\n";
        }
    }
}
