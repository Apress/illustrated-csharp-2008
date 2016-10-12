﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Page_88
{
   class MyClass
   {
      public int Val = 20;          // Initialize field to 20.
   }

   class Program
   {
      static void MyMethod(out MyClass f1, out int f2)
      {
         f1 = new MyClass();        // Create an object of the class.
         f1.Val = 25;               // Assign to the class field.
         f2 = 15;                   // Assign to the int param.
      }

      static void Main()
      {
         MyClass A1 = null;
         int A2;

         MyMethod(out A1, out A2);  // Call the method.
      }
   }
}
