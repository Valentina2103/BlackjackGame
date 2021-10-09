using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases.Objects
{
    public class Deck
    {
        Queue<Card> Baraja;

        List<int> Cardint;

        Random generador = new Random();

        private void GenerarCardint()
        {
            Cardint = new List<int>();
            for (int i = 0; i < 52; i++)
            {
                Cardint.Add(i);
            }
        }

        public void Randomize()
        {
            Baraja = new Queue<Card>();
            GenerarCardint();
            for (int i = 51; i >= 0; i--)
            {
                int index = generador.Next(0, i);
                int temp = Cardint[i];
                Cardint[i] = Cardint[index];
                Cardint[index] = temp;
            }
            DeckGame();
        }

        private void DeckGame()
        {
            for (int i = 0; i < Cardint.Count; i++)
            {
                Suit pinta = (Suit)(Cardint[i] % 4);
                Symbol valor = (Symbol)(Cardint[i] % 13 + 1);
                Baraja.Enqueue(new Card(pinta, valor));
            }
        }

        public Card CardDeal()
        {
            return Baraja.Dequeue();
        }
    }
}


