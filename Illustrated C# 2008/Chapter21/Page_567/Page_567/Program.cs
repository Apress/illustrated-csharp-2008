﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace Page_567
{
   class Program
   {
      static void Main()
      {
         XDocument xd = new XDocument(
            new XElement( "root",
               new XAttribute( "color", "red" ),
               new XAttribute( "size", "large" ),
               new XElement( "first" ) ) );

         XElement rt = xd.Element( "root" );             // Get the element.

         rt.SetAttributeValue( "size", "medium" );       // Change attribute value
         rt.SetAttributeValue( "width", "narrow" );      // Add an attribute.

         Console.WriteLine( xd );
         Console.WriteLine();
      }
   }
}
