using System;

namespace Uppgift_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random slumpat = new Random();
            int speltal = slumpat.Next(1, 20);
            Console.WriteLine("\n\tVälkommen till gissningsspelet: Felgissat tal ger dig kanske BLUESCREEEN!");

            bool spela = true;

            while (spela)
            {
                Console.Write("\tGissa på ett tal mellan 1 och 20: ");
                string input = Console.ReadLine();

                // Försök parsa input till ett heltal
                bool success = Int32.TryParse(input, out int tal);

                if (!success)
                {
                    Console.WriteLine("\tDu måste skriva in ett heltal.");
                    continue; // Hoppar till nästa iteration av loopen
                }

                if (tal < speltal)
                {
                    Console.WriteLine("\n\tDet inmatade talet " + tal + " är för litet, försök igen.");
                }
                else if (tal > speltal)
                {
                    Console.WriteLine("\tDet inmatade talet " + tal + " är för stort, försök igen.");
                }
                else // tal == speltal
                {
                    Console.WriteLine("\tGrattis, du gissade rätt!");
                    spela = false;
                }
            }
        }
    }
}
