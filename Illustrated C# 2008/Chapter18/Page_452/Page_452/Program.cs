using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Page_452
{
   class Employee : Person
   {
   }

   class Person
   {
      public string Name = "Anonymous";
      public int Age = 25;
   }

   class Program
   {
      static void Main()
      {
         Employee bill = new Employee();
         Person p;

         p = bill as Person;
         if ( p != null )
         {
            Console.WriteLine( "Person Info: {0}, {1}", p.Name, p.Age );
         }
      }
   }
}
