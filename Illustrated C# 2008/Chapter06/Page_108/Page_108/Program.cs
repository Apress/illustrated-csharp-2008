using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Page_108
{
   class X
   {
      static public int A;             // Static field
      static public void PrintValA()   // Static method
      {
         Console.WriteLine( "Value of A: {0}", A );
      }
   }

   class Program
   {
      static void Main()
      {
         X.A = 10;                     // Use dot-syntax notation
         X.PrintValA();                // Use dot-syntax notation
      }
   }
}
