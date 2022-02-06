using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wordmaster;

namespace WordmasterConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();

            Console.WriteLine("Guess the 5 letter word");

            for(int i = 0; i < game.NumGuesses; i++)
            {
                GuessResult gr = game.Guess(Console.ReadLine());

                for(int j = 0; j < gr.LetterResultList.Count; j++)
                {
                    if(gr.LetterResultList[j].LetterResultEnumValue == LetterResult.LetterResultEnum.Correct)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else if(gr.LetterResultList[j].LetterResultEnumValue == LetterResult.LetterResultEnum.Correct_WrongPosition)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }

                    Console.Write(gr.LetterResultList[j].Letter);
                }
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine();

                if (gr.GameWon)
                {
                    Console.WriteLine("Congratulations, You Won!");
                    Console.ReadLine();
                    break;
                }
            }
        }
    }
}
