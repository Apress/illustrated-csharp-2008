﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Page_542
{
   class Program
   {
      static int[] numbers = new int[] { 2, 4, 6 };
      static void Main()
      {
         int total = numbers.Sum();
         int howMany = numbers.Count();

         Console.WriteLine( "Total: {0}, Count: {1}", total, howMany );
      }
   }
}
