using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Page_238_2
{
   class Program
   {
      static void Main( string[] args )
      {
         for ( int x = 1; x < 4; x++ )
         {
            switch ( x )
            {
               default:
                  Console.WriteLine( "x is {0} -- In Default case", x );
                  break;
            }
         }
      }
   }
}
