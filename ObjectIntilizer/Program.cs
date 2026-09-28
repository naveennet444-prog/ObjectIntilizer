using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectIntilizer
{
    internal class Program
    {
        /* we can assign values to instance variables in 3ways 
          1) using object we can assign data to one by one variable.
          2) using parametrised constructer we can pass data to variables.
          3) we can assign data when creating object like
            <ClassName> <ObjectName> = new <ClassName> { VariableName1 = data1 , VariableName2 = data2, VariableName3 = data3,......}; */
           
        static void Main(string[] args)
        {
            MyClass Obj = new MyClass() { studentNumber = 490, studentName = "Naveen" }; //we can assign vales to all instance variables when object creation with out parameters.
            Console.WriteLine(Obj.studentNumber);
            Console.WriteLine(Obj.studentName);
            Console.ReadKey();
        }
    }
}
