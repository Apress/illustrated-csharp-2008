using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Page_214
{
   class Program
   {
      static void Main( string[] args )
      {
         int a, b, x = 14;

         a = x << 3;             // Shift left
         b = x >> 3;             // Shift right

         Console.WriteLine( "{0} << 3 = {1}", x, a );
         Console.WriteLine( "{0} >> 3 = {1}", x, b );
      }
   }
}
