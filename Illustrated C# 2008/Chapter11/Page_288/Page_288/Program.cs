using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Page_288
{
   class Program
   {
      static void Main()
      {
         int x = 10;
         try
         {
            int y = 0;
            x /= y; // Raises an exception
         }
         catch
         {
            // ...  Code to handle the exception
            Console.WriteLine( "Handling all exceptions - Keep on Running" );
         }
      }
   }
}
