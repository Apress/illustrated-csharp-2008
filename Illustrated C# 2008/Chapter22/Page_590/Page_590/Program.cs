using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

/*
 * 
 * The text on page 590 says that the timer will stop after about 5 seconds,
 * but the line required to stop the timer was inadvertantly left out, but
 * included below in the commented code.  Otherwise, the timer will continue
 * until you press the Enter key on the keyboard.
 * 
 */
namespace Page_590
{
   class Program
   {
      int TimesCalled = 0;

      void Display( object state )
      {
         Console.WriteLine( "{0} {1}", (string) state, ++TimesCalled );
      }

      static void Main()
      {
         Program p = new Program();

         Timer myTimer =
            new Timer( p.Display, "Processing timer event", 2000, 1000 );
         Console.WriteLine( "Timer started." );

         // The next two lines would halt the timer after about 6 seconds
         //Thread.Sleep( 6000 );
         //myTimer.Change( Timeout.Infinite, Timeout.Infinite );

         Console.ReadLine();
      }
   }
}
