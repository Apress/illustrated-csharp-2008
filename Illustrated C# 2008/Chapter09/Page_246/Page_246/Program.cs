using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Page_246
{
   class Program
   {
      static void Main()
      {
         const int MaxI = 5;

         for ( int i = 0, j = 10; i < MaxI; i++, j += 10 )
         {
            Console.WriteLine( "{0}, {1}", i, j );
         }
      }
   }
}
