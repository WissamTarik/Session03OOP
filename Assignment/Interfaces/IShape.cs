using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Interfaces
{
    internal interface IShape
    {
        public double Area { get; set; }
        void DisplayShapeInfo()
        {
            Console.WriteLine($"Area={Area}");
        }
    }
}
