using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterMind
{
    public partial class Form1 : Form
    {
        int answer = 1234;
        int guess = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string numIntered = num1.Text + num2.Text + num3.Text + num4.Text;
            if (num1.Text == "1" && num2.Text == "2" && num3.Text == "3" && num4.Text == "4")
            {
                guess++;
                lstBox.Items.Add("Guesses: " + guess);
                lstBox.Items.Add("PIN: " + numIntered);
                lstBox.Items.Add("CORRECT");
                lstBox.Items.Add("------------------------");
            }
            else {
                guess++;
                lstBox.Items.Add("Guesses: " + guess);
                lstBox.Items.Add("PIN: " + numIntered);
                lstBox.Items.Add("INCORRECT");
                lstBox.Items.Add("------------------------");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The number 3 is in the second position from the right");
            lstBox.Items.Add("Opened Clue 1");
            lstBox.Items.Add("------------------------");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The number 1 is used somewhere");
            lstBox.Items.Add("Opened Clue 2");
            lstBox.Items.Add("------------------------");

        }
    }
}
