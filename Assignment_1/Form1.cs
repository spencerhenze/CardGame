using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_1
{
    public partial class Form1 : Form
    {
        //Spencer Henze
        //8/31/16

        public Form1()
        {
            //This code starts up the form component.
            InitializeComponent();
        }

        private void cardPicture1_Click(object sender, EventArgs e)
        {
            //When the first card is clicked, this displays the text "Three of Diamonds" in the display box label.
            descriptionBox.Text = "Three of Diamonds";
        }

        private void cardPicture2_Click(object sender, EventArgs e)
        {
            //When the second card is clicked, this displays the text "King of Clubs" in the display box label.
            descriptionBox.Text = "King of Clubs";
        }

        private void cardPicture3_Click(object sender, EventArgs e)
        {
            //When the third card is clicked, this displays the text "Eight of Hearts" in the display box label.
            descriptionBox.Text = "Eight of Hearts";
        }

        private void cardPicture4_Click(object sender, EventArgs e)
        {
            //When the fourth card is clicked, this displays the text "Ace of Spades" in the display box label.
            descriptionBox.Text = "Ace of Spades";
        }

        private void cardPicture5_Click(object sender, EventArgs e)
        {
            //When the fifth card is clicked, this displays the text "Jack of Hearts" in the display box label.
            descriptionBox.Text = "Jack of Hearts";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //This code exits the application when the "Exit" button is clicked.
            Application.Exit();
        }
    }
}
