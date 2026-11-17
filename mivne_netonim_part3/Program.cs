using System.Runtime.InteropServices;

namespace mivne_netonim_part3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //targil1();
            //targil2();
            targil3();
        }

        static void targil1()
        {
            int[] votes = new int[11];

            Console.WriteLine("Enter favorite song (1-10, or 0 to finish):");
            int grade = int.Parse(Console.ReadLine());
            while (grade != 0)
            {
                if (grade >= 1 && grade <= 10)
                {
                    votes[grade]++;
                }
                else
                {
                    Console.WriteLine("Invalid song number. Please enter a number between 1 and 10.");
                }

                Console.WriteLine("Enter favorite song:");
                grade = int.Parse(Console.ReadLine());
            }
            int[] songNumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for (int i = 0; i < songNumbers.Length - 1; i++)
            {
                for (int j = 0; j < songNumbers.Length - i - 1; j++)
                {
                    if (votes[songNumbers[j]] < votes[songNumbers[j + 1]])
                    { 
                        int temp = songNumbers[j];
                        songNumbers[j] = songNumbers[j + 1];
                        songNumbers[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("\n--- Song Rankings ---");
            for (int i = 0; i < songNumbers.Length; i++)
            {
                int currentSong = songNumbers[i];
                Console.WriteLine($"Song {currentSong} got {votes[currentSong]} votes");
            }
        }

        static void targil2()
        {
            int[] Workers = new int[7];
            int minWorkers = int.MaxValue;
            int minFloor = 0; 
            for (int i = 0; i < Workers.Length; i++)
            {
                Console.WriteLine($"Enter the number of workers on floor {i + 1}:");
                Workers[i] = int.Parse(Console.ReadLine());

                if (Workers[i] < minWorkers)
                {
                    minWorkers = Workers[i];
                    minFloor = i + 1; 
                }
            }

            Console.WriteLine();

            for (int i = 0; i < Workers.Length; i++)
            {
                Console.WriteLine($"Floor {i + 1} has {Workers[i]} workers.");
            }

            Console.WriteLine();
            Console.WriteLine($"The floor with the fewest workers is floor {minFloor} with {minWorkers} workers.");
        }

        static void targil3()
        {
            int[] scores = new int[51];
            for (int judge = 1; judge <= 10; judge++)
            {
                Console.WriteLine($"Judge {judge} - Enter 3 grades:");
                string[] input = Console.ReadLine().Split(' ');
                int third = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());
                int first = int.Parse(Console.ReadLine());
                scores[third] += 1;
                scores[second] += 2;
                scores[first] += 3;
            }
            int[] tempScores = (int[])scores.Clone();
            Console.WriteLine("top 3");
            for (int place = 1; place <= 3; place++)
            {
                int maxScore = -1;
                int bestContestant = -1;
                for (int i = 1; i <= 50; i++)
                {
                    if (tempScores[i] > maxScore)
                    {
                        maxScore = tempScores[i];
                        bestContestant = i;
                    }
                }
                Console.WriteLine($"Place {place}: Contestant number {bestContestant} with {maxScore} points");
                tempScores[bestContestant] = -1;
            }
        

        }




    }
}
