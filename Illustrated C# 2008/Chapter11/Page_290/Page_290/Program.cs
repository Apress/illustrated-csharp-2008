using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Page_290
{
   class Program
   {
      static void Main()
      {
         int[] arr = new int[5];
         try
         {
            arr[6] = 10;
         }
         catch ( IndexOutOfRangeException e )
         {
            Console.WriteLine( "Message: {0}", e.Message );
            Console.WriteLine( "Source:  {0}", e.Source );
            Console.WriteLine( "Stack:   {0}", e.StackTrace );
         }
      }
   }
}
