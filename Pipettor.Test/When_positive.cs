using NUnit.Framework;

namespace Pipettor.Test
{
    [TestFixture]
    public class When_positive
    {
        [Test]
        public void Dividing_one_and_one()
        {
            PipetteDevice biomek = Setup_Test.SetupDevice(1, 1);
            int[] result = biomek.CalculateVolumes();
            int[] expected = new int[] { 1 };
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Dividing_positive_and_multiple()
        {
            PipetteDevice biomek = Setup_Test.SetupDevice(100, 25);
            int[] result = biomek.CalculateVolumes();
            int[] expected = new int[] { 25, 25, 25, 25 };
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Dividing_positive_and_nonmultiple()
        {
            PipetteDevice biomek = Setup_Test.SetupDevice(100, 40);
            int[] result = biomek.CalculateVolumes();
            int[] expected = new int[] { 33, 33, 34 };
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Dividing_small_and_larger()
        {
            PipetteDevice biomek = Setup_Test.SetupDevice(10, 40);
            int[] result = biomek.CalculateVolumes();
            int[] expected = new int[] { 10 };
            Assert.AreEqual(expected, result);
        }
    }
}
