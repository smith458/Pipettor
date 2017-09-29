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

            PipetteDevice biomek = new PipetteDevice();

            int capacity = RequestPosInt("What is the capacity of the pipettor?");
            biomek.Capacity = capacity;

            int volume = RequestPosInt("What is the volume to transfer?");
            int[] results = biomek.CalculateMoveset(volume);

            Console.WriteLine("");
            foreach (int result in results)
            {
                Console.WriteLine(result);
            }
            Console.ReadLine();
        }

        public static int RequestPosInt(string question)
        {
            int val;
            bool result;
            while (true)
            {
                Console.WriteLine(question);
                result = int.TryParse(Console.ReadLine(), out val);

                if (result && val > 0)
                {
                    break;
                }
            }

            return val;
        }

    }
}
