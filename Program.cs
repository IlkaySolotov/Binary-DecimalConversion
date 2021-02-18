using System;
using System.Data;
using System.Linq;

namespace Base2Convert
{
    class Program
    {
        static void Main()
        {
            while(true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Write the Base2 number below");
                Base2(Console.ReadLine());
            }
        }

        static string result { get; set; }
        static string steps { get; set; }

        static void Base2(string input)
        {
            for (int i = 0; i < input.Length; i++) steps += $"{input.Reverse().ToArray()[i]} * 2 ^ {i} + ";
            result = (input.Reverse().Select((c, i) => c is '1' ? int.Parse(c.ToString()) * 2 << i : 0).Sum() / 2).ToString();
            Print();
            return;
        }

        static void Print()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\n[Steps] {steps.Remove(steps.Length - 3)}");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"[Result] {result}\n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Press any <key> to continue");
            Console.ReadLine();
        }
    }
}
