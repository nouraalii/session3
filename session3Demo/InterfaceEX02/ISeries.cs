using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session3Demo.InterfaceEX02
{
    //0 2 4 6 8 10 12 14
    //0 3 6 9 12 15
    //0 4 8 12 16
    
    internal interface ISeries
    {
        int Current { get; set; }//Signature of property

        void Next();

        public void Reset()
        {
            Current = 0;
        }
    }
}
