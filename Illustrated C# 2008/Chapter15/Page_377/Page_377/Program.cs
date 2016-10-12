using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Page_377
{
   class Program
   {
      delegate double MyDel( int par );

      static void Main()
      {
         MyDel del = delegate( int x )                      // Anonymous method
         {
            return x + 1;
         };


         MyDel le1 = ( int x ) => { return x + 1; };        // Lambda expression
         MyDel le2 =     ( x ) => { return x + 1; };        // Lambda expression
         MyDel le3 =       x   => { return x + 1; };        // Lambda expression
         MyDel le4 =       x   =>          x + 1;           // Lambda expression

         Console.WriteLine( "{0}", del( 12 ) );
         Console.WriteLine( "{0}", le1( 12 ) );
         Console.WriteLine( "{0}", le2( 12 ) );
         Console.WriteLine( "{0}", le3( 12 ) );
         Console.WriteLine( "{0}", le4( 12 ) );
      }
   }
}
