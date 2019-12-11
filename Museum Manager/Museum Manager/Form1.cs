using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Museum_Manager
{
    public partial class Form1 : Form
    {
        List<string> art = new List<string>();
        variables myVar = new variables();

        public Form1()
        {
            InitializeComponent();
            btnAdd.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
                



        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            

            if (textBox1.Text != null && textBox3.Text != null && textBox2.Text != null)
            {
                btnAdd.Visible = true;
            }

            if (textBox1.Text == "The Scream" && textBox2.Text == "Edvard Munch" && textBox3.Text == "1880") {
                pictureBox1.BackgroundImage = Properties.Resources._71EN_iJBUnL__SX466_;
                myVar.pic1 = 1;
            }

            if (textBox1.Text == "Mona Lisa" && textBox2.Text == "Da Vinci" && textBox3.Text == "1589")
            {
                pictureBox1.BackgroundImage = Properties.Resources.Mona_Lisa_oil_wood_panel_Leonardo_da;
                myVar.pic2 = 1;
            }

            if (textBox1.Text == "Starry Night" && textBox2.Text == "Van Gogh" && textBox3.Text == "1885")
            {
                pictureBox1.BackgroundImage = Properties.Resources.Starry_Night_canvas_Vincent_van_Gogh_New_1889;
                myVar.pic3 = 1;
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            artwork myArtwork = new artwork(textBox1.Text, textBox2.Text, textBox3.Text);
            art.Add(textBox1.Text);
            art.Add(textBox2.Text);
            art.Add(textBox3.Text);
            MessageBox.Show("Added!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            library myLib = new library();
            myLib.Show();
        }
    }
}
