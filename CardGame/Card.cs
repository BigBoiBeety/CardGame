using System;
using System.Collections.Generic;
using System.IO;
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

        public Card(int number, int suitIndex)
        {
            this.number = number;
            suit = suitArray[suitIndex];
            imagePath = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\") + @"\CardGame\Resources\" + suit + @"\" + number.ToString() + ".png");

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
        }
    }
}
