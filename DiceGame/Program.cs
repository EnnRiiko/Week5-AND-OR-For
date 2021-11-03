using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //mängus osaleb kaks mängijat - arvuti (cpu) ja kasutaja (user);
            //mõlemad mängijad vikavad täringuid;
            //programm kontrollib, kumb mängija viskab rohkem;
            //mängija, kes viskab rohkem on võitja;
            //*täringuid visatakse kolm korda;
            //programm kuulutab võitja.

            int cpuScore = 0;
            int userScore = 0;


            for (int i = 0; i < 3; i++)
            {

                Random rnd = new Random();

            int cpuRandom = rnd.Next(1, 7);
            int userRandom = rnd.Next(1, 7);

            

            
            

                Console.WriteLine($"Arvuti viskas {cpuRandom}. Kasutaja viskas {userRandom}.");

                if (cpuRandom < userRandom)
                {
                    Console.WriteLine("Kasutaja on raundi võitnud.");
                    userScore++;
                    Console.WriteLine($"Arvuti skoor on {cpuScore} ja kasutaja skoor on {userScore}");
                    Console.WriteLine();
                }
                else if (cpuRandom > userRandom)
                {
                    Console.WriteLine("Arvuti on raundi võitnud.");
                    cpuScore++;
                    Console.WriteLine($"Arvuti skoor on {cpuScore} ja kasutaja skoor on {userScore}");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Raund jäi viiki!");
                    Console.WriteLine($"Arvuti skoor on {cpuScore} ja kasutaja skoor on {userScore}");
                    Console.WriteLine();
                }

                
            }

            if (cpuScore < userScore)
            {
                Console.WriteLine("Kasutaja on mängu võitnud. Palju õnne!");
            }
            else if (cpuScore > userScore)
            {
                Console.WriteLine("Arvuti on mängu võitnud.");
                
            }
            else
            {
                Console.WriteLine("Mäng jäi viiki!");
            }
        }
    }
}
