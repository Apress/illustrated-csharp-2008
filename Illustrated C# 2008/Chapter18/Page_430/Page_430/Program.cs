using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Page_430
{
   class Program
   {
      static void Main( string[] args )
      {
         ushort sh = 2000;
         byte sb;

         sb = unchecked( (byte) sh );              // Most significant bits lost
         Console.WriteLine( "sb: {0}", sb );

         //sb = checked( (byte) sh );                // OverflowException raised
         //Console.WriteLine( "sb: {0}", sb );
      }
   }
}
