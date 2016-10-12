using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Page_454
{
   class MyFloatStack
   {
      float[] StackArray;
      int StackPointer = 0;
      const int MaxStack = 10;

      public void Push( float x )
      {
         if ( !IsStackFull )
            StackArray[StackPointer++] = x;
      }

      public float Pop()
      {
         return ( !IsStackEmpty )
                     ? StackArray[--StackPointer]
                     : StackArray[0];
      }

      bool IsStackFull
      {
         get
         {
            return StackPointer >= MaxStack;
         }
      }

      bool IsStackEmpty
      {
         get
         {
            return StackPointer <= 0;
         }
      }

      public MyFloatStack()
      {
         StackArray = new float[MaxStack];
      }

      public void Print()
      {
         for ( int i = StackPointer - 1; i >= 0; i-- )
            Console.WriteLine( "Value: {0}", StackArray[i] );
      }
   }

   class Program
   {
      static void Main()
      {
         var stackInt = new MyFloatStack();

         stackInt.Push( 3.2f );
         stackInt.Push( 5.3f );
         stackInt.Push( 7.4f );

         stackInt.Print();
      }
   }
}
