using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace academy_demo_fa.guessGame.randomGenerator
{
    public class RandomNumberGenerator : IRandomGenerator
    {
        private int correctAnswer;
        private int start;
        private int end;

        public RandomNumberGenerator(int start, int end)
        {
            this.start = start;
            this.end = end;
            this.correctAnswer = GetRandomNumber();
            
        }

        public int CorrectAnswer => correctAnswer;

        public int Start => start;

        public int End => end;

        public int GetRandomNumber()
        {
            int randomNumber = new Random().Next(start, end);

            return randomNumber;
        }

        public bool IsAnswerCorrect(string userAnswer)
        {
            return userAnswer == this.correctAnswer.ToString();
        }

        public string LowerOrHigher(string userAnswer)
        {
            return int.Parse(userAnswer) > this.correctAnswer ? "try lower" : "try higher";

        }


    }
}
