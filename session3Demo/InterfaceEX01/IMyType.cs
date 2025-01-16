using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session3Demo.Interface
{
    internal interface IMyType
    {
        //What can write inside the interface
        //1.signature of method (nsme,return type , parameters)
        //2.signature of property
        //3.Default Implermented mathod(Fully implemented method)

        //1.signature of method (nsme,return type , parameters)
        void MyFun(); //signature of method

        //2.signature of property
        public double Salary { get; set; }


        void Print()
        {
            Console.WriteLine("Default Implermented mathod(Fully implemented method)");
        }
    }
}
