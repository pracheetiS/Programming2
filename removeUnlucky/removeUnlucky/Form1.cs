using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace removeUnlucky
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        int[] arr = new int[10];
        
        Random rnd = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(1, 101);
            }

            for (int i = 0; i < arr.Length; i++) {
                label1.Text += "\n" + arr[i].ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            List<int> numbers = new List<int>(arr);
            try
            {
                label1.Text = "";
                int input = Convert.ToInt32(textBox1.Text);
                numbers.Remove(input);
                for (int i = 0; i < numbers.Count(); i++)
                {
                    int hi = numbers[i];
                    label1.Text += "\n" + numbers[i].ToString();
                }
            }
            catch {
                MessageBox.Show("Invalid input");
            }
            
        }
    }
}
