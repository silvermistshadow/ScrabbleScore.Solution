using System;

namespace Scrabble
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("This program takes a word or letter and displays the score that the letters add up to.");
            Console.WriteLine("Please enter a letter or word:");
            Score.Score newScore = new Score.Score(Console.ReadLine());
            Console.WriteLine($"The score is: {newScore.getScore(newScore.word).ToString()}");
        }
    }
}