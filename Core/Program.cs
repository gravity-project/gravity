#region Using Statements
using System;
using System.Collections.Generic;
using System.Linq;
#endregion

namespace Gravity
{
   /// <summary>
   /// The main class.
   /// </summary>
   public static class Program
   {
      private static Core core;

      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main()
      {
         core = new Core();
         core.Run();
      }
   }
}
