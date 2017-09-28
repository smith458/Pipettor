using NUnit.Framework;

namespace Pipettor.Test
{
    [TestFixture]
    public class When_positive
    {
        [Test]
        public void Dividing_one_and_one()
        {
            int[] result = Program.CalculateVolumes(1,1);
            int[] expected = new int[] { 1 };
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Dividing_positive_and_multiple()
        {
            int[] result = Program.CalculateVolumes(100, 25);
            int[] expected = new int[] { 25, 25, 25, 25 };
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Dividing_positive_and_nonmultiple()
        {
            int[] result = Program.CalculateVolumes(100, 40);
            int[] expected = new int[] { 33, 33, 34 };
            Assert.AreEqual(expected, result);
        }
    }
}
