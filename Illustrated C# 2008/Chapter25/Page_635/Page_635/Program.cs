using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Page_635
{
   class Program
   {
      static void Main( string[] args )
      {
         int myInt = 500;
         Console.WriteLine( "|{0, 10}|", myInt );        // Aligned right
         Console.WriteLine( "|{0,-10}|", myInt );        // Aligned left
      }
   }
}
