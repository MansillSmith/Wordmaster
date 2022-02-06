using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wordmaster
{
    public class Game
    {

        /// <summary>
        /// The word the player has to guess
        /// </summary>
        public string WordToGuess
        {
            get
            {
                return _wordToGuess;
            }
        }
        private string _wordToGuess = "";

        /// <summary>
        /// Sets the number of guesses the player is allowed to have at a given word.
        /// </summary>
        public int NumGuesses
        {
            get
            {
                return _numGuesses;
            }
        }
        private int _numGuesses = 5;


        public Game(int numGuesses)
        {
            this._numGuesses = numGuesses;
            this.constructor();
        }

        public Game()
        {
            this.constructor();
        }

        private void constructor()
        {
            this._wordToGuess = GetWordToGuess();
        }

        private string GetWordToGuess()
        {
            return "stand";
        }

        /// <summary>
        /// Processes a guess
        /// </summary>
        /// <param name="guessedWord">The guessed word</param>
        /// <returns>The result of the guess, or null if there are no guesses left</returns>
        public GuessResult Guess(string guessedWord)
        {
            if(_numGuesses > 0)
            {
                this._numGuesses--;
                return new GuessResult(guessedWord, WordToGuess);
            }
            else
            {
                return null;
            }

        }
    }
}
