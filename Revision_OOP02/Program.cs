using Revision_OOP02.Binding;
using Revision_OOP02.Inheritnace;
using Revision_OOP02.Overriding;

namespace Revision_OOP02
{
    internal class Program
    {
        //static void EmployeeProcess(FulltimeEmployee employee)
        //{
        //    if (employee is not null)
        //    {
        //        employee.fun01();
        //        employee.fun02();
        //    }
        //}

        //static void EmployeeProcess(PartTimeEmployee employee)

        //{
        //    {
        //        if (employee is not null)
        //        {
        //            employee.fun01();
        //            employee.fun02();
        //        }
        //}



        //static int Sum(int X , int Y )
        //{
        //    return X + Y;
        //}    
        //static double Sum(double X , double Y )
        //{
        //    return X + Y;
        //}

        //static void EmployeeProcess(Employee employee)
        //{
        //    if (employee is not null)
        //    {
        //        employee.fun01();
        //        employee.fun02();
        //    }

        //}
        static void Main(string[] args)
        {
            #region Class & Struct :

            #endregion

            #region inheritance :

            //Parent p01 = new Parent(1,2);
            //Console.WriteLine(p01);

            //p01.Fun01();    
            //p01.Fun02();

            //Child child = new Child (1,2,3);

            //child.Fun01();
            //child.Fun02();

            #endregion

            #region polymorphic :
            // 1.Method Overloading
            // there are more Then one Function (in the same Scope [Class , Sturct] )these have the same Name but With Different signature
            // // Different signature (Count , order , Type) Parometers
            //Sum (1, 2);
            //Sum (1, 2);

            //Sum(1.5 ,1.7);



            // 2.Method Overriding
            // there are more Then one Function (in Different Class ) these have the same name and
            //the same signature but With Behaviour

            //TypeB tyB = new TypeB();// {A = 20 , B = 14 };

            //tyB.A = 10;
            //tyB.B = 16;

            //Console.WriteLine(tyB.A);
            //Console.WriteLine(tyB.B);

            //tyB.fun01();
            //tyB.fun02();
            #endregion

            #region Binding
            // What is Binding 
            // Binding From Parent ==> object from Child

            //TypeA refebase = new TypeB();
            //refebase.A = 1;
            ////refebase.B = 2; // inviald

            ////refebase.fun01();// Fun01 from Type01
            /////Static Binding [Early Binding]
            ///// Compiler will Bind Function Call Based on referance not Object 
            ///// At Compilation time 
            ///// 

            //refebase .fun02(); // TypeB A.1
            /////Dynamic Binding [Late Binding] 
            /////ClR Will Bind Function Call Based on object not referance
            ///// At runTime


            #region Not Binding  
            //TypeA typeA;

            //typeA = new TypeA(1);
            //typeA = new TypeB(1,2);

            //TypeB typeB = (TypeB)TypeA;

            //Console.WriteLine(typeA.B);
            //Console.WriteLine(typeB.B);

            #endregion

            #region When you need Binding
            // FullTimeEmployee : ID , Name , Salary , Adderss , Email 
            //FulltimeEmployee fulltime = new FulltimeEmployee()
            //{
            //    Id = 1,
            //    Name = "Anas",
            //    Email = "anas@mohamed",
            //    Address = "Banha",
            //    Salary = 5000

            //};

            // patTimeEmployee : ID , Name ,Adderss , Email ,numberOfHourse , HourRate

            //PartTimeEmployee partTime = new PartTimeEmployee()
            //{
            //    Id = 1,
            //    Name = "Ali",
            //    Email = "Ali@email",
            //    Address = "Cairo",
            //    HourRate = 10,
            //    NumberOfhoure = 2000

            //};
            //EmployeeProcess(partTime);
            #endregion

            #region Binding Example
            //TypeA typea;

            //typea = new TypeA();
            //typea = new TypeB();
            //typea = new TaypC();
            //typea = new TaypD();

            //typea.A = 12;
            ////typea.B = 12;
            ////typea.C = 12;
            ////typea.D = 12;

            //typea.fun01();
            //typea.fun02();





            #endregion

            #endregion

            #region Task
            //1.private : Only accessible within the same class
            //Hide internal details

            //class Private
            //{
            //private int number = 5;

            //       void ShowNumber()
            //       {
            //         Console.WriteLine(number);
            //       }
            //}

            ///////////////////////////////////////////////////////////////////////////

            //2.private protected :Available only within the same class or in a class derived from it within the same assembly
            //Extra protection when inheriting within the same project

            //class Base
            //{
            //private protected int data = 10;
            //}

            // class Derived : Base
            // {
            //   void Display()
            //   {
            //         Console.WriteLine(data); 
            //   }
            // }

            ////////////////////////////////////////////////////////////////////////////

            //3.protected :It can only be accessed from the same class or a derived class, even from another project
            //Allows inheritance access with protection from external code.
            //class Parent
            //{
            //  protected string message = "Hello";
            //}

            // class Child : Parent
            // {
            //   void Print()
            //   {
            //     Console.WriteLine(message);
            //   }

            // }

            //////////////////////////////////////////////////////

            //4.internal : 
            //Only available within the same assembly (same project)
            //Share code within the project only

            //internal class Helper
            //{
            //    internal void SayHi()
            //    {
            //      Console.WriteLine("Hi");
            //    }
            //}

            //////////////////////////////////////////////////////

            //5.protected internal:Available within the same project or in a derived class even if outside the project
            //Flexibility in access between inheritance and the project itself

            //class Base
            //{
            //   protected internal int value = 100;
            //}

            //class Sub : Base
            //{
            //    void Show()
            //    {
            //      Console.WriteLine(value);   
            //    }
            //}

            ///////////////////////////////////////////////////////////////////
            //6.public : Available to everyone from anywhere.
            //Share the code with everyone

            //public class Math
            //{
            //     public int Add(int a, int b)
            //     {
            //      return a + b;
            //     }
            //}
            #endregion

        }
    }         
    
}
    


    


        
    

    



        
    

