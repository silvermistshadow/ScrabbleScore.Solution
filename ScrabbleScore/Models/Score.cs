using System;
using System.Collections.Generic;
using System.Linq;
namespace Scrabble.Score
{
    public class Score
    {
        public Dictionary<char, int> scoreDict = new Dictionary<char, int>() 
        { 
            {'a', 1},{'e', 1},{'i', 1},{'o', 1},{'u', 1},{'l', 1},{'n', 1},{'r', 1},{'s', 1},{'t', 1},{'d', 2},{'g', 2},{'b', 3},{'c', 3},{'m', 3},{'p', 3},{'f', 4},{'h', 4},{'v', 4},{'w', 4},{'y', 4},{'k', 5},{'j', 8},{'x', 8},{'q', 10},{'z', 10}
        };
        public int score { get; set; } = 0;

        public string word { get; set; } = "";

        public char letter { get; set; } = ' ';

        public Score(string input)
        {
            word = input.ToLower();
            word = RemoveNonLetter(word);
            int Score = score;
        }
        public Score(char input)
        {   
            letter = Char.ToLower(input);
            int Score = score;
        }

        public int getScore(string input)
        {   int total = 0;
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

        public string RemoveNonLetter(string input)
        {
            return new string(input.ToCharArray()
            .Where(c => char.IsLetter(c))
            .ToArray());
        }
    }
}