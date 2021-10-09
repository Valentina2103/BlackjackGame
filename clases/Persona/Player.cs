using System;
using clases.Objects;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases.Persona
{
    public class Player
    {
        private List<Card> hand = new List<Card>();
        private int puntuacion;

        public bool Volar { get; set; }

        public Player()
        {
            Volar = false;
        }

        public void GiveCard(Card CartasCrupier)
        {
            hand.Add(CartasCrupier);
        }

        public List<Card> ShowHand()
        {
            return hand;
        }
         
        public Card LastCard()
        {
            return hand[hand.Count - 1];
        }

        public int GetPuntuation()
        {
            puntuacion = 0;
            for (int i = 0; i < hand.Count; i++)
            {
                if ((int)hand[i].Symbol < 10)
                {
                    puntuacion += (int)hand[i].Symbol;
                }
                else
                {
                    puntuacion += 10;
                }
            }

            if (hand.Count == 2 && ((hand[0].Symbol == Symbol.Ace && (int)hand[1].Symbol >= 10) || (hand[1].Symbol == Symbol.Ace && (int)hand[0].Symbol >= 10)))
            {
                return 21;
            }

            if (puntuacion > 21)
            {
                Volar = true;
            }

            return puntuacion;
        }

        public void GiveDeal()
        {
            hand.Clear();
            Volar = false;
        }
    }
}







comm