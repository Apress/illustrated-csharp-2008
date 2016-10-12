using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Page_633_1
{
   class Program
   {
      static void Main( string[] args )
      {
         string s = "Hi there.";

         Console.WriteLine( "{0}", s.ToUpper() );        // Print uppercase copy
         Console.WriteLine( "{0}", s );                  // String is unchanged
      }
   }
}
