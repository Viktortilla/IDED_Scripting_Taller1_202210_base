using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    internal class Sandbox
    {
        public static void Main(string[] args)
        {
            //prueba punto 1
            
            Stack<int> prueba1 = new Stack<int>();


            prueba1.Push(26);
            prueba1.Push(3);
            prueba1.Push(6);
            prueba1.Push(5);
            
            
            Stack<int> sln_p1 = TestMethods.GetNextGreaterValue(prueba1);


            Console.WriteLine("|");
            foreach (object obj in sln_p1)
            {
                Console.Write(obj + "|");
            }
            Console.WriteLine("");
            

            //prueva punto 2

            
        }
    }
}