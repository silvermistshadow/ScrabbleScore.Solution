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

        [TestMethod]
        public void Score_GetScoreOfWord_ScoreOfWord()
        {
            //Arrange
            Score newScore = new Score("test");
            //Act
            int result = newScore.getScore(newScore.word);
            //Assert
            Assert.AreEqual(result, 4);
        }
    }
}