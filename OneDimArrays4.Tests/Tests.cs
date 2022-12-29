using NUnit.Framework;

namespace OneDimArrays4.Tests
{
    [TestFixture]
    public class Tests
    {
        [TestCase(new[] { -18, -10, -8, -6, -4, 3, 14 }, 0, 3)]
        [TestCase(new[] { -11, -1, 0, 2, 8, 16 }, 7, 8)]
        [TestCase(new[] { -12, 0, 2, 4, 6, 17, 20 }, 4, 6)]
        public void Task1_ReturnsCorrectValue(int[] array, int a, int expected)
        {
            var actual = Tasks.Task1(array, a);

            Assert.AreEqual(expected, actual, "Task1 returns incorrect value.");
        }

        [TestCase(new[] { -18, -10, -8, -6, -4, 3, 14 }, new[] { -18, -10, -6, -6, 0, 8, 20 })]
        [TestCase(new[] { -11, -1, 0, 2, 8, 16 }, new[] { -11, 0, 2, 2, 12, 16 })]
        [TestCase(new[] { -12, 0, 2, 4, 6, 17, 20 }, new[] { -12, 0, 4, 4, 10, 22, 26 })]
        [TestCase(new[] { 16, 20, 15, -27, 22 }, new[] { 16, 20, 15, -24, 26 })]
        public void Task2_ReturnsCorrectValue(int[] array, int[] expected)
        {
            var actual = Tasks.Task2(array);

            Assert.AreEqual(expected, actual, "Task2 returns incorrect value.");
        }

        [TestCase(new[] { -18, -10, -8, -6, -4, 3, 14 }, 0, new[] { 0, 0, 0, 0, 0, 6, 28 })]
        [TestCase(new[] { -11, -1, 0, 2, 8, 16 }, 7, new[] { 0, 0, 0, 0, 16, 32 })]
        [TestCase(new[] { -12, 0, 2, 4, 6, 17, 20 }, 4, new[] { 0, 0, 0, 0, 12, 34, 40 })]
        public void Task3_ReturnsCorrectValue(int[] array, int a, int[] expected)
        {
            var actual = Tasks.Task3(array, a);

            Assert.AreEqual(expected, actual, "Task3 returns incorrect value.");
        }
    }
}
