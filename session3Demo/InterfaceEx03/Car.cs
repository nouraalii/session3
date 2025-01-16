using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session3Demo.InterfaceEx03
{
    internal class Car : IMoveable
    {
        public int Speed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Backword()
        {
            Console.WriteLine("Car IMoveable Backword");
        }

        public void Forword()
        {
            Console.WriteLine("Car IMoveable Forward");
        }

        public void Left()
        {
            Console.WriteLine("Car IMoveable Left");
        }

        public void Right()
        {
            Console.WriteLine("Car IMoveable Right");
        }
    }
}
