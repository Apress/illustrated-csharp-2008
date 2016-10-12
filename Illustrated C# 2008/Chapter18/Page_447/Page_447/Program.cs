﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Page_447
{
   class Person
   {
      public string Name;
      public int Age;
      public Person( string name, int age )
      {
         Name = name;
         Age = age;
      }

      public static implicit operator int( Person p )          // Convert Person to int.
      {
         return p.Age;
      }

      public static implicit operator Person( int i )          // Convert int to Person.
      {
         return new Person( "Nemo", i );
      }
   }

   class Program
   {
      static void Main()
      {
         Person bill = new Person( "bill", 25 );

         int age = bill;
         Console.WriteLine( "Person Info: {0}, {1}", bill.Name, age );

         Person anon = 35;
         Console.WriteLine( "Person Info: {0}, {1}", anon.Name, anon.Age );
      }
   }
}
