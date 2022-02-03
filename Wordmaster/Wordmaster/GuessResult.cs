using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wordmaster
{
    public class GuessResult
    {

        private bool _gameWon = false;
        public bool GameWon
        {
            get { return _gameWon; }
            set { _gameWon = value; }
        }


        private List<LetterResult> _letterResultList = new List<LetterResult>();
        public List<LetterResult> LetterResultList
        {
            get { return _letterResultList; }
            set { _letterResultList = value; }
        }

        /// <summary>
        /// Processes the guess into a GuessResult
        /// </summary>
        /// <param name="guessedWord">The word which was guessed</param>
        /// <param name="actualWord">The actual word to guess</param>
        public GuessResult(string guessedWord, string actualWord)
        {
            guessedWord = guessedWord.ToUpper();
            actualWord = actualWord.ToUpper();
            for(int i = 0; i < guessedWord.Length; i++)
            {
                LetterResult tempLR = new LetterResult() {Letter = guessedWord[i]};
                if(guessedWord[i] == actualWord[i])
                {
                    tempLR.LetterResultEnumValue = LetterResult.LetterResultEnum.Correct;
                }
                else if (actualWord.Contains(guessedWord[i]))
                {
                    tempLR.LetterResultEnumValue = LetterResult.LetterResultEnum.Correct_WrongPosition;
                }
                else
                {
                    tempLR.LetterResultEnumValue = LetterResult.LetterResultEnum.Incorrect;
                }

                _letterResultList.Add(tempLR);
            }
            SetGameWin();
        }

        public GuessResult(List<LetterResult> letterResults)
        {
            this._letterResultList = letterResults;
        }

        private void SetGameWin()
        {
            this.GameWon = true;
            for(int i = 0; i < LetterResultList.Count; i++)
            {
                if (!LetterResultList[i].LetterResultEnumValue.Equals(LetterResult.LetterResultEnum.Correct))
                {
                    this.GameWon = false;
                    return;
                }
            }
        }

        public override bool Equals(object obj)
        {
            if (obj is GuessResult)
            {
                GuessResult tempGR = (GuessResult)obj;
                if(this.LetterResultList.Count == tempGR.LetterResultList.Count)
                {
                    for(int i = 0; i < this.LetterResultList.Count; i++)
                    {
                        if (!this.LetterResultList[i].Equals(tempGR.LetterResultList[i]))
                        {
                            return false;
                        }
                    }
                    return true;
                }
                return false;
            }
            return false;
        }

        public override string ToString()
        {
            string returnString = "";

            for(int i = 0; i < LetterResultList.Count; i++)
            {
                returnString += LetterResultList[i].ToString() + ", ";
            }

            return returnString;
        }
    }
}
