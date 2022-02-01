using System;

namespace Terning_spill
{
    class Program
    {
        static void Main(string[] args)
        {
            int PlayerRandomNum;
            int EnemyRandomNum;

            int PlayerPoints = 0;
            int EnemyPoints = 0;

            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Trykk en tast for og rulleterning.");

                Console.ReadKey();

                PlayerRandomNum = random.Next(1, 7);
                Console.WriteLine("Du trillet " + PlayerRandomNum);

                Console.WriteLine("____");
                System.Threading.Thread.Sleep(2000);

                EnemyRandomNum = random.Next(1, 7);
                Console.WriteLine("Motstandern trillet " + EnemyRandomNum);

                if (PlayerRandomNum > EnemyRandomNum)
                {
                    PlayerPoints++;
                    Console.WriteLine("Du vant denne runden.");
                }
                else if (PlayerRandomNum < EnemyRandomNum)
                {
                    EnemyPoints++;
                    Console.WriteLine("Motstander vinner denne runden");
                }
                else
                {
                    Console.WriteLine("Uavgjort");
                }

                Console.WriteLine("Resultatet er nå - Deg : " + PlayerPoints + ". Motstander : " + EnemyPoints + ".");
                Console.WriteLine();
            }


            if (PlayerPoints > EnemyPoints)
            {
                Console.WriteLine("Du vinner");
            }
            else if (PlayerPoints < EnemyPoints)
            {
                Console.WriteLine("Motstander vinner");
            }
            else
            {
                Console.WriteLine("Det er uavgjort");
            }

            Console.ReadKey();
        }
    }
}







