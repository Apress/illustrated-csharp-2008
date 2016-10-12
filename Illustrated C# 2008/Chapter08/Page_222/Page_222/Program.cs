using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Page_221
{
   class LimitedInt
   {
      const int MaxValue = 100;
      const int MinValue = 0;

      public static explicit operator int( LimitedInt li )     // Convert type
      {
         return li.TheValue;
      }

      public static explicit operator LimitedInt( int x )      // Convert type
      {
         LimitedInt li = new LimitedInt();
         li.TheValue = x;
         return li;
      }

      private int _TheValue = 0;
      public int TheValue                                      // Property
      {
         get
         {
            return _TheValue;
         }
         set
         {
            if ( value < MinValue )
               _TheValue = 0;
            else
               _TheValue = value > MaxValue
               ? MaxValue
               : value;
         }
      }
   }

   class Program
   {
      static void Main() // Main
      {
         LimitedInt li = (LimitedInt) 5;                       // Convert 5 to LimitedInt
         int Five = (int) li;                                  // Convert LimitedInt to int

         Console.WriteLine( "li: {0}, Five: {1}", li.TheValue, Five );
      }
   }
}
