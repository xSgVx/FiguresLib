using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateFigureArea.Models
{
    public abstract class Figure
    {
        public abstract double FigureArea { get; }
        public abstract double FigurePerimeter { get; }
    }
}
