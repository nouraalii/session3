using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session3Demo.InterfaceEx03
{
    internal class Plane : IMoveable, IFlyable
    {
        int IFlyable.Speed { get; set ; }
        int IMoveable.Speed { get ; set ; }

        void IFlyable.Backword()
        {
            Console.WriteLine("Car IFlyable Backword");
        }

        void IMoveable.Backword()
        {
            Console.WriteLine("Car IMoveable Backword");
        }

        void IFlyable.Forword()
        {
            Console.WriteLine("Car IFlyable Forward");
        }

        void IMoveable.Forword()
        {
            Console.WriteLine("Car IMoveable Forward");
        }

        void IFlyable.Left()
        {
            Console.WriteLine("Car IFlyable Left");
        }

        void IMoveable.Left()
        {
            Console.WriteLine("Car IMoveable Left");
        }

        void IFlyable.Right()
        {
            Console.WriteLine("Car IFlyable Right");
        }

        void IMoveable.Right()
        {
            Console.WriteLine("Car IMoveable Right");
        }
    }
}
