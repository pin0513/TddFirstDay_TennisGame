using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TennisGameTests20180810
{
    [TestClass]
    public class TennisGameTests
    {
        private readonly Tennis _tennis = new Tennis("Joey", "Tom");

        [TestMethod]
        public void Love_All()
        {
            ScoreShouldBe("Love All");
        }

        [TestMethod]
        public void Fifteen_Love()
        {
            _tennis.FirstPlayerScore();
            ScoreShouldBe("Fifteen Love");
        }

        [TestMethod]
        public void Thirty_Love()
        {
            FirstPlayerScoreTimes(2);
            ScoreShouldBe("Thirty Love");
        }

        [TestMethod]
        public void Forty_Love()
        {
            FirstPlayerScoreTimes(3);
            ScoreShouldBe("Forty Love");
        }

        [TestMethod]
        public void Love_Fifteen()
        {
            _tennis.SecondPlayerScore();
            ScoreShouldBe("Love Fifteen");
        }

        [TestMethod]
        public void Love_Thirty()
        {
            SecondPlayerScoreTimes(2);
            ScoreShouldBe("Love Thirty");
        }

        [TestMethod]
        public void Fifteen_All()
        {
            FirstPlayerScoreTimes(1);
            SecondPlayerScoreTimes(1);
            ScoreShouldBe("Fifteen All");
        }

        [TestMethod]
        public void Thirty_All()
        {
            FirstPlayerScoreTimes(2);
            SecondPlayerScoreTimes(2);
            ScoreShouldBe("Thirty All");
        }

        [TestMethod]
        public void Deuce()
        {
            FirstPlayerScoreTimes(3);
            SecondPlayerScoreTimes(3);
            ScoreShouldBe("Deuce");
        }

        [TestMethod]
        public void Joey_Adv()
        {
            FirstPlayerScoreTimes(4);
            SecondPlayerScoreTimes(3);
            ScoreShouldBe("Joey Adv");
        }

        [TestMethod]
        public void Tom_Adv()
        {
            FirstPlayerScoreTimes(3);
            SecondPlayerScoreTimes(4);
            ScoreShouldBe("Tom Adv");
        }

        [TestMethod]
        public void Deuce4_4()
        {
            FirstPlayerScoreTimes(4);
            SecondPlayerScoreTimes(4);
            ScoreShouldBe("Deuce");
        }

        [TestMethod]
        public void Joey_Win()
        {
            FirstPlayerScoreTimes(5);
            SecondPlayerScoreTimes(3);
            ScoreShouldBe("Joey Win");
        }

        [TestMethod]
        public void Joey_Win_4_0()
        {
            FirstPlayerScoreTimes(4);
            SecondPlayerScoreTimes(0);
            ScoreShouldBe("Joey Win");
        }

        private void SecondPlayerScoreTimes(int times)
        {
            for (int i = 0; i < times; i++)
            {
                _tennis.SecondPlayerScore();
            }
        }

        private void FirstPlayerScoreTimes(int times)
        {
            for (int i = 0; i < times; i++)
            {
                _tennis.FirstPlayerScore();
            }
        }

        private void ScoreShouldBe(string expected)
        {
            var score = _tennis.Score();
            Assert.AreEqual(expected, score);
        }
    }
}