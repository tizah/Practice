using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class DeckGame
    {
        public static void StandardDeckGame()
        {
            List<string> decks = new List<string>
            {
                "A",
                "2",
                "3",
                "4",
                "5",
                "6",
                "7",
                "8",
                "9",
                "10",
                "J",
                "K",
                "Q"
            };

            Dictionary<string, List<string>> mydecks = new Dictionary<string, List<string>>();
             
            mydecks.Add("Hearts", decks);
            mydecks.Add("Diamonds", decks);
            mydecks.Add("Spades", decks);
            mydecks.Add("Clubs", decks);

            mydecks.ToDictionary(x => x, x=> string.Format("Val: {0}", x));
            foreach (var mydeck in mydecks)
            {
                foreach (var deckValue in mydeck.Value)
                {
                    Console.WriteLine($" { mydeck} and values are {deckValue}");
                }
               
            }
        }
    }
}
