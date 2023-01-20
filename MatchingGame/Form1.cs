using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatchingGame
{
    public partial class Form1 : Form
    {
        Random random = new Random();

        List<string> icons = new List<string>()
         { 
        "!", "!", "N", "N", ",", ",", "k", "k",
        "b", "b", "v", "v", "w", "w", "z", "z"
            };

        Label firstClicked = null;

             
        Label secondClicked = null;
    public Form1()
        {
            InitializeComponent();


            AssignIconsToSquares(); 
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
            if (timer1.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
                
                if (clickedLabel.ForeColor == Color.Black)
                    return;

                
                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }

                // If the player gets this far, the timer isn't
                // running and firstClicked isn't null,
                // so this must be the second icon the player clicked
                // Set its color to black
                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;

                CheckForWinner();

                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }
                // If the player gets this far, the player 
                // clicked two different icons, so start the 
                // timer (which will wait three quarters of 
                // a second, and then hide the icons)
                timer1.Start();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void AssignIconsToSquares()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    int randomNumber = random.Next(icons.Count);
                    iconLabel.Text = icons[randomNumber];
                    iconLabel.ForeColor = iconLabel.BackColor;
                    icons.RemoveAt(randomNumber);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            timer1.Stop();

            
            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;

           
            firstClicked = null;
            secondClicked = null;
        }
        private void CheckForWinner()
        {
            // Go through all of the labels in the TableLayoutPanel, 
            // checking each one to see if its icon is matched
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;

                if (iconLabel != null)
                {
                    if (iconLabel.ForeColor == iconLabel.BackColor)
                        return;
                }
            }

            // If the loop didn’t return, it didn't find
            // any unmatched icons
            // That means the user won. Show a message and close the form
            MessageBox.Show("You matched all the icons!", "Congratulations");
            Close();
        }

        private void новаяИграToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void изменитьЦветФонаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void изменитьЦветФонаToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Random rnd = new Random(DateTime.Now.Millisecond);
            menuStrip1.BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void главнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
