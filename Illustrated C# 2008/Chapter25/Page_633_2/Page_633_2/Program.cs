using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Page_633_2
{
   class Program
   {
      static void Main( string[] args )
      {
         StringBuilder sb = new StringBuilder( "Hi there." );
         Console.WriteLine( "{0}", sb );                       // Print string
         sb.Replace( "Hi", "Hello" );                          // Replace a substring
         Console.WriteLine( "{0}", sb );                       // Print changed string
      }
   }
}
