using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session3Demo.InterfaceEx03
{
    internal interface IMoveable
    {
        int Speed { get; set; }

        void Backword();

        void Forword();

        void Left();

        void Right();
    }
}
