using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
namespace Page_558
{
   class Program
   {
      static void Main()
      {
         XDocument employeeDoc =
            new XDocument(                               // Create the document.
               new XElement( "Employees",                // Create the root element.
                  new XElement( "Employee",              // First employee element
                     new XElement( "Name", "Bob Smith" ),
                     new XElement( "PhoneNumber", "408-555-1000" )
                  ),

                  new XElement( "Employee",              // Second employee element
                     new XElement( "Name", "Sally Jones" ),
                     new XElement( "PhoneNumber", "415-555-2000" ),
                     new XElement( "PhoneNumber", "415-555-2001" )
                  )
               )
            );

         Console.WriteLine( employeeDoc );               // Displays the document
      }
   }
}
