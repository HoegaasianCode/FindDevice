using System;

namespace FindBomb
{
    class Program
    {
        // https://edabit.com/challenge/JYEufqRvkusjr5R58
        // SOLVED

        static void Main(string[] args)
        {
            var string1 = new FindBombString("The bomb is near");
            Console.Write(string1.Finder());
        }
    }
}
