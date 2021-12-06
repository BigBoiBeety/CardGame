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

        public static Random rnd = new Random();
        Card[] hand = new Card[5];

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreateDeck_Click(object sender, EventArgs e)
        {
            DrawCards();
            DisplayCards();
        }

        void DrawCards()
        {
            for (int i = 0; i < hand.Length; i++)
            {
                bool loop = true;
                while(loop)
                {
                    Card tempcard = new Card(rnd);
                    bool ifInDeck = false;
                    foreach (Card card in hand)
                    {
                        if (card == null)
                        {
                            continue;
                        }
                        else if (card.ImagePath == tempcard.ImagePath)
                        {
                            ifInDeck = true;
                        }
                    }
                    if (ifInDeck == false)
                    {
                        hand[i] = tempcard;
                        loop = false;
                    }
                }
            }
        }

        void DisplayCards()
        {
            pbCardDisplay0.Image = Image.FromFile(hand[0].ImagePath);
            pbCardDisplay1.Image = Image.FromFile(hand[1].ImagePath);
            pbCardDisplay2.Image = Image.FromFile(hand[2].ImagePath);
            pbCardDisplay3.Image = Image.FromFile(hand[3].ImagePath);
            pbCardDisplay4.Image = Image.FromFile(hand[4].ImagePath);
        }
    }
}
