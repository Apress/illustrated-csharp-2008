using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Page_471
{
   interface IMyIfc<T> // Generic interface
   {
      T ReturnIt( T inValue );
   }

   class Simple : IMyIfc<int>, IMyIfc<string>            // Non-generic class
   {
      public int ReturnIt( int inValue )                 // Implement int interface
      {
         return inValue;
      }

      public string ReturnIt( string inValue )           // Implement string interface
      {
         return inValue;
      }
   }

   class Program
   {
      static void Main()
      {
         Simple trivInt    = new Simple();
         Simple trivString = new Simple();

         Console.WriteLine( "{0}", trivInt.ReturnIt( 5 ) );
         Console.WriteLine( "{0}", trivString.ReturnIt( "Hi there." ) );
      }
   }
}
