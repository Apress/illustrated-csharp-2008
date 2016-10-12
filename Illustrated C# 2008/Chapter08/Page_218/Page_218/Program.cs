using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Page_218
{
   class Program
   {
      static void Main( string[] args )
      {
         int x = 10, y = 9;
         int highVal = x > y                          // Condition
               ? x                                    // Expression 1
               : y;                                   // Expression 2
         Console.WriteLine( "highVal: {0}\n", highVal );

         Console.WriteLine( "x is{0} greater than y",
               x > y                                  // Condition
               ? ""                                   // Expression 1
               : " not" );                            // Expression 2

         y = 11;
         Console.WriteLine( "x is{0} greater than y",
               x > y                                  // Condition
               ? ""                                   // Expression 1
               : " not" );                            // Expression 2
      }
   }
}
