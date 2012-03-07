using System;

namespace Restuta.ConsoleExtensions.Colorfull
{
    public static class ColorfullConsole
    {
        private static readonly object syncObject = new object();

        public static void WriteLine(ColorfullString @string)
        {
            lock (syncObject)
            {
                ColorfullString.WriteToConsole();
                Console.WriteLine();
            }
        }
    }
}