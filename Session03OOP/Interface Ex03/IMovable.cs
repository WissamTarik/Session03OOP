using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session03OOP.Interface_Ex03
{
    internal interface IMovable
    {
        public int Speed { get; set; }
        void Forward();
        void Backward();
        void Left();
        void Right();
    }
}
