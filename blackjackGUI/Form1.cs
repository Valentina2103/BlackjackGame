using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using clases.Objects; 
using clases.GestorJuego;
using clases.Persona;

namespace blackjackGUI
{
    public partial class Blackjack : Form
    {
        public Player player;
        public Gestor gt;
        private static int startXPos = -10;
        private static int startDealerXPos = 285;
        private int cardPLayerXPos = startXPos;
        private int cardDealerXPos = startDealerXPos;
        public List<PictureBox> playerCardsToDisplay;
        public List<PictureBox> dealerCards;
        private static int victoryCounter = 0;
        private static int looseCouter = 0;


        public Blackjack()
        {
            InitializeComponent();
            gt = new Gestor();
            player = new Player();
            gt.AddPlayer(player);
            playerCardsToDisplay = new List<PictureBox>();
            dealerCards = new List<PictureBox>();

            splitButton.Hide();
        }

        private void DrawPlayerCards(Card card)
        {
            cardPLayerXPos += 30;
            PictureBox newCard = new PictureBox();
            Image img = Image.FromFile("../../card_images/" + card.Symbol + card.Suit + ".png");
            newCard.Image = img;
            newCard.Location = new System.Drawing.Point(cardPLayerXPos, 180);
            newCard.Name = "nuevacarta";
            newCard.Size = new System.Drawing.Size(72, 99);
            this.Controls.Add(newCard);
            newCard.BringToFront();
            playerCardsToDisplay.Add(newCard);
        }

        private void NotCardDealerShow(Card carta)
        {

            cardDealerXPos -= 30;
            PictureBox blankCarta = new PictureBox();
            Image blankImage = Image.FromFile("../../card_images/b1fv.png");
            blankCarta.Image = blankImage;
            blankCarta.Location = new System.Drawing.Point(cardDealerXPos, 180);
            blankCarta.Name = "nuevacarta";
            blankCarta.Size = new System.Drawing.Size(72, 99);
            this.Controls.Add(blankCarta);
            blankCarta.BringToFront();
            dealerCards.Add(blankCarta);

            DrawDealer(carta);

        }

        private void DrawDealer(Card carta)
        {
            cardDealerXPos -= 30;
            PictureBox NuevaCarta = new PictureBox();
            Image img = Image.FromFile("../../card_images/" + carta.Symbol + carta.Suit + ".png");
            NuevaCarta.Image = img;
            NuevaCarta.Location = new System.Drawing.Point(cardDealerXPos, 180);
            NuevaCarta.Name = "newCard";
            NuevaCarta.Size = new System.Drawing.Size(72, 99);
            this.Controls.Add(NuevaCarta);
            dealerCards.Add(NuevaCarta);
        }

        private void standButton_Click(object sender, EventArgs e)
        {
            dealerScore.Text = "Dealer score: " + gt.GetDealerPuntuation();
            cardDealerXPos = startDealerXPos;
            RemoveCards(dealerCards);
            DrawDealer(gt.GetCardDealer()[1]);
            DrawDealer(gt.GetCardDealer()[0]);

            while (gt.GetDealerPuntuation() < player.GetPuntuation())
            {
                gt.GiveDealerCard();
                dealerScore.Text = "Puntuación crupier: " + gt.GetDealerPuntuation();
                DrawDealer(gt.LastCardDealer);
            }

            if (gt.GetDealerPuntuation() >= player.GetPuntuation() && gt.GetDealerPuntuation() < 22)
            {
                resultLabel.Text = "Dealer gana!";
                looseCouter += 1;
                loseLabel.Text = "Derrotas: " + looseCouter;
            }
            else
            {
                resultLabel.Text = "Player gana!";
                victoryCounter += 1;
                victoryLabel.Text = "Victorias: " + victoryCounter;
            }

        }

        private void hitMeButton_Click(object sender, EventArgs e)
        {

            if (!player.Volar)
            {
                player.GiveCard(gt.InitialCards());
                playerScore.Text = "Score: " + player.GetPuntuation();
                DrawPlayerCards(player.LastCard());

                if (player.Volar)
                {
                    hitMeButton.Enabled = false;
                    standButton.Enabled = false;
                    splitButton.Enabled = false;
                    resultLabel.Text = "Dealer gana!";
                    looseCouter += 1;
                    loseLabel.Text = "Derrotas: " + looseCouter;
                }
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            resultLabel.Text = "";
            hitMeButton.Enabled = true;
            standButton.Enabled = true;
            RemoveCards(playerCardsToDisplay);
            RemoveCards(dealerCards);

            cardDealerXPos = startDealerXPos;
            cardPLayerXPos = startXPos;
            List<Card> cartasjugador = player.ShowHand();
            gt.NewGame();
            playerScore.Text = "Score: " + player.GetPuntuation();
            dealerScore.Text = "";
            DrawPlayerCards(cartasjugador[0]);
            DrawPlayerCards(cartasjugador[1]);
            NotCardDealerShow(gt.VisibleCardDealer);

            if (cartasjugador[0].Symbol == cartasjugador[1].Symbol)
            {
                splitButton.Enabled = true;
            }
            if (player.GetPuntuation() == 21)
            {
                resultLabel.Text = "Blackjack! Player gana!";
                hitMeButton.Enabled = false;
                standButton.Enabled = false;
                victoryCounter += 1;
                victoryLabel.Text = "Victorias: " + victoryCounter;
            }
        } 

        private void RemoveCards(List<PictureBox> imagenescarta)
        {
            foreach (PictureBox box in imagenescarta)
            {
                this.Controls.Remove(box);
            }
        }

        
        
        
    }
}

 