﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Page_165
{
   class MyBaseClass
   {
      virtual public void Print()
      {
         Console.WriteLine( "This is the base class." );
      }
   }

   class MyDerivedClass : MyBaseClass
   {
      override public void Print()
      {
         Console.WriteLine( "This is the derived class." );
      }
   }

   class Program
   {
      static void Main()
      {
         MyDerivedClass derived = new MyDerivedClass();
         MyBaseClass mybc = (MyBaseClass) derived;

         derived.Print();
         mybc.Print();
      }
   }
}
