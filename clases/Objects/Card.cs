using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace clases.Objects
{
    public struct Card
    {
        private Suit suit;
        private Symbol symbol;
        public Suit Suit
        {
            get
            {
                return this.suit;
            }
        }
        public Symbol Symbol
        {
            get
            {
                return this.symbol;
            }
        }
        public Card(Suit suit, Symbol symbol)
            : this()
        {
            this.suit = suit;
            this.symbol = symbol;
        }

        public override string ToString()
        {
            return string.Format("Suit: {0}, Symbol: {1}", this.suit, this.symbol);
        }
    }
}

