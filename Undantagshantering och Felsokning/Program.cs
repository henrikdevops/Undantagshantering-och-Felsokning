
namespace Uppgift_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Deklaration av variabler
            Random slumpat = new Random(); // skapar ett random objekt
            int speltal = slumpat.Next(1, 20); // anropar Next metoden för att skapa ett slumptal mellan 1 och 20
            Console.WriteLine("\n\tVälkommen till gissningsspelet: Felgissat tal ger dig kanske BLUESCREEEN!"); // Skriver ut en välkomsttext
            bool spela = true; // Variabel för att kontrollera om spelet ska fortsätta köras

            while (spela) // Tog bort ! loopen dörå den inte behövs, vi vill att loopen ska fortsätta så länge användaren inte gissat rätt
            {
                Console.Write("\tGissa på ett tal mellan 1 och 20: ");
                Int32.TryParse(Console.ReadLine(), out int tal); // Använder TryParse för att undvika undantag vid felaktig inmatning
                //Om vi använder oss av en TryParse så kan vi undvika att programmet kraschar om användaren matar in något som inte är ett heltal.
                //Om vi använder oss av Convert.ToInt32() istället så kommer programmet att krascha om användaren matar in något som inte är ett heltal.

                if (tal < speltal)
                {
                    Console.WriteLine("\n\tDet inmatade talet " + tal + " är för litet, försök igen.");
                }

                if (tal > speltal)
                {
                    Console.WriteLine("\tDet inmatade talet " + tal + " är för stort, försök igen."); // + efter tal /Rödigerar felaktig syntax
                }

                if (tal == speltal)
                {
                    Console.WriteLine("\tGrattis, du gissade rätt!");
                    spela = true; //Programmet ska stängas av när talet är rätt gissat!
                }
            }
        }
    }
}
