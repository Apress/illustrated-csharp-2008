﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Page_111
{
   class X
   {
      public const double PI = 3.1416;
   }

   class Program
   {
      static void Main()
      {
         Console.WriteLine( "pi = {0}", X.PI ); // Use static field PI
      }
   }
}
