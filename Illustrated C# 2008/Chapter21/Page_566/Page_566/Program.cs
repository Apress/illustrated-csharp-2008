using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace Page_566
{
   class Program
   {
      static void Main()
      {
         XDocument xd = new XDocument(
            new XElement( "root",
                  new XAttribute( "color", "red" ),
                  new XAttribute( "size", "large" ),
               new XElement( "first" )
            )
         );

         XElement rt = xd.Element( "root" );          // Get the element.

         rt.Attribute( "color" ).Remove();            // Remove the color attribute.
         rt.SetAttributeValue( "size", null );        // Remove the size attribute.

         Console.WriteLine( xd );
      }
   }
}
