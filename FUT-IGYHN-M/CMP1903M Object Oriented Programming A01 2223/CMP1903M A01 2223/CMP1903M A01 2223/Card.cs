using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CMP1903M_A01_2223
{
    public class Card
    {
        // Properties
        public int Value { get; set; }
        public int Suit { get; set; }

        // Constructor
        public Card(int value, int suit)
        {
            // Validate value
            if (value < 1 || value > 13)
            {
                throw new ArgumentException("Invalid card value");
            }

            // Validate suit
            if (suit < 1 || suit > 4)
            {
                throw new ArgumentException("Invalid card suit");
            }

            this.Value = value;
            this.Suit = suit;
        }

        // Methods
        public override string ToString()
        {
            string valueString = "";
            switch (this.Value)
            {
                case 1:
                    valueString = "Ace";
                    break;
                case 11:
                    valueString = "Jack";
                    break;
                case 12:
                    valueString = "Queen";
                    break;
                case 13:
                    valueString = "King";
                    break;
                default:
                    valueString = this.Value.ToString();
                    break;
            }

            string suitString = "";
            switch (this.Suit)
            {
                case 1:
                    suitString = "Hearts";
                    break;
                case 2:
                    suitString = "Diamonds";
                    break;
                case 3:
                    suitString = "Clubs";
                    break;
                case 4:
                    suitString = "Spades";
                    break;
            }

            return string.Format("{0} of {1}", valueString, suitString);
        }
    }
}