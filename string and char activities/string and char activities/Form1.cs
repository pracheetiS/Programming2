using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace string_and_char_activities
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("1. Baker, Joe D : 1975");
            listBox1.Items.Add("2. Lovelace, migeleeto : 1970");
            listBox1.Items.Add("3. Leah, Princess P. : 2000");
            listBox1.Items.Add("4. BROTHERS, MARIO A : 1995");
            listBox1.Items.Add("5. brothers, Luigi  G : 1994");
            listBox1.Items.Add("6. Klaus, Sandy C : 1980");
            listBox1.Items.Add("7. Showers, April : 2003");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("1. Joe, 919-456-7493, joeDBake");
            listBox1.Items.Add("2. migeleeto, 919-556-2340, migLove");
            listBox1.Items.Add("3. Princess, 333-333-3333, PriPLeah");
            listBox1.Items.Add("4. MARIO, 919-067-9080, marABrot");
            listBox1.Items.Add("5. Luigi, 567-432-4337, luiGBrot");
            listBox1.Items.Add("6. Sandy, 954-034-7889, sanCKlau");
            listBox1.Items.Add("7. April, 777-777-7777, apriShow");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("1. 789grdK");
            listBox1.Items.Add("2. 009yyh7");
            listBox1.Items.Add("3. 333booP");
            listBox1.Items.Add("4. 345hjyV");
            listBox1.Items.Add("5. 800bbnB");
            listBox1.Items.Add("6. 222polS");
            listBox1.Items.Add("7. 501sseS");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt64(textBox1.Text);


                MessageBox.Show("Calling " + textBox1.Text + " ...");
            }
            catch {
                MessageBox.Show("Ivalid. Enter number in format ##########");
                textBox1.Text = "";
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Personnel Directory program");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
