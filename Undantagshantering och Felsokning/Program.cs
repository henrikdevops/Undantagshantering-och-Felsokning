using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Undantagshantering_Felsokning
{
    internal class Program
    {
        
        static void Main(string[] args)
        {

            // Skapar en slumpgenerator för att generera ett slumpmässigt tal mellan 1 och 20
            Random slumpat = new Random();

            // Genererar ett slumpmässigt tal som spelaren ska gissa
            int speltal = slumpat.Next(1, 20);
            Console.WriteLine("\n\tVälkommen till gissningsspelet: Felgissat tal ger dig kanske BLUESCREEEN!");

            // Variabel för att hålla koll på om spelet ska fortsätta
            bool spela = true;

            // Huvudspel-loop
            while (spela)

            // Fråga spelaren att gissa ett tal
            {
                Console.Write("\tGissa på ett tal mellan 1 och 20: ");
                string input = Console.ReadLine();

                // Försök parsa input till ett heltal
                bool success = Int32.TryParse(input, out int tal);


                // Om parsningen lyckas, fortsätt med spelet
                if (!success)
                {
                    // Om parsningen misslyckas, skriv ut ett felmeddelande och fortsätt loopen
                    Console.WriteLine("\tDu måste skriva in ett heltal.");

                    continue; // Hoppar till nästa iteration av loopen
                }

                // Kontrollera om talet är inom det giltiga intervallet
                if (tal < speltal)
                {
                    Console.WriteLine("\n\tDet inmatade talet " + tal + " är för litet, försök igen.");
                }

                // Om talet är större än det slumpade talet
                else if (tal > speltal)
                {
                    Console.WriteLine("\tDet inmatade talet " + tal + " är för stort, försök igen.");
                }

                // Om talet är lika med det slumpade talet avsluta spelet
                else 
                {
                    Console.WriteLine("\tGrattis, du gissade rätt!");
                    spela = false;
                }
            }
        }
    }
}
