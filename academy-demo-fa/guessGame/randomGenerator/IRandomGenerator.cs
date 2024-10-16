using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace academy_demo_fa.guessGame.randomGenerator
{
    public interface IRandomGenerator
    {
        public int GetRandomNumber();

        public bool IsAnswerCorrect(string userAnswer);

        public string LowerOrHigher(string userAnswer);
 
        public int CorrectAnswer { get; }

        public int Start {  get; }
        public int End { get; }
    }
}
