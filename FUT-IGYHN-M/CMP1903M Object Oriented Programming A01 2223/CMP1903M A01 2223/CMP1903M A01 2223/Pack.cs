using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CMP1903M_A01_2223
{
    public class Pack
    {
        public enum ShuffleType
        {
            FisherYates,
            Knuth
        }

        private List<Card> pack;

        public Pack()
        {
            //Initialise the card pack here
            pack = new List<Card>();
            for (int suit = 1; suit <= 4; suit++)
            {
                for (int value = 1; value <= 13; value++)
                {
                    pack.Add(new Card(value, suit));
                }
            }
        }

        public void ShuffleCardPack(ShuffleType shuffleType)
        {
            switch (shuffleType)
            {
                case ShuffleType.FisherYates:
                    for (int i = pack.Count - 1; i >= 1; i--)
                    {
                        int j = new Random().Next(i + 1);
                        Card temp = pack[j];
                        pack[j] = pack[i];
                        pack[i] = temp;
                    }
                    break;
                case ShuffleType.Knuth:
                    for (int i = 0; i < pack.Count; i++)
                    {
                        int j = new Random().Next(i, pack.Count);
                        Card temp = pack[i];
                        pack[i] = pack[j];
                        pack[j] = temp;
                    }
                    break;
                default:
                    throw new ArgumentException("Invalid shuffle type");
            }
        }

        public Card Deal()
        {
            if (pack.Count == 0)
            {
                throw new InvalidOperationException("No cards left in pack");
            }

            Card card = pack[0];
            pack.RemoveAt(0);
            return card;
        }

        public List<Card> DealCard(int amount)
        {
            List<Card> hand = new List<Card>();
            for (int i = 0; i < amount; i++)
            {
                hand.Add(Deal());
            }
            return hand;
        }
    }
}