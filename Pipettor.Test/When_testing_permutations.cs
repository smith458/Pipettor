using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pipettor.Test
{
    [TestFixture (100, 50)]
    [TestFixture (100, 3)]
    [TestFixture (100, 1000)]
    [TestFixture (100, 30)]
    [TestFixture (13143, 324)]
    [TestFixture (9999, 89)]
    [TestFixture (1000000, 43289)]
    public class When_testing_permutations
    {
        int _vol;
        int _cap;

        public When_testing_permutations(int vol, int cap)
        {
            _vol = vol;
            _cap = cap;
        }

        [Test]
        public void Dividing_lots_of_numbers()
        {
            PipetteDevice biomek = Setup_Test.SetupDevice(_vol, _cap);
            int[] result = biomek.CalculateVolumes();
            Assert.IsTrue((result.Max() - result.Min()) <= 1);
        }
    }  
}
