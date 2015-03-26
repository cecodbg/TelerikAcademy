using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isTrue = true;
            string stop = "Mew!";

            string[] inputLineCat = Console.ReadLine().Split(' ').ToArray();
            int[] cat = new int[int.Parse(inputLineCat[0])];

            string[] inputLineSongs = Console.ReadLine().Split(' ').ToArray();
            int[] songs = new int[int.Parse(inputLineSongs[0])];
            int songsi = 0;
            HashSet<int> result = new HashSet<int>();
            while (isTrue)
            {
                //Cat 2 knows song 2

                string[] inputCatSongs = Console.ReadLine().Split(' ').ToArray();
                if (inputCatSongs.Length < 2)
                {
                    break;
                }
                int cati = int.Parse(inputCatSongs[1]);

                songsi = int.Parse(inputCatSongs[4]);
                cat[cati - 1] = songsi;
                result.Add(songsi);

            }
            if (cat.Length < songsi)
            {
                Console.WriteLine("No concert!");
            }
            else
            {
                    
            Console.WriteLine(result.Count());
            }
        }
    }
}
