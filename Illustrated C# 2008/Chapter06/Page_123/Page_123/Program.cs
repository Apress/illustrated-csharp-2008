﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Page_123
{
   class C1
   {
      public int MyValue // Allocates memory
      {
         set;
         get;
      }
   }

   class Program
   {
      static void Main()
      {
         C1 c = new C1();
         Console.WriteLine( "MyValue:  {0}", c.MyValue );

         c.MyValue = 20;
         Console.WriteLine( "MyValue:  {0}", c.MyValue );
      }
   }
}
