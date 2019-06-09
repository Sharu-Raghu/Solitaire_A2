using System;

namespace Card1 
{
    /// <summary>
	/// enumeration that represents face values
	/// </summary>
	public enum Face
    {
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten = 10,
        Jack = 11,
        Queen = 12,
        King = 13,
        Ace = 14

    }
    /// <summary>
	/// enumeration that represents Back values
	/// </summary>
    public enum Back
    {
        XX = 0,  // Back 
        YY = 1   // Face
    }
    /// <summary>
    /// enumeration that represents suit values
    /// </summary>
    public enum Suit
    {
        Clubs = 0,
        Diamonds = 1,
        Hearts = 2,
        Spades = 3
    }
    public class Card : System.Windows.Forms.UserControl.Button
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;
        private Face face;
        private Suit suit;
        private Back back;       
        private bool showback;
        private PictureBox pictureBox;

        public Card(Face face, Suit suit, Back back,  bool showback, Image image)
        {
            // This call is required by the Windows.Forms Form Designer.
            InitializeComponent();

            // TODO: Add any initialization after the InitForm call           
            
            this.face = face;
            this.suit = suit;
            this.back = back;            
            this.showback = showback;
            pictureBox = new PictureBox();
            pictureBox.Image = image;

            this.Invalidate();
        }
        public class Deck
        {
            public Card Draw()
            {
                //Get the next available card
                if (_availableCards.Count > 0)
                    return_availabeCards.Pop();

                return null;

            }
            public void Shuffle()
            {
                //generate the master list of cards in random order
                // Store in _availableCards

            }
            private StackOverflowException<Card> _availableCards;
        }
    }
}
