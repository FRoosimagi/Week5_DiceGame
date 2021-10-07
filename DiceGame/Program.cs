using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //mängus osaleb 2 mängijat - arvuti (cpu) ja kasutaja (user)
            //mõlemad mängijad viskavad täringut
            //programm kontrollib kumb mängija viskas rohkem
            //mängija kes viskab rohkem on võitja
            //* täringuid visatakse 3 korda
            //programm kuulutab võitja

            

            int cpuScore = 0;
            int userScore = 0;               
            
            for(int i=0; i < 3; i++)
            {
                Random rnd = new Random();
                
                int cpuRandom = rnd.Next(1, 7);
                int userRandom = rnd.Next(1, 7);
                
                Console.WriteLine($"Vise {i + 1}");
                Console.WriteLine($"Arvuti viskas {cpuRandom}. Kasutaja viskas {userRandom}");
                
                if (cpuRandom < userRandom)
                {
                    userScore++;
                    Console.WriteLine($"Viske on võitnud kasutaja. Mängu seis kasutaja: {userScore}, arvuti: {cpuScore}");
                }
                else if(cpuRandom > userRandom)
                {
                    cpuScore++;
                    Console.WriteLine($"Viske on võitnud arvuti. Mängu seis kasutaja: {userScore}, arvuti: {cpuScore}");
                }
                else
                {
                    Console.WriteLine($"Viik! Mängu seis kasutaja: {userScore}, arvuti: {cpuScore}");
                }
            }

            Console.WriteLine("Game Over");
            Console.WriteLine($"Lõpptulemus, kasutaja: {userScore}, arvuti: {cpuScore}");
            
            if (cpuScore < userScore)
            {
                 Console.WriteLine("Kasutaja on mängu võitnud.");
            }
            else if (cpuScore > userScore)
            {
                Console.WriteLine("Arvuti on mängu võitnud.");
            }
            else
            {
                Console.WriteLine("Viik!");
            }
            
        }
    }
}
