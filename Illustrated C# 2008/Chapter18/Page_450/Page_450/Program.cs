﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Page_450
{
   class Employee : Person
   {
   }

   class Person
   {
      public string Name;
      public int Age;

      // Convert a Person object to an int.
      public static implicit operator int( Person p )
      {
         return p.Age;
      }
   }

   class Program
   {
      static void Main()
      {
         Employee bill = new Employee();
         bill.Name = "William";
         bill.Age = 25;

         float fVar = bill;

         Console.WriteLine( "Person Info: {0}, {1}", bill.Name, fVar );
      }
   }
}
