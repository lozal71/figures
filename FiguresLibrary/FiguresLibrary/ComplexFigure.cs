using System;
using static System.Math;
using System.Collections.Generic;
using System.Collections;

namespace FiguresLibrary
{
    public class ComplexFigure : Figure, IEnumerable
    {
        IPoligon[] poligonArr;

        public ComplexFigure(int n)
        {
            poligonArr = new IPoligon[n];
        }
        public override string NameFigure
        {
            get => "Составная";
        }

        public int Length
        {
            get
            {
                return poligonArr.Length;
            }
        }
        public IPoligon this[int index]
        {
            get
            {
                if (index >= 0 && index < poligonArr.Length)
                {
                    return poligonArr[index];
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            set
            {
                poligonArr[index] = value;
            }
        }
        public override double Area
        {
            get
            {
                double s = 0;
                for (int i = 0; i < poligonArr.Length; i++)
                {
                    s += poligonArr[i].Area;
                }
                return Round(s, 2);
            }
        }
        public override double Perimeter
        {
            get
            {
                double p = 0;
                for (int i = 0; i < poligonArr.Length; i++)
                {
                    p += poligonArr[i].Perimeter;
                }
                return Round(p, 2);
            }
        }

        public override void InputData()
        {
            throw new NotImplementedException();
        }

        public override void Draw(int posX, int posY, ConsoleColor consoleColor)
        {
            throw new NotImplementedException();
        }

        public IEnumerator GetEnumerator()
        {
            return poligonArr.GetEnumerator();
        }
    }
}
