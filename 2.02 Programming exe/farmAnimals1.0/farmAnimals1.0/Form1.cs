using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace farmAnimals1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSound_Click(object sender, EventArgs e)
        {
            if (cmb1.Text == "Cow")
            {
                Cow myAnimal = new Cow();
                System.Media.SoundPlayer Cow1 = new System.Media.SoundPlayer(@"c:\cow-moo1.wav");
                Cow1.Play();
                lblDisplay.Text = myAnimal.DoThing();
            }
            if (cmb1.Text == "Pig")
            {
                Pig myAnimal = new Pig();
                System.Media.SoundPlayer Pig1 = new System.Media.SoundPlayer(@"c:\pig.wav");
                Pig1.Play();
                lblDisplay.Text = myAnimal.DoThing();
            }
            if (cmb1.Text == "Rooster")
            {
                Rooster myAnimal = new Rooster();
                System.Media.SoundPlayer Rooster1 = new System.Media.SoundPlayer(@"c:\rooster.wav");
                Rooster1.Play();
               
                lblDisplay.Text = myAnimal.DoThing();
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
