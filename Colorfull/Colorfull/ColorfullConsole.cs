using System;

namespace Restuta.ConsoleExtensions.Colorfull
{
    public static class ColorfullConsole
    {
        public static void WriteLine(ColorfullString @string)
        {
            ColorfullString.WriteToConsole();
            Console.WriteLine();
        }
    }
}