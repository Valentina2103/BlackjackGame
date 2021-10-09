using System;
using clases.Objects;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using clases.Persona;

namespace clases.GestorJuego
{
    public class Gestor
    {
        private Deck deck = new Deck();
        private List<Player> player = new List<Player>();
        private List<int> playerpuntuation = new List<int>();
        private Player dealer = new Player();
        public bool Juego { get; set; }

        public Card VisibleCardDealer
        {
            get
            {
                return dealer.ShowHand()[0];
            }
        }

        public Card LastCardDealer
        {
            get
            {
                return dealer.ShowHand()[dealer.ShowHand().Count - 1];
            }
        }

        public List<Card> GetCardDealer()
        {
            return dealer.ShowHand();
        }

        public Gestor()
        { 
            Juego = false;
        }

        public Gestor(Player jugador1)
        {
            player.Add(jugador1);
        }

        public void AddPlayer(Player newJugador)
        {
            player.Add(newJugador);
        }

        public void FirstTwoCards() 
        {
            deck.Randomize();

            dealer.GiveCard(deck.CardDeal());
            dealer.GiveCard(deck.CardDeal());

            for (int i = 0; i < player.Count; i++)
            {
                player[i].GiveCard(deck.CardDeal());
                player[i].GiveCard(deck.CardDeal());
            }
        }

        public Card InitialCards()
        {
            return deck.CardDeal();
        }

        public void NewGame()
        {
            deck = new Deck();
            for (int i = 0; i < player.Count; i++)
            {
                player[i].GiveDeal();
                dealer.GiveDeal();
            }
            FirstTwoCards();
        }

        private int GetPuntuationHand(List<Card> cartas)
        {
            int puntuacion = 0;
            for (int i = 0; i < cartas.Count; i++)
            {
                int valorcartas = (int)cartas[i].Symbol;
                if (valorcartas > 10)
                {
                    valorcartas = 10;
                }
                puntuacion += valorcartas;
            }

            if (puntuacion > 21)
            {
                puntuacion = -1;
            }

            if (cartas.Count == 2 && ((cartas[0].Symbol == Symbol.Ace && (int)cartas[1].Symbol >= 10) || (cartas[1].Symbol == Symbol.Ace && (int)cartas[0].Symbol >= 10)))
            {
                return 0;
            }

            return puntuacion;
        }

        public string ScreenPuntuation()
        {
            StringBuilder mostrarpunticion = new StringBuilder();
            for (int i = 0; i < player.Count; i++)
            {
                mostrarpunticion.AppendLine(String.Format("Player {0} score: {1}", i, playerpuntuation[i]));
            }
            return mostrarpunticion.ToString();
        }

        public void GiveDealerCard()
        {
            dealer.GiveCard(deck.CardDeal());
        }

        public int GetDealerPuntuation()
        {
            return dealer.GetPuntuation();
        }

    }
}


