using CalculateFigureArea.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateFigureArea.Utility
{
    public class FigureAnalizer
    {
        public FigureAnalizer() { }

        public double GetFigurePerimeter(Figure figure)
        {
            return figure.FigurePerimeter;
        }

        public double GetFigureArea(Figure figure)
        {
            return figure.FigureArea;
        }

        public dynamic FigureType(Figure figure) 
        {
            if (figure is Triangle)
            {
                if ((figure as Triangle)!.IsRight)
                {
                    return "Прямоугольный треугольник";
                }

                return "Треугольник";
            }

            if (figure is Circle)
                return "Круг";

            return "unknown type";
        }

        public bool EqualFigures(Figure firstFigure, Figure secondFigure)
        {
            return FigureType(firstFigure) == FigureType(secondFigure);
        }
    }
}
