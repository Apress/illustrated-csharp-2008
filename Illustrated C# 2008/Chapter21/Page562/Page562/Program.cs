﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace Page562
{
   class Program
   {
      static void Main()
      {
         XDocument xd = new XDocument(                // Create XML tree
            new XElement( "root",
               new XElement( "first" ) )
            );

         Console.WriteLine( "Original tree" );
         Console.WriteLine( xd );
         Console.WriteLine();                         // Display the tree.

         XElement rt = xd.Element( "root" );          // Get the first element.

         rt.Add( new XElement( "second" ) );          // Add a child element.

         rt.Add( new XElement( "third" ),             // Add three more children.
         new XComment( "Important Comment" ),
         new XElement( "fourth" ) );

         Console.WriteLine( "Modified tree" );
         Console.WriteLine( xd );                     // Display modified tree
      }
   }
}
