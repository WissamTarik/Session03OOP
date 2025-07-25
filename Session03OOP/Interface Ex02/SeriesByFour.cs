using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session03OOP.Interface_Ex02
{
    internal class SeriesByFour : ISeries
    {
        public int Current { get; set; }

        public void Next()
        {
            Current += 4;
        }


    }
}
