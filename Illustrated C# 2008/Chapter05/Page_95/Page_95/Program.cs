﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Page_95
{
   class Program
   {
      static void MethodA( int par1, int par2 )
      {
         Console.WriteLine( "Enter MethodA: {0}, {1}", par1, par2 );
         MethodB( 11, 18 );                                 // Call MethodB.
         Console.WriteLine( "Exit MethodA" );
      }

      static void MethodB( int par1, int par2 )
      {
         Console.WriteLine( "Enter MethodB: {0}, {1}", par1, par2 );
         Console.WriteLine( "Exit MethodB" );
      }

      static void Main()
      {
         Console.WriteLine( "Enter Main" );
         MethodA( 15, 30 );                                 // Call MethodA.
         Console.WriteLine( "Exit Main" );
      }
   }
}
