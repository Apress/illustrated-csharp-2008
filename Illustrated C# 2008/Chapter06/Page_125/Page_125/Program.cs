using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Page_125
{
   class Trivial
   {
      static int myValue;
      public static int MyValue
      {
         set { myValue = value; }
         get { return myValue;  }
      }

      public void PrintValue()
      {
         Console.WriteLine( "Value from inside: {0}", MyValue );
      }
   }

   class Program
   {
      static void Main()
      {
         Console.WriteLine( "Init Value: {0}", Trivial.MyValue );
         Trivial.MyValue = 10;
         Console.WriteLine( "New Value : {0}", Trivial.MyValue );

         Trivial tr = new Trivial();
         tr.PrintValue();
      }
   }
}
