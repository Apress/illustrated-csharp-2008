using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Page_333
{
   class Program
   {
      static void Main( string[] args )
      {
         int[] myIntArray;                                     // Declare the array.

         myIntArray = new int[4];                              // Instantiate the array.

         for ( int i=0; i < 4; i++ )                           // Set the values.
            myIntArray[i] = i * 10;

         for ( int i=0; i < 4; i++ )                           // Read and display the values of each element.
            Console.WriteLine( "Value of element {0} = {1}",
                                 i, myIntArray[i] );
      }
   }
}
