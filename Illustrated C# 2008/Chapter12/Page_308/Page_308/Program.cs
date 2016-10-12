using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Page_308
{
   struct Simple
   {
      public int X;
      public int Y;
   }

   class Program
   {
      static void Main()
      {
         Simple s1, s2;
         //Console.WriteLine( "{0}, {1}", s1.X, s1.Y );  // Compiler error, since s1 hasn't
                                                         // been assigned to yet.
         s2.X = 5;
         s2.Y = 10;

         Console.WriteLine( "{0}, {1}", s2.X, s2.Y ); // OK
      }
   }
}
