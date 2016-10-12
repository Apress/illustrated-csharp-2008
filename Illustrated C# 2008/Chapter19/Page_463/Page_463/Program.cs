using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Page_463
{
   class MyStack<T>
   {
      T[] StackArray;
      int StackPointer = 0;
      const int MaxStack = 10;

      public void Push( T x )
      {
         if ( !IsStackFull )
            StackArray[StackPointer++] = x;
      }

      public T Pop()
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

      public MyStack()
      {
         StackArray = new T[MaxStack];
      }

      public void Print()
      {
         for ( int i = StackPointer - 1; i >= 0; i-- )
            Console.WriteLine( " Value: {0}", StackArray[i] );
      }
   }

   class Program
   {
      static void Main()
      {
         var stackInt = new MyStack<int>();
         var stackString = new MyStack<string>();
         stackInt.Push( 3 );
         stackInt.Push( 5 );
         stackInt.Push( 7 );
         stackInt.Print();
         stackString.Push( "Generics are great!" );
         stackString.Push( "Hi there! " );
         stackString.Print();
      }
   }
}
