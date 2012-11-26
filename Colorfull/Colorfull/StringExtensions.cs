using System;

namespace Restuta.ConsoleExtensions.Colorfull
{
    public static class StringExtensions
    {
        public static ColorfulString Black(this string source)
        {
            return new ColorfulString(source, ConsoleColor.Black);
        }

        public static ColorfulString Blue(this string source)
        {
            return new ColorfulString(source, ConsoleColor.Blue);
        }

        public static ColorfulString Cyan(this string source)
        {
            return new ColorfulString(source, ConsoleColor.Cyan);
        }

        public static ColorfulString DarkBlue(this string source)
        {
            return new ColorfulString(source, ConsoleColor.DarkBlue);
        }

        public static ColorfulString DarkCyan(this string source)
        {
            return new ColorfulString(source, ConsoleColor.DarkCyan);
        }

        public static ColorfulString DarkGray(this string source)
        {
            return new ColorfulString(source, ConsoleColor.DarkGray);
        }

        public static ColorfulString DarkGreen(this string source)
        {
            return new ColorfulString(source, ConsoleColor.DarkGreen);
        }

        public static ColorfulString DarkMagenta(this string source)
        {
            return new ColorfulString(source, ConsoleColor.DarkMagenta);
        }

        public static ColorfulString DarkRed(this string source)
        {
            return new ColorfulString(source, ConsoleColor.DarkRed);
        }

        public static ColorfulString DarkYellow(this string source)
        {
            return new ColorfulString(source, ConsoleColor.DarkYellow);
        }

        public static ColorfulString Gray(this string source)
        {
            return new ColorfulString(source, ConsoleColor.Gray);
        }

        public static ColorfulString Green(this string source)
        {
            return new ColorfulString(source, ConsoleColor.Green);
        }

        public static ColorfulString Magenta(this string source)
        {
            return new ColorfulString(source, ConsoleColor.Magenta);
        }

        public static ColorfulString Red(this string source)
        {
            return new ColorfulString(source, ConsoleColor.Red);
        }

        public static ColorfulString White(this string source)
        {
            return new ColorfulString(source, ConsoleColor.White);
        }

        public static ColorfulString Yellow(this string source)
        {
            return new ColorfulString(source, ConsoleColor.Yellow);
        }
    }
}