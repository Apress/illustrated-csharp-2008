﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace Page_557
{
   class Program
   {
      static void Main()
      {
         XDocument employees1 =
            new XDocument(                                     // Create the XML document.
               new XElement( "Employees",                      // Create the root element.
                  new XElement( "Name", "Bob Smith" ),         // Create element
                  new XElement( "Name", "Sally Jones" )        // Create element
               )
            );

         employees1.Save( "EmployeesFile.xml" );               // Save to a file

         // Load the saved document into a new variable.
         XDocument employees2 = XDocument.Load( "EmployeesFile.xml" );

         Console.WriteLine( employees2 );                      // Display document
      }
   }
}
