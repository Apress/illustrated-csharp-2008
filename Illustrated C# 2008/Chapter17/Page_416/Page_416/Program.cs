﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Page_416
{
   interface IIfc1                                 // Declare interface
   {
      void PrintOut( string s );
   }

   interface IIfc2                                 // Declare interface
   {
      void PrintOut( string t );
   }

   class MyClass : IIfc1, IIfc2
   {
      void IIfc1.PrintOut( string s )              // Explicit interface member implementation
      {
         Console.WriteLine( "IIfc1:  {0}", s );
      }

      void IIfc2.PrintOut( string s )              // Explicit interface member implementation
      {
         Console.WriteLine( "IIfc2:  {0}", s );
      }
   }

   class Program
   {
      static void Main()
      {
         MyClass mc = new MyClass();               // Create class object

         IIfc1 ifc1 = (IIfc1) mc;                  // Get reference to IIfc1
         ifc1.PrintOut( "interface 1." );          // Call explicit implementation

         IIfc2 ifc2 = (IIfc2) mc;                  // Get reference to IIfc2
         ifc2.PrintOut( "interface 2." );          // Call explicit implementation
      }
   }
}
