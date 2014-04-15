/* Write a program that prints all possible cards from a standard deck of 52 cards (without jokers).
 * The cards should be printed with their English names. Use nested for loops and switch-case. */

using System;
using System.Text;

class AllCards
{
    static void Main()
    {
        StringBuilder allCards = new StringBuilder();

        for (int i = 2; i <= 14; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                switch (i)
                {
                    case 2: allCards.Append("Two"); break;
                    case 3: allCards.Append("Three"); break;
                    case 4: allCards.Append("Four"); break;
                    case 5: allCards.Append("Five"); break;
                    case 6: allCards.Append("Six"); break;
                    case 7: allCards.Append("Seven"); break;
                    case 8: allCards.Append("Eight"); break;
                    case 9: allCards.Append("Nine"); break;
                    case 10: allCards.Append("Ten"); break;
                    case 11: allCards.Append("Jack"); break;
                    case 12: allCards.Append("Queen"); break;
                    case 13: allCards.Append("King"); break;
                    case 14: allCards.Append("Ace"); break;
                    default: Console.WriteLine("Error in determining the type of card"); break;
                }
                switch (j)
                {
                    case 0: allCards.Append(" of Spades").Append(Environment.NewLine); break;
                    case 1: allCards.Append(" of Hearts").Append(Environment.NewLine); break;
                    case 2: allCards.Append(" of Diamonds").Append(Environment.NewLine); break;
                    case 3: allCards.Append(" of Clubs").Append(Environment.NewLine); break;
                    default: Console.WriteLine("Error in determining the color of card"); break;
                }
            }
        }

        Console.WriteLine(allCards);
    }
}
