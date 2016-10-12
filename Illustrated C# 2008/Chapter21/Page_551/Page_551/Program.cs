using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Page_551
{
   class Program
   {
      static void Main()
      {
         int[] intArray = new int[] { 3, 4, 5, 6, 7, 9 };

         var countOdd = intArray.Count( x => x % 2 == 1 );
         Console.WriteLine( "Count of odd numbers: {0}", countOdd );
      }
   }
}
