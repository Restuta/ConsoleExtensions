using System;
using System.Collections.Generic;
using System.Linq;

namespace Restuta.ConsoleExtensions.Colorfull
{
    public class ColorfullString
    {
        private static readonly Queue<ColorfullString> StringsQueue = new Queue<ColorfullString>();
        private ConsoleColor? color;

        public ColorfullString(string value, ConsoleColor consoleColor = ConsoleColor.Gray)
        {
            Value = value;
            color = consoleColor;

            if (!StringsQueue.Any())
            {
                StringsQueue.Enqueue(this);
            }
        }

        public string Value { get; private set; }

        //ColorfullString to string
        public static implicit operator string(ColorfullString colorfullString)
        {
            return colorfullString.Value;
        }

        //string to ColorfullString 
        public static implicit operator ColorfullString(string @string)
        {
            var colorfullString = new ColorfullString(@string);
            //stringsQueue.Enqueue(colorfullString);
            return colorfullString;
        }

        public static ColorfullString operator +(ColorfullString a, ColorfullString b)
        {
            if (!StringsQueue.Any())
            {
                StringsQueue.Enqueue(a);
            }
            
            StringsQueue.Enqueue(b);

            return a;
        }

        public ColorfullString Red()
        {
            color = ConsoleColor.Red;
            return this;
        }

        public override string ToString()
        {
            return this;
        }

        public static void WriteToConsole()
        {
            while(StringsQueue.Any())
            {
                var colorfullString = StringsQueue.Dequeue();

                var currentColor = Console.ForegroundColor;
                Console.ForegroundColor = colorfullString.color ?? currentColor;
                Console.Write(colorfullString.Value);
                Console.ForegroundColor = currentColor;
            }
        }
    }
}