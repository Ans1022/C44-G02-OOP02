using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision_OOP02.Overriding
{
    internal class TypeA
    {
        public int A { get; set; }

        public void fun01()
        {
            Console.WriteLine($"Fun01 from Type01");
        }   
        public void fun02() 
        //public override void fun02()
        {
            Console.WriteLine($"A: {A} "); 
        }
    }
}
