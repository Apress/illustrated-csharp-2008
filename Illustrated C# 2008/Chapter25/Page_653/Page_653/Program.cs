using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Page_653
{
   class MyClass
   {
      class MyCounter                                       // Nested class
      {
         private int _Count = 0;
         public int Count                                   // Read-only property
         {
            get { return _Count; }
         }

         public static MyCounter operator ++( MyCounter current )
         {
            current._Count++;
            return current;
         }
      }

      private MyCounter counter;                            // Field of nested class

      public MyClass()                                      // Constructor
      {
         counter = new MyCounter();
      }

      public int Incr()                                     // Increment method
      {
         return ( counter++ ).Count;
      }

      public int GetValue()                                 // Get counter value
      {
         return counter.Count;
      }
   }

   class Program
   {
      static void Main()
      {
         MyClass mc = new MyClass();                        // Create object
         mc.Incr();
         mc.Incr();
         mc.Incr();                                         // Increment it.
         mc.Incr();
         mc.Incr();
         mc.Incr(); // Increment it.
         Console.WriteLine( "Total: {0}", mc.GetValue() ); // Print its value.
      }
   }
}
