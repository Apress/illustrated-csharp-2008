using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * 
 * This file has both the named method version and the anonymous method
 * version shown in Figure 15-11.  You can comment out one version and
 * then the other to compare them as they run.
 * 
 */

namespace Page_370
{
   //// Uses a named method
   //class Program
   //{
   //   public static int Add20( int x )
   //   {
   //      return x + 20;
   //   }

   //   delegate int OtherDel( int InParam );
   //   static void Main()
   //   {
   //      OtherDel del = Add20;

   //      Console.WriteLine( "{0}", del( 5 ) );
   //      Console.WriteLine( "{0}", del( 6 ) );
   //   }
   //}


   // Uses an anonymous method
   class Program
   {
      delegate int OtherDel( int InParam );
      static void Main()
      {
         OtherDel del = delegate( int x )
         {
            return x + 20;
         };
         Console.WriteLine( "{0}", del( 5 ) );
         Console.WriteLine( "{0}", del( 6 ) );
      }
   }
}
