using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(textBox2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(textBox3.Text);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox2.Items.Remove(textBox4.Text);

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
private void button5_Click(object sender, EventArgs e)
        {

        listBox1.Sorted = true; 
        
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox2.Sorted = true;

        }

        private void button7_Click(object sender, EventArgs e)
        {
        }
    }
}
