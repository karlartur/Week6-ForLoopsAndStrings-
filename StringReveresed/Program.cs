using System;

namespace StringReveresed
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab kasutajal sisestada eesnimi
            //programm kuvab eesnime tagurpidi
            Console.WriteLine("Sisesta eesnimi:");
            string firstName = Console.ReadLine();

            for (int i = firstName.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(firstName[i]);
            }
        }
    }
}
