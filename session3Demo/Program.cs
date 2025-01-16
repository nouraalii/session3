using System.Text;
using session3Demo.Interface;
using session3Demo.InterfaceEX02;
using session3Demo.InterfaceEx03;

namespace session3Demo
{
    internal class Program
    {
        //static void Print10Number(SeriesByTwo series)
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.WriteLine($"{series.Current}");
        //        series.Next();
        //    }
        //    Console.WriteLine();
        //    series.Reset();
        //}

        //static void Print10Number(SeriesByThree series)
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.WriteLine($"{series.Current}");
        //        series.Next();
        //    }
        //    Console.WriteLine();
        //    series.Reset();
        //}

        static void Print10Number(ISeries series)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{series.Current}");
                series.Next();
            }
            Console.WriteLine();
            series.Reset();
        }
        static void Main(string[] args)
        {
            #region InterfaceEx01
            //interface : reference type
            //code contract between the developer who write and the developer who us It

            //IMyType mytype = new IMyType();//Invalid 
            //mytype.MyFunc();
            //Note:can't create any object from any interface

            //can create reference from interface and the refernce can refer to object
            //from class which implement the interface
            //IMyType myType;

            //MyType myType = new MyType();
            //myType.MyFun();
            //myType.Salary= 12000;
            //Console.WriteLine(myType.Salary);
            //myType.Print();

            //IMyType myType = new MyType();

            //myType.MyFun();
            //myType.Print(); 
            #endregion


            #region InterfaceEX02

            //SeriesByTwo seriesByTwo = new SeriesByTwo();
            //SeriesByThree seriesByThree = new SeriesByThree();

            //Print10Number(seriesByThree);


            //int[] Numbers = { 8, 7, 5, 4, 3, 2, 1, 9, 6 };

            //Array.Sort(Numbers);

            //foreach (int i in Numbers) 
            //{
            //    Console.WriteLine(i);
            //} 

            //Employee[] employees = new Employee[3]
            //{
            //    new Employee(){Id = 1 , Name = "Noura" , Age = 22 , Salary = 12000},
            //    new Employee(){Id = 2 , Name = "Ahmed" , Age = 30 , Salary = 20000},
            //    new Employee(){Id = 3 , Name = "Omar"  , Age = 28 , Salary = 15000}
            //};

            //Array.Sort(employees);

            //foreach (Employee i in employees)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region InterfaceEX03
            // Car car = new Car();
            //car.Speed = 100;
            //car.Forword();

            //Plane plane = new Plane();
            //IMoveable moveable = plane;
            //moveable.Forword();

            //IFlyable flyable = plane;
            //flyable.Forword(); 
            #endregion

            #region Shallow copy Vs Deep copy
            //Shallow Copy Vs Deep Copy

            //Shallow Copy

            //int[] Arr1 = { 1, 2, 3 };
            //int[] Arr2 = { 4, 5, 6 };

            //string[] Arr1 = { "Ahmed", "Ali", "Omar" };
            //string[] Arr2 = { "Ziad", "Adel", "Amr" }; 

            //StringBuilder[] Arr1 = new StringBuilder[]{
            //    new StringBuilder("Ahmed"),
            //    new StringBuilder("Omar"),
            //    new StringBuilder("Ali")
            //};

            //StringBuilder[] Arr2 = new StringBuilder[]{
            //    new StringBuilder("Amr"),
            //    new StringBuilder("Adel"),
            //    new StringBuilder("Ziad")
            //};

            //Console.WriteLine($"Arr1:{Arr1.GetHashCode}");
            //Console.WriteLine($"Arr2:{Arr2.GetHashCode}");

            //Arr2 = Arr1; //Shallow Copy
            ////Copy Identity
            ////{ 1, 2, 3}--> has two refrencnes Arr1, Arr2
            ////{ 4, 5, 6 } --> Unrechable object 

            //Console.WriteLine($"Arr1:{Arr1.GetHashCode}");
            //Console.WriteLine($"Arr2:{Arr2.GetHashCode}");

            ////Identity(Address) + Object State[Data]

            //Arr1[0].Append("Ahmed Amin");

            ////Arr2[0] = "Mahmoud";
            //Console.WriteLine(Arr1[0]);


            //int[] Arr1 = { 1, 2, 3 };
            //int[] Arr2 = { 4, 5, 6 };

            //Console.WriteLine($"Arr1:{Arr1.GetHashCode}");
            //Console.WriteLine($"Arr2:{Arr2.GetHashCode}");

            //Arr2 = (int[])Arr1.Clone(); //Deep Copy
            ////clone method will copy the obejct state of the caller  
            ////Assign the new object to Arr2

            //Console.WriteLine($"Arr1:{Arr1.GetHashCode}");
            //Console.WriteLine($"Arr2:{Arr2.GetHashCode}");

            ////Identity(Address) + Object State[Data]

            //Arr2[0] = 100;
            //Console.WriteLine(Arr1[0]);

            #endregion


            #region Built-In Interface ICloneable
            //Employee E01 = new Employee() {Id=1, Name ="Ahmed" , Age=25 , Salary=12000 };
            //Employee E02 = new Employee() {Id=2, Name ="Omar" , Age=29 , Salary=15000 };

            ////E02 = E01; //Shallow Copy

            //E02 =(Employee)E01.Clone();

            //E01.Salary = 5;

            //Console.WriteLine(E01.GetHashCode);
            //Console.WriteLine(E02.GetHashCode);

            //Console.WriteLine(E01);
            //Console.WriteLine(E02); 
            #endregion


            #region Built-In Interface IComperable
            //Employee[] employees = new Employee[3]
            //{
            //    new Employee(){Id = 1 , Name = "Noura" , Age = 22 , Salary = 12000},
            //    new Employee(){Id = 2 , Name = "Ahmed" , Age = 30 , Salary = 20000},
            //    new Employee(){Id = 3 , Name = "Omar"  , Age = 28 , Salary = 15000}
            //};

            //Array.Sort(employees);

            //int X = employees[0].CompareTo(employees[1]);
            ////+ve: Caller is Greater than the Parameter
            ////-ve: Caller is less than the Parameter
            ////0  : Caller Equal Parameter


            //foreach (Employee i in employees)
            //{
            //    Console.WriteLine(i);
            //} 
            #endregion

            #region Built-In Interface IComparer
            //Employee[] employees = new Employee[3]
            //{
            //    new Employee(){Id = 1 , Name = "Noura" , Age = 22 , Salary = 12000},
            //    new Employee(){Id = 2 , Name = "Ahmed" , Age = 30 , Salary = 20000},
            //    new Employee(){Id = 3 , Name = "Omar"  , Age = 28 , Salary = 15000}
            //};

            //Array.Sort(employees, new EmployeeCompareSalay());

            //foreach (Employee i in employees)
            //{
            //    Console.WriteLine(i);
            //} 
            #endregion



        }
    }
}
