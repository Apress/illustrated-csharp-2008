using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Page_409
{
   interface IDataRetrieve                      // Declare interface
   {
      int GetData();
   }

   interface IDataStore                         // Declare interface
   {
      void SetData( int x );
   }

   class MyData : IDataRetrieve, IDataStore     // Declare class
   {
      int Mem1;                                 // Declare field

      public int GetData()
      {
         return Mem1;
      }

      public void SetData( int x )
      {
         Mem1 = x;
      }
   }

   class Program
   {
      static void Main()                        // Main
      {
         MyData data = new MyData();
         data.SetData( 5 );
         Console.WriteLine( "Value = {0}", data.GetData() );
      }
   }
}
