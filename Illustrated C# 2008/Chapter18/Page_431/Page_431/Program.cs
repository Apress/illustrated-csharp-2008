using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Page_431
{
   class Program
   {
      static void Main( string[] args )
      {
         byte sb;
         ushort sh = 2000;

         unchecked // Set unchecked
         {
            sb = (byte) sh;
            Console.WriteLine( "sb: {0}", sb );

            checked // Set checked
            {
               //// Uncomment the following two lines of code, and the assignment statement will
               //// throw an OverflowException, because the value is too large for the target.
               //sb = (byte) sh;
               //Console.WriteLine( "sb: {0}", sh );
            }
         }
      }
   }
}
