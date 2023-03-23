using CalculateFigureArea.Interfaces;
using CalculateFigureArea.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateFigureArea.Models
{
    public class Triangle : Figure
    {
        public override double FigureArea => double.Round(_figureArea, 1);
        public override double FigurePerimeter => double.Round(_figurePerimeter, 1);
        public bool IsRight => _isRight;

        private readonly double[] _sides = null!;
        private readonly IPoint[] _points = null!;
        private readonly double _figureArea;
        private readonly double _figurePerimeter;
        private readonly bool _isRight;

        public Triangle(double l1, double l2, double l3)
        {
            this._sides = new[] { l1, l2, l3 };

            this._figurePerimeter = GetPerimeter(l1, l2, l3);
            this._figureArea = GetArea(l1, l2, l3);
            this._isRight = IsTriangleRight(_sides);
        }
        
        public Triangle(IPoint firstPoint, IPoint secondPoint, IPoint thirdPoint)
        {
            this._points = new[] { firstPoint, secondPoint, thirdPoint };
            this._sides = PointsHelper.GetSidesFromPoints(_points).ToArray();

            this._figurePerimeter = GetPerimeter(_sides[0], _sides[1], _sides[2]);
            this._figureArea = GetArea(_sides[0], _sides[1], _sides[2]);
            this._isRight = IsTriangleRight(_sides);
        }

        private double GetPerimeter(double l1, double l2, double l3)
        {            
            return l1 + l2 + l3;
        }

        private double GetArea(double l1, double l2, double l3)
        {
            // формула герона A = √p * (p-l1) * (p-l2) * (p-l3), где p-полупериметр
            var halfPerimeter = GetPerimeter(l1, l2, l3) / 2;
            var area = Math.Abs(halfPerimeter * (halfPerimeter - l1) * (halfPerimeter - l2) * (halfPerimeter - l3));

            return area;
        }

        private bool IsTriangleRight(IEnumerable<double> sides)
        {
            bool isRight = false;
            double[] mas = sides.ToArray();
            Array.Sort(mas);

            //a^2 + b^2 = c^2
            if (Math.Pow(mas[0], 2) + Math.Pow(mas[1], 2) == Math.Pow(mas[2], 2))
            {
                isRight = true;
            }

            return isRight;
        }

    }
}
