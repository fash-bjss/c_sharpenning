
using academy_demo_fa.guessGame.randomGenerator;
using academy_demo_fa.guessGame.screenClearers;
using academy_demo_fa.guessGame.writers;
using academy_demo_fa.guessGame.lives;
using academy_demo_fa.guessGame.readers;

namespace academy_demo_fa.guessGame
{
    public class Game
    {
        IOutputDisplay _outputWriter;
        IInputReader _inputReader;
        IScreenClearer _screenClearer;
        IRandomGenerator _randomGenerator;
        ILifeCounter _lifeCounter;
        private string userGuess;
        private int correctAnswer;

        public Game(
            IOutputDisplay writer, 
            IInputReader reader, 
            IScreenClearer clearer, 
            IRandomGenerator randGen, 
            ILifeCounter lifecounter
        )
        {
            _outputWriter = writer;
            _inputReader = reader;
            _screenClearer = clearer;
            _randomGenerator = randGen;
            _lifeCounter = lifecounter;
            this.correctAnswer = _randomGenerator.CorrectAnswer;
        }

        public bool StillPlaying()
        {
            return !_randomGenerator.IsAnswerCorrect(userGuess) && _lifeCounter.hasLives();
        }
        public bool CanProceed()
        {
            return !_randomGenerator.IsAnswerCorrect(userGuess) && _inputReader.IsValid();
        }

        public void ShowLives()
        {
            _outputWriter.Write($"You have {_lifeCounter.LivesLeft} chances left");
        }

        public void Run()
        {
            _screenClearer.ClearScreen();
            _outputWriter.Write("Start of game");
            _outputWriter.Write($"\nGuess a number between {_randomGenerator.Start} and {_randomGenerator.End}");


            while (StillPlaying())
            {
                _outputWriter.Write("\nEnter your guess: ");
                userGuess = _inputReader.Read();

                if (CanProceed())
                {
                    string lowerOrHigher = _lifeCounter.LivesLeft == 1 ? "" : _randomGenerator.LowerOrHigher(userGuess);
                    _outputWriter.Write($"You guessed { userGuess }. That's wrong! { lowerOrHigher.ToUpper() }");

                    _lifeCounter.DeductLife();
                }
                ShowLives();
            }
            string winOrLose = _randomGenerator.IsAnswerCorrect(userGuess) ? "You win" : "You lose";
            _outputWriter.Write($"The correct answer was { correctAnswer }. { winOrLose }!");

        }
    }
}
