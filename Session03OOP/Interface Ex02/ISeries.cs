using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session03OOP.Interface_Ex02
{
    internal interface ISeries
    {
        int Current { get; set; }//1.Signature of property
        void Next();

        public void Reset()
        {
            Current = 0;
        }//2.Signature of method[Return type-Name-Parameter]
    }
}
