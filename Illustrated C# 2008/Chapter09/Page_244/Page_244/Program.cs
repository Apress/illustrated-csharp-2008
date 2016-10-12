using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Page_244
{
   class Program
   {
      static void Main( string[] args )
      {
         // The body of this for loop is executed three times.
         for ( int i=0; i < 3; i++ )
            Console.WriteLine( "Inside loop. i:  {0}", i );

         Console.WriteLine( "Out of Loop" );
      }
   }
}
