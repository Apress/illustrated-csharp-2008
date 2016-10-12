using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Page_242
{
   class Program
   {
      static void Main( string[] args )
      {
         int x = 0;
         do
            Console.WriteLine( "x is {0}", x++ );
         while ( x < 3 );
      }
   }
}
