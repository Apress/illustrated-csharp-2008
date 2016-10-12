using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Page_293
{
   class Program
   {
      private static void ShowFinally( int inVal )
      {
         try
         {
            if ( inVal < 10 )
            {
               Console.Write( "First Branch - " );
               return;
            }
            else
               Console.Write( "Second Branch - " );
         }
         finally
         {
            Console.WriteLine( "In finally statement" );
         }
      }

      static void Main( string[] args )
      {
         ShowFinally( 20 );
         ShowFinally( 5 );
      }
   }
}
