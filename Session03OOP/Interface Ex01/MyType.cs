using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session03OOP.Interface_Ex01
{
    internal class MyType : IMyType, IComparable, ICloneable
    {
        public double Salary { get; set; }

        public object Clone()
        {
            throw new NotImplementedException();
        }

        public int CompareTo(object? obj)
        {
            throw new NotImplementedException();
        }

        public void Fun01()
        {
            Console.WriteLine("Hello world :)");
        }

    }
}
