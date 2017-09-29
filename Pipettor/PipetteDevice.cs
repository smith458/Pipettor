using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pipettor
{
    public class PipetteDevice
    {
        public PipetteDevice()
        {

        }

        public void RequestVolume()
        {
            while (true)
            {
                Console.WriteLine("What is the volume to transfer?");
                result = int.TryParse(Console.ReadLine(), out volume);

                if (result && volume > 0)
                {
                    break;
                }
            }
        }

        public void RequestCapacity()
        {
            while (true)
            {
                Console.WriteLine("What is the capacity of the pipettor?");
                result = int.TryParse(Console.ReadLine(), out capacity);

                if (result && capacity > 0)
                {
                    break;
                }
            }
        }


        public int[] CalculateVolumes()
        {

            int moves = (int)Math.Ceiling((double)volume / capacity);
            int[] moveSet = new int[moves];

            int volLeft = volume;
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



        private int volume;
        private int capacity;
        private bool result;

        public int Volume
        {
            get { return volume; }
            set
            {
                if (value > 0)
                {
                    volume = value;
                }
            }
        }

        public int Capacity
        {
            get { return capacity; }
            set
            {
                if (value > 0)
                {
                    capacity = value;
                }
            }
        }
    }
}
