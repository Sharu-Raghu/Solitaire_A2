using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card1
{
    public class Cards
    {
        public Card cardDiamondAce;
        public Card cardDiamondSix;
        public Card cardDiamondSeven;
        //public Card cardDiamondAce
        //public Card cardDiamondAce
        //public Card cardDiamondAce
        //public Card cardDiamondAce
        //public Card cardDiamondAce
        //public Card cardDiamondAce
        //public Card cardDiamondAce
        //public Card cardDiamondAce
        //public Card cardDiamondAce
        //public Card cardDiamondAce

        public Cards()
        {
            Card cardDiamondAce = new Card(Face.Ace, Suit.Diamonds, Back.XX, true, @"C:\Temp\Solitaire_assignment2\Solitaire\Card1\Resources\Decks\Classic\DA.png");
            Card cardDiamondSix = new Card(Face.Six, Suit.Diamonds, Back.XX, true, @"C:\Temp\Solitaire_assignment2\Solitaire\Card1\Resources\Decks\Classic\D6.png");
            Card cardDiamondSeven = new Card(Face.Seven, Suit.Diamonds, Back.XX, true, @"C:\Temp\Solitaire_assignment2\Solitaire\Card1\Resources\Decks\Classic\D7.png");
            //Card cardDiamondAce = new Card();
            //Card cardDiamondAce = new Card();
            //Card cardDiamondAce = new Card();
            //Card cardDiamondAce = new Card();
            //Card cardDiamondAce = new Card();
            //Card cardDiamondAce = new Card();
            //Card cardDiamondAce = new Card();
            //Card cardDiamondAce = new Card();
            //Card cardDiamondAce = new Card();
            //Card cardDiamondAce = new Card();
        }

        public Card GetRandomCard()
        {
            Random randomFace = new Random();
            Face CardFace = (Face)randomFace.Next(6, 14);

            Random randomSuit = new Random();
            Suit CardSuit = (Suit)randomSuit.Next(0, 3);


            Card cardDiamondAce = new Card(Face.Ace, Suit.Diamonds, Back.XX, true, @"C:\Temp\Solitaire_assignment2\Solitaire\Card1\Resources\Decks\Classic\DA.PNG");
            return cardDiamondAce;
            //case (CardSuit)
            //{

            //}

            switch (CardSuit)
            {             
                case Suit.Diamonds:
                    switch (CardFace)
                    {
                        case Face.Ace:
                            return cardDiamondAce;
                        //case Face.Eight:
                        //    return cardDiamondEight;

                    }
                    break;
                case Suit.Clubs:
                    Console.WriteLine("Case 2");
                    break;
                case Suit.Hearts:
                case Suit.Spades:
                default:
                    Console.WriteLine("Default case");
                    break;                
            }

        }

    }
}
