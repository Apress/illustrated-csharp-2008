using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Page_469
{
   struct PieceOfData<T>                           // Generic struct
   {
      private T _Data;

      public PieceOfData( T value )
      {
         _Data = value;
      }

      public T Data
      {
         get { return _Data;  }
         set { _Data = value; }
      }
   }

   class Program
   {
      static void Main()
      {
         var intData = new PieceOfData<int>( 10 );
         var stringData = new PieceOfData<string>( "Hi there." );

         Console.WriteLine( "intData    = {0}", intData.Data );
         Console.WriteLine( "stringData = {0}", stringData.Data );
      }
   }
}
