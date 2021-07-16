using System;

namespace GitHubApplicatie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Naam: ");
            string naam = Console.ReadLine();
            Console.WriteLine("Geef leeftijd");
            int leeftijd = Convert.ToInt32(Console.ReadLine());
        }
    }
}
