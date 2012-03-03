using System;

namespace Restuta.ConsoleExtensions.Colorfull
{
    public static class StringExtensions
    {
        public static ColorfullString Black(this string source)
        {
            return new ColorfullString(source, ConsoleColor.Black);
        }

        public static ColorfullString Blue(this string source)
        {
            return new ColorfullString(source, ConsoleColor.Blue);
        }

        public static ColorfullString Cyan(this string source)
        {
            return new ColorfullString(source, ConsoleColor.Cyan);
        }

        public static ColorfullString DarkBlue(this string source)
        {
            return new ColorfullString(source, ConsoleColor.DarkBlue);
        }

        public static ColorfullString DarkCyan(this string source)
        {
            return new ColorfullString(source, ConsoleColor.DarkCyan);
        }

        public static ColorfullString DarkGray(this string source)
        {
            return new ColorfullString(source, ConsoleColor.DarkGray);
        }

        public static ColorfullString DarkGreen(this string source)
        {
            return new ColorfullString(source, ConsoleColor.DarkGreen);
        }

        public static ColorfullString DarkMagenta(this string source)
        {
            return new ColorfullString(source, ConsoleColor.DarkMagenta);
        }

        public static ColorfullString DarkRed(this string source)
        {
            return new ColorfullString(source, ConsoleColor.DarkRed);
        }

        public static ColorfullString DarkYellow(this string source)
        {
            return new ColorfullString(source, ConsoleColor.DarkYellow);
        }

        public static ColorfullString Gray(this string source)
        {
            return new ColorfullString(source, ConsoleColor.Gray);
        }

        public static ColorfullString Green(this string source)
        {
            return new ColorfullString(source, ConsoleColor.Green);
        }

        public static ColorfullString Magenta(this string source)
        {
            return new ColorfullString(source, ConsoleColor.Magenta);
        }

        public static ColorfullString Red(this string source)
        {
            return new ColorfullString(source, ConsoleColor.Red);
        }

        public static ColorfullString White(this string source)
        {
            return new ColorfullString(source, ConsoleColor.White);
        }

        public static ColorfullString Yellow(this string source)
        {
            return new ColorfullString(source, ConsoleColor.Yellow);
        }
    }
}