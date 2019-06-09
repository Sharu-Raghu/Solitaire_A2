using System;
using System.Drawing;
using System.Windows.Forms;

namespace Card1 
{

    /// <summary>
    /// enumeration that represents face values
    /// </summary>
     public enum Face
     {   Ace = 0,
         King = 1,  
         Queen = 2,
         Jack = 3,        
         Ten = 4,
         Nine = 5,
         Eight = 6,
         Seven = 7,
         Six = 8

     }
   
    public enum Back
    {
        XX 
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
    public class Card : Button
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>        
        public Face face;
        public Suit suit;
        public Back back;       
        public bool showback;
        private Form form;

        // public PictureBox pictureBox;

        public Card(Face face, Suit suit, Back back, bool showback, string image)
        {
            // This call is required by the Windows.Forms Form Designer.

            this.face = face;
            this.suit = suit;
            this.back = back;
            this.showback = showback;
            // pictureBox = new PictureBox();
            this.Image = Image.FromFile(image);
            this.Invalidate();
        }

        public Card(int face, Suit suit, Back back, bool showback)
        {


            this.face = (Face) face;
            this.suit = suit;
            this.back = back;
            this.showback = showback;

            // CardDraw(103, 547);

            this.Invalidate();

        }

        public Card(Form form)
        {
            this.form = form;
        }

        public System.Windows.Forms.Button CardDraw(int horizotal, int vertical)
        {
            // Set Button properties  
            
            this.Location = new Point(horizotal, vertical);
            this.Text = this.face.ToString();

            this.TextImageRelation = TextImageRelation.TextAboveImage;
            this.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            if (this.suit == Suit.Hearts)
            this.Image = Image.FromFile(@"..\..\images\heart.jpg");

           return this;
        }
    }
}
    