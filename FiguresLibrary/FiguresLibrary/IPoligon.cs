using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLibrary
{
    public interface IPoligon 
    {
        double Base { get; set; }
        double Side { get; set; }
        double SideA { get; set; }
        double SideB { get; set; }
        double SideC { get; set; }
        double BaseBig { get; set; }
        double BaseSmall { get; set; }
        double AngleBaseSide { get; set; }
        double AngleBaseBigSide { get; set; }
        double AngleBaseSmallSide { get; set; }
        double AxisSmall { get; set; }
        double AxisBig { get; set; }
        double Area { get; }
        double Perimeter { get; }
        string NameFigure { get; }
        void InputData();
        void Draw(int posX, int posY, ConsoleColor consoleColor);

    }
}
