using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Page_307
{
   struct Simple
   {
      public int X;
      public int Y;

      public Simple( int a, int b )             // Constructor with parameters
      {
         X = a;
         Y = b;
      }
   }

   class Program
   {
      static void Main()
      {
         Simple s1 = new Simple();
         Simple s2 = new Simple( 5, 10 );

         Console.WriteLine( "{0}, {1}", s1.X, s1.Y );
         Console.WriteLine( "{0}, {1}", s2.X, s2.Y );
      }
   }
}
