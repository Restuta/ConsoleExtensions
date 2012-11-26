using System;

namespace Restuta.ConsoleExtensions.Colorfull
{
    public static class ColorfulConsole
    {
        private static readonly object syncObject = new object();

        public static void WriteLine(ColorfulString @string)
        {
            lock (syncObject)
            {
                ColorfulString.WriteToConsole();
                Console.WriteLine();
            }
        }
    }
}