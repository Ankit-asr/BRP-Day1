using System;
using System.Collections.Generic;
using System.Text;

namespace InheritancePractice
{
    class Class2 : Class1
    {
        public Class2() : base(20)
        {
            Console.WriteLine("Class 2 Constructor");
        }
        public void Test3()
        {
            Console.WriteLine("Method3");
        }
        static void Main()
        {
            //{
            //    Class1 p; //p variable of Clas1
            //    Class2 c = new Class2(); // c instance of Class2
            //    p = c; //p is reference of Class1
            //    p.Test1();
            //    p.Test2();

            Class2 c = new Class2();
            c.Test1();
            c.Test2();
            c.Test3();
            //Class1 p = new Class1();
            //p.Test1();
            //p.Test2();
            //p.Test3();
        }
    }
}
