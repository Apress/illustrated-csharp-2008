using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Page_85
{
   class MyClass
   {
      public int Val = 20;          // Initialize field to 20.
   }

   class Program
   {
      static void MyMethod(ref MyClass f1, ref int f2)
      {
         f1.Val = f1.Val + 5;       // Add 5 to field of f1 param.
         f2 = f2 + 5;               // Add 5 to second param.
      }

      static void Main()
      {
         MyClass A1 = new MyClass();
         int A2 = 10;

         MyMethod(ref A1, ref A2);  // Call the method.
      }
   }
}
