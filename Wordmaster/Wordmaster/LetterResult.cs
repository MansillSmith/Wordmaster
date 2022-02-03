using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wordmaster
{
    public class LetterResult
    {
        public enum LetterResultEnum
        {
            Incorrect, Correct_WrongPosition, Correct
        }

        private char _letter;
        public char Letter
        {
            get { return _letter; }
            set { _letter = value; }
        }

        private LetterResultEnum _letterResultEnum;
        public LetterResultEnum LetterResultEnumValue
        {
            get { return _letterResultEnum; }
            set { _letterResultEnum = value; }
        }

        public override bool Equals(object obj)
        {
            if(obj is LetterResult)
            {
                LetterResult tempLR = (LetterResult)obj;
                return this.Letter.Equals(tempLR.Letter) && this.LetterResultEnumValue.Equals(tempLR.LetterResultEnumValue);
            }
            return false;
        }

        public override string ToString()
        {
            return "[" + this.Letter.ToString() + "," + LetterResultEnumValue.ToString() + "]";
        }
    }
}
