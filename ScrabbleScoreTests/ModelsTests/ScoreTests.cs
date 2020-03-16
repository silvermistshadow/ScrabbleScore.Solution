using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scrabble.Score;

namespace ScoreTests 
{
    [TestClass]
    public class ScoreTests
    {
        [TestMethod]
        public void Score_GetScoreOfSingleLetter_ScoreOfLetter()
        {
            //Arrange
            Score newScore = new Score('a');
            //Act
            int result = newScore.getScore(newScore.letter);
            //Assert
            Assert.AreEqual(result, 1);
        }
    }
}