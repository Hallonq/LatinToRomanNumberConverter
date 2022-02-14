using System;

namespace ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            // convert latin numbers to roman numbers.
            // unittests
            // strucuterd architecture
            int latin = int.Parse(args[0]);
            Console.WriteLine(latin);
            var converter = new Converters(latin);
            Console.WriteLine(converter.ConvertLatinNumberToRoman());
        }
    }
}