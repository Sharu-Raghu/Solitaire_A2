using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Card1
{
    public class Tableau
    {
        public Stack<Card> cards;

        public Tableau(Card[] tableauCards)
        {
            cards = new Stack<Card>();

            foreach (var card in tableauCards)
            {
                // 103, 547
                card.Location = new Point(107, 547);
                card.Width = 200;
                card.Height = 275;
                cards.Push(card);
            }
        }

        public Tableau(MainForm mainForm)
        {
        }

        public bool DropCard(Card card, Tableau destinationTableau)
        {
            Card lastCard = destinationTableau.cards.Peek();

            // It should be colour not suit
            if (card.suit == lastCard.suit)
                return false;

            if (card.face != lastCard.face - 1)
                return false;

            destinationTableau.cards.Push(card);
            return true;
        }

        public bool DragCard(Tableau destinationTableau) // destination tableau
        {
            Card card = cards.Peek();
            if (DropCard(card, destinationTableau))
            {
                cards.Pop();
                return true;
            }

            return false;
        }
    }

}
