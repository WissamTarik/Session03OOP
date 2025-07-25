using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session03OOP.Interface_Ex01
{
    internal interface IMyType
    {
        //Default access modifer for interface is public
        //What we can write inside the interface?
        /*
         1.Signature of properties
         2.Signature of methods[Name-Parameters-Return Type]
         3.Default implemented methods[Fully implemented method]
         */

        //1.Signature of properties
        double Salary { get; set; }

        //2.Signature of method
        void Fun01();

        //3.Default implemented methods[Fully implemented method]
        //We can use private access modifer with only default implemented method

        void Print()
        {
            Console.WriteLine("Default implemented methods[Fully implemented method]");
        }

    }
}
