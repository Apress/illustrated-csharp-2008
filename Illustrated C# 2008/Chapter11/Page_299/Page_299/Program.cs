using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Page_299
{
   class MyClass
   {
      public static void PrintArg( string arg )
      {
         try
         {
            if ( arg == null )
            {
               ArgumentNullException myEx = new ArgumentNullException( "arg" );
               throw myEx;
            }
            Console.WriteLine( arg );
         }
         catch ( ArgumentNullException e )
         {
            Console.WriteLine( "Message: {0}", e.Message );
         }
      }
   }

   class Program
   {
      static void Main()
      {
         string s = null;
         MyClass.PrintArg( s );
         MyClass.PrintArg( "Hi there!" );
      }
   }
}
