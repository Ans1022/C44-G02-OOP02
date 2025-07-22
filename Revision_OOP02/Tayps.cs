using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision_OOP02
{
    class TaypA
    {
        public int A { get; set; }

        public void Fun01 () 
        {
            Console.WriteLine("Fun01 From TypeA");
        }  
        public virtual void Fun02 () 
        {
            Console.WriteLine($"A : {A} , B : {B}");
        }
    }


    class TaypB : TaypA
    {
        public int B { get; set; }

        public new void Fun01()
        {
            Console.WriteLine("Fun01 From TypeB");
        }
        public override void Fun02()
        {
            Console.WriteLine($"A : {A} ,  B: {B}");
        }
    }

    class TaypC : TaypB
    {
        public int C { get; set; }

        public new void Fun01()
        {
            Console.WriteLine("Fun01 From TypeC");
        }
        public override void Fun02()
        {
            Console.WriteLine($"A : {A} ,  B: {B} ,  C : {C}");
        }
    }

    class TaypD : TaypC
    {
        public int D { get; set; }

        public new void Fun01()
        {
            Console.WriteLine("Fun01 From TypeD");
        }
        public override void Fun02()
        {
            Console.WriteLine($"A : {A} ,  B: {B} ,  C : {C} , D : {D}");
        }
    }

}
