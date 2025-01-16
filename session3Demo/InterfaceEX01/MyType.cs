using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session3Demo.Interface
{
    internal class MyType : IMyType,IComparable,ICloneable /* Implemented*/
    {
        public double Salary { get; set; } //Automstic Property

        public object Clone()
        {
            throw new NotImplementedException();
        }

        public int CompareTo(object? obj)
        {
            throw new NotImplementedException();
        }

        public void MyFun()
        {
            Console.WriteLine("Hello world");
        }

        //public void MyInt() { Console.WriteLine()}


    }
}
