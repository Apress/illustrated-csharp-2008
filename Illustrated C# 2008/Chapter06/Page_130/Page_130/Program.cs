using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Page_130
{
   class RandomNumberClass
   {
      private static Random RandomKey;    // Private static field

      static RandomNumberClass()          // Static constructor
      {
         RandomKey = new Random();        // Initialize RandomKey
      }

      public int GetRandomNumber()
      {
         return RandomKey.Next();
      }
   }

   class Program
   {
      static void Main()
      {
         RandomNumberClass a = new RandomNumberClass();
         RandomNumberClass b = new RandomNumberClass();

         Console.WriteLine( "Next Random #: {0}", a.GetRandomNumber() );
         Console.WriteLine( "Next Random #: {0}", b.GetRandomNumber() );
      }
   }
}
