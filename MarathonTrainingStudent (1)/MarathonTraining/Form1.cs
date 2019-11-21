using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MarathonTraining
{
    public partial class Form1 : Form
    {
        double[,] mileage;
        double[] kevin;
        double[] roberto;
        double[] thomas;
        //left off at 19 min mark
        public Form1()
        {
            InitializeComponent();
            mileage = new double[3, 7];
            kevin = new double[7];
            roberto = new double[7];
            thomas = new double[7];
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if(lstRunners.Text == "Roberto")
            {
                try
                {
                    roberto[0] = Convert.ToInt32(txtMon.Text);
                    roberto[1] = Convert.ToInt32(txtTues.Text);
                    roberto[2] = Convert.ToInt32(txtWed.Text);
                    roberto[3] = Convert.ToInt32(txtThu.Text);
                    roberto[4] = Convert.ToInt32(txtFri.Text);
                    roberto[5] = Convert.ToInt32(txtSat.Text);
                    roberto[6] = Convert.ToInt32(txtSun.Text);
                    mileage[0, 0] = Convert.ToInt32(txtMon.Text);
                    mileage[0, 1] = Convert.ToInt32(txtTues.Text);
                    mileage[0, 2] = Convert.ToInt32(txtWed.Text);
                    mileage[0, 3] = Convert.ToInt32(txtThu.Text);
                    mileage[0, 4] = Convert.ToInt32(txtFri.Text);
                    mileage[0, 5] = Convert.ToInt32(txtSat.Text);
                    mileage[0, 6] = Convert.ToInt32(txtSun.Text);
                }
                catch
                {
                    MessageBox.Show("You must enter numbers for each day to calculate.");
                }
                txtMon.Text = " ";
            }
            if (lstRunners.Text == "Kevin")
            {
                try
                {
                    roberto[0] = Convert.ToInt32(txtMon.Text);
                    roberto[1] = Convert.ToInt32(txtTues.Text);
                    roberto[2] = Convert.ToInt32(txtWed.Text);
                    roberto[3] = Convert.ToInt32(txtThu.Text);
                    roberto[4] = Convert.ToInt32(txtFri.Text);
                    roberto[5] = Convert.ToInt32(txtSat.Text);
                    roberto[6] = Convert.ToInt32(txtSun.Text);
                    mileage[0, 0] = Convert.ToInt32(txtMon.Text);
                    mileage[0, 1] = Convert.ToInt32(txtTues.Text);
                    mileage[0, 2] = Convert.ToInt32(txtWed.Text);
                    mileage[0, 3] = Convert.ToInt32(txtThu.Text);
                    mileage[0, 4] = Convert.ToInt32(txtFri.Text);
                    mileage[0, 5] = Convert.ToInt32(txtSat.Text);
                    mileage[0, 6] = Convert.ToInt32(txtSun.Text);
                }
                catch
                {
                    MessageBox.Show("You must enter numbers for each day to calculate.");
                }
            }
            if (lstRunners.Text == "Thomas")
            {
                try
                {
                    roberto[0] = Convert.ToInt32(txtMon.Text);
                    roberto[1] = Convert.ToInt32(txtTues.Text);
                    roberto[2] = Convert.ToInt32(txtWed.Text);
                    roberto[3] = Convert.ToInt32(txtThu.Text);
                    roberto[4] = Convert.ToInt32(txtFri.Text);
                    roberto[5] = Convert.ToInt32(txtSat.Text);
                    roberto[6] = Convert.ToInt32(txtSun.Text);
                    mileage[0, 0] = Convert.ToInt32(txtMon.Text);
                    mileage[0, 1] = Convert.ToInt32(txtTues.Text);
                    mileage[0, 2] = Convert.ToInt32(txtWed.Text);
                    mileage[0, 3] = Convert.ToInt32(txtThu.Text);
                    mileage[0, 4] = Convert.ToInt32(txtFri.Text);
                    mileage[0, 5] = Convert.ToInt32(txtSat.Text);
                    mileage[0, 6] = Convert.ToInt32(txtSun.Text);
                }
                catch
                {
                    MessageBox.Show("You must enter numbers for each day to calculate.");
                }
            }
            if (lstRunners.Text == "Roberto") 
            {
                lblIndivTotal.Text = GetTotal(roberto).ToString();
                lblIndivAvg.Text = GetTotal(roberto).ToString();
            }
            if (lstRunners.Text == "Kevin") 
            {
                lblIndivTotal.Text = GetTotal(kevin).ToString();
                lblIndivAvg.Text = GetTotal(kevin).ToString();
            }
            if (lstRunners.Text == "Thomas") 
            {
                lblIndivTotal.Text = GetTotal(thomas).ToString();
                lblIndivAvg.Text = GetTotal(thomas).ToString();
            }
        }

        public double GetTotal(double[] intArray)
        {
            double total = 0;
            for(int i = 0; i < intArray.Length; i++)
            {
                total += intArray[i];
            }
            return total;
        }

        public double GetTotal(double[ , ] teamArray)
        {
            double total = 0;
            for (int i = 0; i < teamArray.GetLength(0); i++)
            {
                for (int j = 0; j < teamArray.GetLength(1); j++)
                {
                    total += teamArray[i,j];
                }                   
            }
            return total;
        }

        public double GetAverage(double[] intArray)
        {
            double total = 0;
            double average = 0;
            for (int i = 0; i < intArray.Length; i++)
            {
                total += intArray[i];
            }
            average = total / 7;
            return average;
        }

        public double GetAverage(double[ , ] teamArray)
        {
            double total = 0;
            double average = 0;
            for (int i = 0; i < teamArray.GetLength(0); i++)
            {
                for (int j = 0; j < teamArray.GetLength(1); j++)
                {
                    total += teamArray[i, j];
                }
            }
            average = total / 7;
            return average;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblTeamTotal.Text = GetTotal(mileage).ToString();
            lblTeamAvg.Text = GetAverage(mileage).ToString();
        }
    }
}
