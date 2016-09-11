using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Program
    {
        private static int counter = 0;

        private static IEnumerable<string> SomeStrings(int length) {
            for(int i = 0; i < length; i++) {
                yield return Work(i);
            }
        }

        private static string Work(int i)
        {
            return string.Format("[{0}] doing work: {1}", counter++, i);
        }

        public static void Main(string[] args)
        {
            var strings = SomeStrings(10);
            foreach(var s in strings) {
                Console.WriteLine(s);
            }
            foreach(var s in strings) {
                Console.WriteLine(s);
            }
        }
    }
}
