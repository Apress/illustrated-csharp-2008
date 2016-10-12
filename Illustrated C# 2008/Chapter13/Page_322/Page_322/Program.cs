﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Page_322
{
   [Flags]
   enum CardDeckSettings : uint
   {
      SingleDeck    = 0x01,               // Bit 0
      LargePictures = 0x02,               // Bit 1
      FancyNumbers  = 0x04,               // Bit 2
      Animation     = 0x08                // Bit 3
   }

   class MyClass
   {
      bool UseSingleDeck   = false;
      bool UseBigPics      = false;
      bool UseFancyNums    = false;
      bool UseAnimation    = false;

      public void SetOptions( CardDeckSettings ops )
      {
         UseSingleDeck = ( ops & CardDeckSettings.SingleDeck )
                                    == CardDeckSettings.SingleDeck;
         UseBigPics = ( ops & CardDeckSettings.LargePictures )
                                    == CardDeckSettings.LargePictures;
         UseFancyNums = ( ops & CardDeckSettings.FancyNumbers )
                                    == CardDeckSettings.FancyNumbers;
         UseAnimation = ( ops & CardDeckSettings.Animation )
                                    == CardDeckSettings.Animation;
      }

      public void PrintOptions()
      {
         Console.WriteLine( "Option settings:" );
         Console.WriteLine( "   Use Single Deck    - {0}", UseSingleDeck );
         Console.WriteLine( "   Use Large Pictures - {0}", UseBigPics );
         Console.WriteLine( "   Use Fancy Numbers  - {0}", UseFancyNums );
         Console.WriteLine( "   Show Animation     - {0}", UseAnimation );
      }
   }

   class Program
   {
      static void Main()
      {
         MyClass mc = new MyClass();
         CardDeckSettings ops = CardDeckSettings.SingleDeck
                                 | CardDeckSettings.FancyNumbers
                                 | CardDeckSettings.Animation;
         mc.SetOptions( ops );
         mc.PrintOptions();
      }
   }
}
