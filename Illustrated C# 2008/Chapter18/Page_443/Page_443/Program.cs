using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Page_443
{
   class Program
   {
      static void Main( string[] args )
      {
         int i = 10;                                     // Create and initialize value type

         object oi = i;                                  // Create and initialize reference type
         Console.WriteLine( "i: {0}, io: {1}", i, oi );

         i = 12;
         oi = 15;
         Console.WriteLine( "i: {0}, io: {1}", i, oi );
      }
   }
}
