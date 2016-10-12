using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Page_610
{
   class BaseClass
   {
      public int MyFieldBase;
   }

   class DerivedClass : BaseClass
   {
      public int MyFieldDerived;
   }

   class Program
   {
      static void Main()
      {
         Type tbc = typeof( DerivedClass );                       // Get the type.
         Console.WriteLine( "Result is {0}.", tbc.Name );

         Console.WriteLine( "It has the following fields:" );     // Use the type.
         FieldInfo[] fi = tbc.GetFields();
         foreach ( var f in fi )
            Console.WriteLine( "   {0}", f.Name );
      }
   }
}
