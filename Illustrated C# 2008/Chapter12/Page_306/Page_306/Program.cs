using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Page_306
{
   class CSimple
   {
      public int X;
      public int Y;
   }

   struct Simple
   {
      public int X;
      public int Y;
   }

   class Program
   {
      static void Main()
      {
         CSimple cs1 = new CSimple(), cs2 = null;           // Class instances
         Simple  ss1 = new Simple(), ss2 = new Simple();    // Struct instances

         cs1.X = ss1.X = 5;                                 // Assign 5 to ss1.X and cs1.X
         cs1.Y = ss1.Y = 10;                                // Assign 10 to ss1.Y and cs1.Y

         cs2 = cs1;                                         // Assign class instance
         ss2 = ss1;                                         // Assign struct instance

         Console.WriteLine( "cs1.X: {0},   cs1.Y: {1}", cs1.X, cs1.Y );
         Console.WriteLine( "cs2.X: {0},   cs2.Y: {1}", cs2.X, cs2.Y );
         Console.WriteLine( "ss1.X: {0},   ss1.Y: {1}", ss1.X, ss1.Y );
         Console.WriteLine( "ss2.X: {0},   ss2.Y: {1}", ss2.X, ss2.Y );
      }
   }
}
