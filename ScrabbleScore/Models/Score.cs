using System.Collections.Generic;

namespace Scrabble.Score
{
    public class Score
    {
        public Dictionary<char, int> scoreDict = new Dictionary<char, int>() 
        { 
            {'a', 1},{'e', 1},{'i', 1},{'o', 1},{'u', 1},{'l', 1},{'n', 1},{'r', 1},{'s', 1},{'t', 1},{'d', 2},{'g', 2},{'b', 3},{'c', 3},{'m', 3},{'p', 3},{'f', 4},{'h', 4},{'v', 4},{'w', 4},{'y', 4},{'k', 5},{'j', 8},{'x', 8},{'q', 10},{'z', 10}
        };
        private int _Score { get; set; } = 0;
        public Score(string input)
        {

        }
        public Score(char input)
        {

        }

        public int getScore(string input)
        { int total = 0;
            foreach(char letter in input)
            {
                total += scoreDict[letter];
            }
            return total;
        }

        public int getScore(char input)
        {
            return scoreDict[input];
        }
    }
}