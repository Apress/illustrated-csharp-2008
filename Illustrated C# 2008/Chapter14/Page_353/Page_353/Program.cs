using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Page_353
{
   class A
   {
      public int Value = 5;
   }
   class Program
   {
      static void Main()
      {
         A[] AArray1 = new A[3] { new A(), new A(), new A() };    // Step 1
         A[] AArray2 = (A[]) AArray1.Clone();                     // Step 2

         AArray2[0].Value = 100;
         AArray2[1].Value = 200;
         AArray2[2].Value = 300;                                  // Step 3

         // Both arrays are pointing to the same objects.
         Console.WriteLine("AArray1 = {0}, {1}, {2}",
                     AArray1[0].Value, AArray1[1].Value, AArray1[2].Value );

         Console.WriteLine("AArray2 = {0}, {1}, {2}",
                     AArray2[0].Value, AArray2[1].Value, AArray2[2].Value );
      }
   }
}
