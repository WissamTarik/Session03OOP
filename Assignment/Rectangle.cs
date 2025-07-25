using Assignment.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Rectangle: IShape
    {
        public double Area { get; set; }
        public Rectangle(double width,double height)
        {
            Area = width * height;
        }

       
    }
}
