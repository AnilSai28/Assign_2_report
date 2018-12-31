using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test.count);
            Test.count = 100;
            Test t1 = new Test();

            Console.WriteLine(Test.count);

            Test t2 = new Test();
            Test.count = 200;

            Console.WriteLine(Test.count);
            /*Console.WriteLine("enter student id : ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter student name : ");
            string name =Console.ReadLine();

            Console.WriteLine("enter student marks : ");
            int marks = Convert.ToInt32(Console.ReadLine());

            Student obj = new Student(id, name, marks);

            Console.WriteLine(obj.pstudentid);
            Console.WriteLine(obj.pstudentname);
            Console.WriteLine(obj.pstudentmarks);

            //obj.pstudentid = 1001;//read only

            obj.pstudentmarks = 200;

            Console.WriteLine(obj.pstudentmarks);
            obj.pstudentmarks = 90;
            Console.WriteLine(obj.pstudentmarks);*/
            Console.ReadLine();










        }
    }
}
