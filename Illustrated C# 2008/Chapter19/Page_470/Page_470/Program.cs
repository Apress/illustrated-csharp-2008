using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Page_470
{
   interface IMyIfc<T>                          // Generic interface
   {
      T ReturnIt( T inValue );
   }

   class Simple<S> : IMyIfc<S>                  // Generic class
   {
      public S ReturnIt( S inValue )            // Implement interface
      {
         return inValue;
      }
   }

   class Program
   {
      static void Main()
      {
         var trivInt    = new Simple<int>();
         var trivString = new Simple<string>();

         Console.WriteLine( "{0}", trivInt.ReturnIt( 5 ) );
         Console.WriteLine( "{0}", trivString.ReturnIt( "Hi there." ) );
      }
   }
}
