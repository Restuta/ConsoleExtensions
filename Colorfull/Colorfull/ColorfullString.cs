using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.Concurrent;
using System.Threading;

namespace Restuta.ConsoleExtensions.Colorfull
{
    public class ColorfullString
    {
        private ConsoleColor? color;

        private static readonly ConcurrentDictionary<int, Queue<ColorfullString>> PerThreadQueues =
            new ConcurrentDictionary<int, Queue<ColorfullString>>();

        private static Queue<ColorfullString> StringsQueue { get { return GetThreadSpecificQueue(); } }
        private string Value { get; set; }

        public ColorfullString(string value, ConsoleColor consoleColor = ConsoleColor.Gray)
        {
            Value = value;
            color = consoleColor;

            if (!StringsQueue.Any())
            {
                StringsQueue.Enqueue(this);
            }
        }

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
            while (StringsQueue.Any())
            {
                var colorfullString = StringsQueue.Dequeue();

                var currentColor = Console.ForegroundColor;
                Console.ForegroundColor = colorfullString.color ?? currentColor;
                Console.Write(colorfullString.Value);
                Console.ForegroundColor = currentColor;
            }
        }

        private static Queue<ColorfullString> GetThreadSpecificQueue()
        {
            Queue<ColorfullString> queue;
            if (!PerThreadQueues.TryGetValue(Thread.CurrentThread.ManagedThreadId, out queue))
            {
                queue = CreateQueueForCurrentThread();
            }

            return queue;
        }

        private static Queue<ColorfullString> CreateQueueForCurrentThread()
        {
            Queue<ColorfullString> colorfullStrings = new Queue<ColorfullString>();
            PerThreadQueues[Thread.CurrentThread.ManagedThreadId] = colorfullStrings;

            return colorfullStrings;
        }
    }
}