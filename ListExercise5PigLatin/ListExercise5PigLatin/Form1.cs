using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListExercise5PigLatin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            string enteredString = txtEntered.Text;
            
            if (enteredString.Length < 2)
            {
                MessageBox.Show("Please enter at least 2 or more characters");
                return;
            }
            
        }

        private void btnPigLatin_Click(object sender, EventArgs e)
        {
            string word;
            string first;
            string rest;
            string full;
            word = txtEntered.Text;
            first = word.Substring(0, 1);
            rest = word.Substring(1, word.Length - 1);
            full = rest + first + "ay";
            lblTranformed.Text = full;

        }
    }
}
