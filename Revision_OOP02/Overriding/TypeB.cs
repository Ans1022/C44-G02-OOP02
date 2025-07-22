using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision_OOP02.Overriding
{
    internal class TypeB : TypeA
    {
       // public int B { get; set; }
       //// Overside or Hide
       //// 1.Apply override using 'new' keyword
       //// 2.Apply override using 'override' keyword
       // public new void fun01() // Using new Keyword // Static Binding
       // {
       //     Console.WriteLine($"Fun01 from TypeB");
       // }

       // //must be not Private and Virtual
       // public override void fun02() // Using override Keyword //Dynamic Binding
       // {
       //     Console.WriteLine($"A: {A}, B: {B} ");
       // }
    }
}
