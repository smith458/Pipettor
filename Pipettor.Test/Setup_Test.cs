using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pipettor.Test
{
    public class Setup_Test
    {
        public static PipetteDevice SetupDevice(int cap)
        {
            PipetteDevice device = new PipetteDevice();
            device.Capacity = cap;
            return device;
        }
    }
}
