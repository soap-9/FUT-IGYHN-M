using CMP1903M_A01_2223;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace CMP1903M_A01_2223
{
    public class Testing
    {
        public static void Main()
        {
            // Create a Pack object
            Pack pack = new Pack();

            // Shuffle the pack using Fisher Yates shuffle
            pack.ShuffleCardPack(Pack.ShuffleType.FisherYates);

            // Deal a single card
            Card card1 = pack.Deal();
            Console.WriteLine("Dealt card 1: {0}", card1);

            // Deal a hand of 5 cards
            List<Card> hand = pack.DealCard(5);
            Console.WriteLine("\nDealt hand of 5 cards:");
            foreach (Card card in hand)
            {
                Console.WriteLine(card);
            }

            // Shuffle the pack using Knuth shuffle
            pack.ShuffleCardPack(Pack.ShuffleType.Knuth);

            // Deal another single card
            Card card2 = pack.Deal();
            Console.WriteLine("\nDealt card 2: {0}", card2);
        }
    }
}