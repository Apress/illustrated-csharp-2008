using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Page_643
{
   class Program
   {
      static void Main( string[] args )
      {
         int? myI1, myI2, myI3;

         myI1 = 28;                    // Value of underlying type
         myI2 = myI1;                  // Value of nullable type
         myI3 = null;                  // Null

         Console.WriteLine( "myI1: {0}, myI2: {1}", myI1, myI2 );
         Console.WriteLine( "myI3 {0} null", myI3 == null ? "is" : "is not" );
      }
   }
}
