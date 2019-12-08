using System;

namespace exercise_15
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 64; i >= 0; i -= 4)
            {
                Console.WriteLine($"кроликов: {i / 4}  гусей: {(64 - i) / 2}");
            }
            Console.ReadLine();
        }
    }
}
