using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace FiguresLibrary
{
    public class ComplexFigure : Figure
    {
        Figure[] figuresArr;

        public ComplexFigure(int n)
        {
            figuresArr = new Figure[n];
            NameFigure = "Составная";
        }

        public int Length
        {
            get
            {
                return figuresArr.Length;
            }
        }
        public Figure this [int index]
        {
            get
            {
                if (index >= 0 && index < figuresArr.Length)
                {
                    return figuresArr[index];
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            set
            {
                figuresArr[index] = value;
            }

        }
        public override double CalculateArea()
        {
            double s = 0;
            for (int i=0; i< figuresArr.Length; i++)
            {
                s += figuresArr[i].CalculateArea();
            }
            return Round(s,2);
        }

        public override double CalculatePerimeter()
        {
            double p = 0;
            for (int i = 0; i < figuresArr.Length; i++)
            {
                p += figuresArr[i].CalculatePerimeter();
            }
            return Round(p, 2);
        }


        public override void InputData()
        {
            throw new NotImplementedException();
        }
    }
}
