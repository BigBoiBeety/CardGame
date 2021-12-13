using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardGame
{
    public partial class Form1 : Form
    {
        public PictureBox[] pictureBoxArray = new PictureBox[5];

        public static Random rnd = new Random();
        Card[] deck = new Card[52];
        Card[] hand = new Card[5];
        int currentDeckIndex = -1;

        public Form1()
        {
            InitializeComponent();

            pictureBoxArray[0] = pbCardDisplay0;
            pictureBoxArray[1] = pbCardDisplay1;
            pictureBoxArray[2] = pbCardDisplay2;
            pictureBoxArray[3] = pbCardDisplay3;
            pictureBoxArray[4] = pbCardDisplay4;
        }

        private void btnCreateDeck_Click(object sender, EventArgs e)
        {
            CreateDeck();
            ShuffleDeck();
            CreateHand();
            DisplayCards();
        }

        Card DrawCard()
        {
            //TODO: What if shuffle cards and pick the same one from shuffled deck
            
            currentDeckIndex += 1;
            if (currentDeckIndex == deck.Length)
            {
                ShuffleDeck();
                currentDeckIndex = 0;
            }

            return deck[currentDeckIndex];
        }

        void CreateHand()
        {
            for (int i = 0; i < hand.Length; i++)
            {
                hand[i] = DrawCard();
            }
        }

        void CreateDeck()
        {
            for (int i = 0; i < deck.Length; i++)
            {
                int number = i % 13;
                int suitIndex = i / 13;
                deck[i] = new Card(number, suitIndex);
            }
        }

        void ShuffleDeck()
        {
            deck = deck.OrderBy(x => rnd.Next()).ToArray();
        }

        void DisplayCards()
        {
            for (int i = 0; i < 5; i++)
            {
                pictureBoxArray[i].Image = Image.FromFile(hand[i].ImagePath);
            }
        }
    }
}
