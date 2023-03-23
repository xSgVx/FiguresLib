using CalculateFigureArea.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateFigureArea.Utility
{
    internal static class PointsHelper
    {
        internal static double GetDistanceFromPoints(IPoint firstPoint, IPoint secondPoint)
        {
            //d = √(xb - xa)2 + (yb - ya)2
            return Math.Sqrt(Math.Pow(firstPoint.X - secondPoint.X, 2) +
                             Math.Pow(firstPoint.Y - secondPoint.Y, 2));
        }

        internal static IEnumerable<double> GetSidesFromPoints(IEnumerable<IPoint> points) 
        {
            IPoint[] pointsArr = points.ToArray();
            var sides = new List<double>();

            for (int i = 0; i < pointsArr.Length; i++)
            {
                if (i == pointsArr.Length - 1)
                {
                    sides.Add(GetDistanceFromPoints(pointsArr[i], pointsArr[0]));
                }
                else
                {
                    sides.Add(GetDistanceFromPoints(pointsArr[i], pointsArr[i + 1]));
                }
            }

            return sides;
        }
    }
}
