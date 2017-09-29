using NUnit.Framework;

namespace Pipettor.Test
{
    [TestFixture]
    public class When_positive
    {
        [Test]
        public void Dividing_one_and_one()
        {
            PipetteDevice biomek = Setup_Test.SetupDevice(1);
            int[] result = biomek.CalculateMoveset(1);
            int[] expected = new int[] { 1 };
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Dividing_positive_and_multiple()
        {
            PipetteDevice biomek = Setup_Test.SetupDevice(25);
            int[] result = biomek.CalculateMoveset(100);
            int[] expected = new int[] { 25, 25, 25, 25 };
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Dividing_positive_and_nonmultiple()
        {
            PipetteDevice biomek = Setup_Test.SetupDevice(40);
            int[] result = biomek.CalculateMoveset(100);
            int[] expected = new int[] { 33, 33, 34 };
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Dividing_small_and_larger()
        {
            PipetteDevice biomek = Setup_Test.SetupDevice(40);
            int[] result = biomek.CalculateMoveset(10);
            int[] expected = new int[] { 10 };
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Dividing_zero_and_positive()
        {
            PipetteDevice biomek = Setup_Test.SetupDevice(40);
            int[] result = biomek.CalculateMoveset(0);
            int[] expected = new int[] { 0 };
            Assert.AreEqual(expected, result);
        }

        public void Dividing_negative_and_positive()
        {
            PipetteDevice biomek = Setup_Test.SetupDevice(40);
            int[] result = biomek.CalculateMoveset(-10);
            int[] expected = new int[] { 0 };
            Assert.AreEqual(expected, result);
        }
    }
}
