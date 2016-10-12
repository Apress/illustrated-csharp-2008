using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Page_583
{
   delegate long MyDel( int first, int second );
   class Program
   {
      static long Sum( int x, int y )
      {
         Console.WriteLine( "                  Inside Sum" );
         Thread.Sleep( 100 );

         return x + y;
      }

      static void Main()
      {
         MyDel del = new MyDel( Sum );

         IAsyncResult iar = del.BeginInvoke( 3, 5, null, null ); // Start async.
         Console.WriteLine( "After BeginInvoke" );

         while ( !iar.IsCompleted )
         {
            Console.WriteLine( "Not Done" );

            // Continue processing, even though in this case it's just busywork.
            for ( long i = 0; i < 10000000; i++ )
               ;
         }
         Console.WriteLine( "Done" );

         long result = del.EndInvoke( iar );
         Console.WriteLine( "Result: {0}", result );
      }
   }
}
