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
    public partial class library : Form
    {
        int inventory = 0;
        public library()
        {
            InitializeComponent();
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (inventory == 0) {
                label2.Text = "The Scream";
                label4.Text = "Edvard Munch";
                label6.Text = "1880";
                pictureBox1.BackgroundImage = Properties.Resources._71EN_iJBUnL__SX466_;
                inventory += 1;
                button2.Enabled = true;
                button1.Enabled = true;
            }

            else if (inventory == 1)
            {
                label2.Text = "Mona Lisa";
                label4.Text = "Da Vinci";
                label6.Text = "1589";
                pictureBox1.BackgroundImage = Properties.Resources.Mona_Lisa_oil_wood_panel_Leonardo_da;
                inventory += 1;
                button2.Enabled = true;
                button1.Enabled = true;

            }

            else if (inventory == 2)
            {
                label2.Text = "Starry Night";
                label4.Text = "Van Gogh";
                label6.Text = "1889";
                pictureBox1.BackgroundImage = Properties.Resources.Starry_Night_canvas_Vincent_van_Gogh_New_1889;
                
                button2.Enabled = false;
                button1.Enabled = true;

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (inventory == 0)
            {
                
            }

            else if (inventory == 1)
            {
                label2.Text = "The Scream";
                label4.Text = "Edvard Munch";
                label6.Text = "1880";
                pictureBox1.BackgroundImage = Properties.Resources._71EN_iJBUnL__SX466_;
                //inventory += 1;
                button1.Enabled = false;
                button2.Enabled = true;

            }

            else if (inventory == 2)
            {
                label2.Text = "Mona Lisa";
                label4.Text = "Da Vinci";
                label6.Text = "1589";
                pictureBox1.BackgroundImage = Properties.Resources.Mona_Lisa_oil_wood_panel_Leonardo_da;
                inventory -= 1;
                button1.Enabled = true;
                button2.Enabled = true;

            }
        }
    }
}
