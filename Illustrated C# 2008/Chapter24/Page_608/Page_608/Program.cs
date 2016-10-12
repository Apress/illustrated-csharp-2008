using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Page_608
{
   class BaseClass
   {
      public int BaseField = 0;
   }

   class DerivedClass : BaseClass
   {
      public int DerivedField = 0;
   }

   class Program
   {
      static void Main()
      {
         var bc = new BaseClass();
         var dc = new DerivedClass();
         BaseClass[] bca = new BaseClass[] { bc, dc };

         foreach ( var v in bca )
         {
            Type t = v.GetType();                              // Get the type.

            Console.WriteLine( "Object type : {0}", t.Name );

            FieldInfo[] fi = t.GetFields();                    // Get the field info.
            foreach ( var f in fi )
               Console.WriteLine( "      Field : {0}", f.Name );
            Console.WriteLine();
         }
      }
   }
}
