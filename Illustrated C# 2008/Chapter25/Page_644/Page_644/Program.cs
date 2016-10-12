using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Page_644
{
   class Program
   {
      static void Main( string[] args )
      {
         int? myI4 = null;
         Console.WriteLine( "myI4: {0}", myI4 ?? -1 );

         myI4 = 10;
         Console.WriteLine( "myI4: {0}", myI4 ?? -1 );
      }
   }
}
