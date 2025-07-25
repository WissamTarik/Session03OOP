using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session03OOP.Interface_Ex03
{
    internal class Airplane : IMovable, IFlyable
    {
        int IMovable.Speed { get; set; }
        int IFlyable.Speed { get; set; }

        void IMovable.Backward()
        {
            Console.WriteLine("Airplane IMovable Backward");
        }

        void IFlyable.Backward()
        {
            Console.WriteLine("Airplane IFlyable Backward");
        }

        void IMovable.Forward()
        {
            Console.WriteLine("Airplane IMovable Forward");
        }

        void IFlyable.Forward()
        {
            Console.WriteLine("Airplane IFlyable Forward");
        }

        void IMovable.Left()
        {
            Console.WriteLine("Airplane IMovable Left");
        }

        void IFlyable.Left()
        {
            Console.WriteLine("Airplane IFlyable Left");
        }

        void IMovable.Right()
        {
            Console.WriteLine("Airplane IMovable Right");
        }

        void IFlyable.Right()
        {
            Console.WriteLine("Airplane IFlyable Right");
        }
    }
}
