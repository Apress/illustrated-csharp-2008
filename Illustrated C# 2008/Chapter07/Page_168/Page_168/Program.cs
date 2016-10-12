using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Page_168
{
   class MyBaseClass                                     // Base class
   {
      virtual public void Print()
      {
         Console.WriteLine( "This is the base class." );
      }
   }

   class MyDerivedClass : MyBaseClass                    // Derived class
   {
      override public void Print()
      {
         Console.WriteLine( "This is the derived class." );
      }
   }

   class SecondDerived : MyDerivedClass
   {
      new public void Print()
      {
         Console.WriteLine( "This is the second derived class." );
      }
   }

   class Program
   {
      static void Main() // Main
      {
         SecondDerived derived = new SecondDerived();    // Use SecondDerived.
         MyBaseClass mybc = (MyBaseClass) derived;       // Use MyBaseClass.

         derived.Print();
         mybc.Print();
      }
   }
}
