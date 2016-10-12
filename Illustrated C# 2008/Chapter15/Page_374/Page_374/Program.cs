using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Page_374
{
   class Program
   {
      delegate void MyDel();

      static void Main()
      {
         MyDel mDel;
         {
            int x = 5;

            mDel = delegate
            {
               Console.WriteLine( "Value of x: {0}", x );
            };
         }

         // Console.WriteLine("Value of x: {0}", x);

         if ( null != mDel )
            mDel();
      }
   }
}
