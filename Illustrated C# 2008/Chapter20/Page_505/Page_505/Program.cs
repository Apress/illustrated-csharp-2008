﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Page_505
{
   class MyClass
   {
      public IEnumerator<string> GetEnumerator()
      {
         IEnumerable<string> myEnumerable = BlackAndWhite();      // Get enumerable
         return myEnumerable.GetEnumerator();                     // Get enumerator
      }

      public IEnumerable<string> BlackAndWhite()
      {
         yield return "black";
         yield return "gray";
         yield return "white";
      }
   }

   class Program
   {
      static void Main()
      {
         MyClass mc = new MyClass();

         foreach ( string shade in mc )
            Console.Write( "{0} ", shade );

         foreach ( string shade in mc.BlackAndWhite() )
            Console.Write( "{0} ", shade );
      }
   }
}