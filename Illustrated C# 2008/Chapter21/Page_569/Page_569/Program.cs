using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace Page_569
{
   class Program
   {
      static void Main()
      {
         XDocument xd = new XDocument(
            new XDeclaration( "1.0", "utf-8", "yes" ),
            new XComment( "This is a comment" ),
            new XProcessingInstruction( "xml-stylesheet",
                        @"href=""stories.css"" type=""text/css""" ),

            new XElement( "root",
               new XElement( "first" ),
               new XElement( "second" )
            )

         );

         xd.Save("Sample.xml");
      }
   }
}
