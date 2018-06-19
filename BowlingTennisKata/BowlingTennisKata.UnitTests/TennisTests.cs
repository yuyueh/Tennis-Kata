using NUnit.Framework;

namespace Tennis.UnitTests
{
    [TestFixture]
    public class TennisTests
    {
        private Tennis _target;

        [SetUp]
        public void SetUp()
        {
            _target = new Tennis();
        }

        [Test]
        public void Test_LoveAll()
        {
            // Arrange
            var expected = "Love-All";

            // Act
            var result = _target.Score();

            // Assert
            Assert.AreEqual(result, expected);
        }

        [Test]
        public void Test_FifteenLove()
        {
            // Arrange
            var expected = "Fifteen-Love";

            // Act
            _target.SetFirstPlayerScore(1);
            var result = _target.Score();

            // Assert
            Assert.AreEqual(result, expected);
        }

        [Test]
        public void Test_ThirtyLove()
        {
            // Arrange
            var expected = "Thirty-Love";

            // Act
            _target.SetFirstPlayerScore(2);
            var result = _target.Score();

            // Assert
            Assert.AreEqual(result, expected);
        }

        [Test]
        public void Test_FortyLove()
        {
            // Arrange
            var expected = "Forty-Love";

            // Act
            _target.SetFirstPlayerScore(3);
            var result = _target.Score();

            // Assert
            Assert.AreEqual(result, expected);
        }
    }
}
