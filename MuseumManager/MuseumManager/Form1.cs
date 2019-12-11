using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuseumManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (txtInput.Text == "Mona Lisa")
            {
                picArt.Image = Properties.Resources._687px_Mona_Lisa__by_Leonardo_da_Vinci__from_C2RMF_retouched;
                lblName.Text = "Mona Lisa";
                lblNameDate.Text = "Leonardo da Vinci, 1503";
            }
            else if (txtInput.Text == "The Scream")
            {
                picArt.Image = Properties.Resources._24_the_scream_edvard_munch;
                lblName.Text = "The Scream";
                lblNameDate.Text = "Edvard Munch, 1893";
            }
            else if (txtInput.Text == "The Son of Man")
            {
                picArt.Image = Properties.Resources.The_Son_of_Man__1964;
                lblName.Text = "The Son of Man";
                lblNameDate.Text = "Rene Magritte, 1964";
            }
            else
            {
                lblNameDate.Text = "Enter a valid option.";
            }
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mona Lisa, The Scream, and The Son of a Man");
        }
    }
}
