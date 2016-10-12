using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Page_341
{
   class Program
   {
      static void Main( string[] args )
      {
         int[][] Arr = new int[3][];                        // 1. Instantiate top level array

         Arr[0] = new int[] { 10, 20, 30 };                 // 2. Instantiate sub-array
         Arr[1] = new int[] { 40, 50, 60, 70 };             // 3. Instantiate sub-array
         Arr[2] = new int[] { 80, 90, 100, 110, 120 };      // 4. Instantiate sub-array

         Console.WriteLine( "Arr[0] = {0}, {1}, {2}",
                                 Arr[0][0], Arr[0][1], Arr[0][2] );

         Console.WriteLine( "Arr[1] = {0}, {1}, {2}, {3}",
                                 Arr[1][0], Arr[1][1], Arr[1][2], Arr[1][3] );

         Console.WriteLine( "Arr[2] = {0}, {1}, {2}, {3}, {4}",
                                 Arr[2][0], Arr[2][1], Arr[2][2], Arr[2][3], Arr[2][4] );
      }
   }
}
