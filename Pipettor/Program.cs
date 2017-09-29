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

            biomek.RequestCapacity();
            biomek.RequestVolume();
            int[] results = biomek.CalculateVolumes();

            Console.WriteLine("");
            foreach (int result in results)
            {
                Console.WriteLine(result);
            }
            Console.ReadLine();
        }
    }
}
