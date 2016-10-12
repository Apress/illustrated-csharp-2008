using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Page_552
{
   class Program
   {
      static void Main()
      {
         int[] intArray = new int[] { 3, 4, 5, 6, 7, 9 };

         Func<int, bool> myDel = delegate( int x )
                                 {
                                    return x % 2 == 1;
                                 };

         var countOdd = intArray.Count( myDel );
         Console.WriteLine( "Count of odd numbers: {0}", countOdd );
      }
   }
}
