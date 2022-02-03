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
            set
            {
                _numGuesses = value;
            }
        }
        private int _numGuesses = 0;

        public GuessResult Guess(string guessedWord)
        {
            return new GuessResult(guessedWord, WordToGuess);
        }
    }
}
