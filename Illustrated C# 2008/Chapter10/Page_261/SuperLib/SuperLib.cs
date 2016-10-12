using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SuperLib
{
   public class SquareWidget
   {
      public double SideLength = 0;
      public double Area
      {
         get
         {
            return SideLength * SideLength;
         }
      }
   }
}
