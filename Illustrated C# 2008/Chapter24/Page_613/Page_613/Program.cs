using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Page_613
{
   class Program
   {
      [Obsolete( "Use method SuperPrintOut" )]     // Apply attribute to method
      static void PrintOut( string str )
      {
         Console.WriteLine( str );
      }

      static void Main( string[] args )
      {
         PrintOut( "Start of Main" );              // Invoke obsolete method
      }
   }
}
