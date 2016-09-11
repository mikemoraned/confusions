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
            Console.WriteLine("creating strings");
            var strings = SomeStrings(3);
            Console.WriteLine("doing first iter");
            foreach(var s in strings) {
                Console.WriteLine(s);
            }
            Console.WriteLine("doing second iter");
            foreach(var s in strings) {
                Console.WriteLine(s);
            }
            Console.WriteLine("done");
        }
    }
}
