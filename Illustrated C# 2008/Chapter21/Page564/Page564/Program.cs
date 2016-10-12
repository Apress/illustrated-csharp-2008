﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace Page564
{
   class Program
   {
      static void Main( string[] args )
      {
         XDocument xd = new XDocument(
            new XElement( "root",
                  new XAttribute( "color", "red" ),      // Attribute constructor
                  new XAttribute( "size", "large" ),     // Attribute constructor
               new XElement( "first" ),
               new XElement( "second" )
               )
            );

         Console.WriteLine( xd );
      }
   }
}
