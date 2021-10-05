using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada tema eesnimi
            //programm kuvab kasutaja eesnime tähte
            //programm kuvab kasutaja eesnime viimast tähte

            Console.WriteLine("Sisestad oma eesnimi:");
            string firstName = Console.ReadLine();
            
            Console.WriteLine(firstName[0]);
            
            int firstNameLength = firstName.Length;
            Console.WriteLine($"Teie eesnimi on {firstNameLength} sümbolit pikk");
            
            // viimase tähe inteks = firstNameLength - 1
            Console.WriteLine(firstName[firstNameLength-1]);
        }
    }
}
