using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Page_82
{
   class MyClass
   {
      public int Val = 20;       // Initialize the field to 20.
   }

   class Program
   {
      static void MyMethod(MyClass f1, int f2)
      {
         f1.Val = f1.Val + 5;    // Add 5 to field of f1 param.
         f2     = f2 + 5;        // Add 5 to second param.
      }

      static void Main()
      {
         MyClass A1 = new MyClass();
         int A2     = 10;

         MyMethod(A1, A2);       // Call the method.
      }
   }
}
