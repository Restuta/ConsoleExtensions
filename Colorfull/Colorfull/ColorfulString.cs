using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.Concurrent;
using System.Threading;

namespace Restuta.ConsoleExtensions.Colorfull
{
    public class ColorfulString
    {
        private ConsoleColor? color;

        private static readonly ConcurrentDictionary<int, Queue<ColorfulString>> PerThreadQueues =
            new ConcurrentDictionary<int, Queue<ColorfulString>>();

        private static Queue<ColorfulString> StringsQueue { get { return GetThreadSpecificQueue(); } }
        private string Value { get; set; }

        public ColorfulString(string value, ConsoleColor consoleColor = ConsoleColor.Gray)
        {
            Value = value;
            color = consoleColor;

            if (!StringsQueue.Any())
            {
                StringsQueue.Enqueue(this);
            }
        }

        //ColorfulString to string
        public static implicit operator string(ColorfulString colorfulString)
        {
            return colorfulString.Value;
        }

        //string to ColorfulString 
        public static implicit operator ColorfulString(string @string)
        {
            var colorfullString = new ColorfulString(@string);
            //stringsQueue.Enqueue(ColorfulString);
            return colorfullString;
        }

        public static ColorfulString operator +(ColorfulString a, ColorfulString b)
        {
            if (!StringsQueue.Any())
            {
                StringsQueue.Enqueue(a);
            }

            StringsQueue.Enqueue(b);

            return a;
        }

        public override string ToString()
        {
            return this;
        }

        public static void WriteToConsole()
        {
            while (StringsQueue.Any())
            {
                var colorfullString = StringsQueue.Dequeue();

                var currentColor = Console.ForegroundColor;
                Console.ForegroundColor = colorfullString.color ?? currentColor;
                Console.Write(colorfullString.Value);
                Console.ForegroundColor = currentColor;
            }
        }

        private static Queue<ColorfulString> GetThreadSpecificQueue()
        {
            Queue<ColorfulString> queue;
            if (!PerThreadQueues.TryGetValue(Thread.CurrentThread.ManagedThreadId, out queue))
            {
                queue = CreateQueueForCurrentThread();
            }

            return queue;
        }

        private static Queue<ColorfulString> CreateQueueForCurrentThread()
        {
            Queue<ColorfulString> colorfullStrings = new Queue<ColorfulString>();
            PerThreadQueues[Thread.CurrentThread.ManagedThreadId] = colorfullStrings;

            return colorfullStrings;
        }
    }
}