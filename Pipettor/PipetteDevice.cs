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
            capacity = 100;
        }

        public int[] CalculateMoveset(int volume)
        {
            if (volume <= 0)
            {
                return new int[] { 0 };
            }

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

        private int capacity;

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
