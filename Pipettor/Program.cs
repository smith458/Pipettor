using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pipettor
{
    public class Program
    {
        static void Main(string[] args)
        {
            int volume;
            int capacity;
            bool result;
            int[] moveSet;

            while (true)
            {
                Console.WriteLine("What is the volume to transfer?");
                result = int.TryParse(Console.ReadLine(), out volume);
                if (result && volume>0) { break; }
            }

            while (true)
            {
                Console.WriteLine("What is the capacity of the pipettor?");
                result = int.TryParse(Console.ReadLine(), out capacity);
                if (result && capacity>0) { break; }
            }

            moveSet = CalculateVolumes(volume, capacity);
            Console.WriteLine("");
            foreach (int move in moveSet)
            {
                Console.WriteLine(move);
            }
            Console.ReadLine();
        }

        public static int[] CalculateVolumes(int vol, int cap)
        {

            int moves = (int) Math.Ceiling( (double)vol / cap);
            int[] moveSet = new int[moves];

            int volLeft = vol;
            int movesLeft;

            for (int x = 0; x < moves; x++)
            {
                movesLeft = moves - x;
                if (movesLeft == 1)
                {
                    moveSet[x] = volLeft;
                }
                else
                {
                    moveSet[x] = volLeft / movesLeft;
                    volLeft -= moveSet[x];
                }
            }

            return moveSet;
        }
    }
}
