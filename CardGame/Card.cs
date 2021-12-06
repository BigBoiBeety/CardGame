using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    class Card
    {
        private int number;
        private string suit;
        private string imagePath;
        private string[] suitArray = new string[] { "hearts", "spades", "diamonds", "clubs" };

        public Card(Random rnd)
        {
            number = rnd.Next(13);
            suit = suitArray[rnd.Next(0, 4)];
            imagePath = @"C:\Users\lewis\Source\Repos\CardGame\CardGame\Resources\" + suit + @"\" + number.ToString() + ".png";
        }

        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        public string Suit
        {
            get { return suit; }
            set { suit = value; }
        }

        public string ImagePath
        {
            get { return imagePath; }
            set { imagePath = value; }
        }
    }
}
