﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Page_142
{
   class MyClass
   {
      int Var1 = 10;

      public int ReturnMaxSum( int Var1 )
      {
         return Var1 > this.Var1
                  ? Var1               // Parameter
                  : this.Var1;         // Field
      }
   }

   class Program
   {
      static void Main()
      {
         MyClass mc = new MyClass();
         Console.WriteLine( "Max: {0}", mc.ReturnMaxSum( 30 ) );
         Console.WriteLine( "Max: {0}", mc.ReturnMaxSum( 5 ) );
      }
   }
}
