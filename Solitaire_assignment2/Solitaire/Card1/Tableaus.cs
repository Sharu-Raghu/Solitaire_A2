using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card1
{
    public class Tableaus
    {
        public Tableau tableau1;
        public Tableau tableau2;
        public Tableau tableau3;
        public Tableau tableau4;
        public Tableau tableau5;
        public Tableau tableau6;
        public Tableau tableau7;

        public Tableaus(Cards cards)
        {
            Card tableau1card1 = cards.GetRandomCard();
            Card[] tableau1cards = { tableau1card1 };
            Tableau tableau1 = new Tableau(tableau1cards);

            //Card tableau2card1 = cards.GetRandomCard();
            //Card tableau2card2 = cards.GetRandomCard();
            //Card[] tableau2cards = { tableau2card1, tableau2card2 };
            //Tableau tableau2 = new Tableau(tableau2cards);

            //Tableau tableau3 = new Tableau(tableau2cards);
            //Tableau tableau4 = new Tableau(tableau2cards);
            //Tableau tableau5 = new Tableau(tableau2cards);
            //Tableau tableau6 = new Tableau(tableau2cards);
            //Tableau tableau7 = new Tableau(tableau2cards);
        }
    }
    namespace SolitaireTest
    {
        public class Tableau
        {
            List<Card> cards;

            public Tableau(System.Windows.Forms.Form form)
            {
                cards = new List<Card>();
                cards.Add(new Card(form));
               
            }
        }

    }
}

