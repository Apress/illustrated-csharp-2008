using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Page_519
{
   class Other
   {
      static public string Name = "Mary Jones";
   }

   class Program
   {
      static void Main()
      {
         string Major = "History";

         var student = new { Age = 19, Other.Name, Major };

         Console.WriteLine( "{0}, Age {1}, Major: {2}",
         student.Name, student.Age, student.Major );
      }
   }
}
