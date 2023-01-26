using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Map
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelDrinks_Click(object sender, EventArgs e)
        {

        }

        private void labelBars_Click(object sender, EventArgs e)
        {

        }

        private void labelToilets_Click(object sender, EventArgs e)
        {

        }

        private void labelInformation_Click(object sender, EventArgs e)
        {

        }

        private void labelMedicial_Click(object sender, EventArgs e)
        {

        }

        private void map_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            tableLayoutPanel1.Visible = true;
            pictureBoxToilets.Visible = false; labelToilets.Visible = false;
            pictureBoxInfo.Visible = false; labelInformation.Visible = false;
            pictureBoxMeds.Visible = false; labelMedicial.Visible = false;
            namePlace.Visible = true;
            namePlace.Text = "МЦК Лужники";
        }

        private void startButton1_Click(object sender, EventArgs e)
        {
            namePlace.Text = "Старт МЦК Лужники";
            tableLayoutPanel1.Visible = false;

        }

        private void pictureBoxDrinks_Click(object sender, EventArgs e)
        {

        }

        private void buttonTwo_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Visible = true;
            namePlace.Visible = true;

            namePlace.Text = "Новодевичий\n" +
                "монастырь";
          
        }

        private void buttonThree_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Visible = true;
            pictureBoxToilets.Visible = true; labelToilets.Visible = true;
            pictureBoxInfo.Visible = false; labelInformation.Visible = false;
            pictureBoxMeds.Visible = false; labelMedicial.Visible = false;
            namePlace.Visible = true;
            namePlace.Text = "Метро Киевская";
                
        }

        private void buttonFour_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Visible = true;
            pictureBoxInfo.Image = Image.FromFile("C:\\Users\\student\\Desktop\\Интерактивная карта\\map-icon-medical.png");
            pictureBoxMeds.Visible = false; labelMedicial.Visible = false;
            namePlace.Text = "МИД";
            labelInformation.Text = "Медицинский пункт";



        }

        private void buttonFive_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Visible = true;
            pictureBoxMeds.Visible = false; labelMedicial.Visible = false;
            namePlace.Visible = true;
            namePlace.Text = "Парк Горького";
        }

        private void buttonSix_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Visible = true;
            pictureBoxToilets.Visible = true; labelToilets.Visible = true;
            pictureBoxInfo.Visible = false; labelInformation.Visible = false;
            pictureBoxMeds.Visible = false; labelMedicial.Visible = false;
            namePlace.Visible = true;
            namePlace.Text = "Здание РАН";
        }

        private void buttonSeven_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Visible = true;
            namePlace.Text = "Метро Воробьевы горы"; 
        }

        private void buttonEight_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Visible = true;
            namePlace.Text = "Стадион Лужники";
        }

        private void buttonFinish_Click(object sender, EventArgs e)
        {

        }

        private void buttonStartTwo_Click(object sender, EventArgs e)
        {
            namePlace.Text = "Старт Парк Горького";
            tableLayoutPanel1.Visible = false;
        }

        private void startButtonThree_Click(object sender, EventArgs e)
        {
            namePlace.Text = "Старт Аллея славы Лужники";
            tableLayoutPanel1.Visible = false;
        }
    }
}
