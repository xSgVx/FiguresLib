using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateFigureArea.Models
{
    public class Circle : Figure
    {
        public double Radius => _radius;
        public override double FigureArea => double.Round( _figureArea, 1);
        public override double FigurePerimeter => double.Round(_figurePerimeter, 1);

        private double _radius;
        private double _figureArea;
        private double _figurePerimeter;

        public Circle(double radius) 
        { 
            this._radius = radius;
            this._figureArea = Math.PI * Math.Pow(radius, 2);
            this._figurePerimeter = 2 * Math.PI * radius;
        }
    }
}
