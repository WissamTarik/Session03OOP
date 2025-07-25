using Assignment.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Circle : IShape
    {
        public double Area { get; set; }
        public Circle(double radius )
        {
            this.Area = Math.PI*Math.Pow(radius,2);
            
        }
    }
}
