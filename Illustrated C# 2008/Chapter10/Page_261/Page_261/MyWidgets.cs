using System;
using SuperLib;

namespace Page_261
{
   class WidgetsProgram
   {
      static void Main()
      {
         SquareWidget sq = new SquareWidget();     // From class library

         sq.SideLength = 5.0;                      // Set the side length.
         Console.WriteLine( sq.Area );             // Print out the area.
      }
   }
}
