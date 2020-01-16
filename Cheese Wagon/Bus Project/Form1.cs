using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bus_Project
{
    public partial class Form1 : Form
    {
        int bus = 45;
        int van = 15 ;
        int car = 4;
        int buses;
        int vans;
        int cars;
        int students;
        int studentbus;
        int studentvan;
        int studentcar;
        string studentbustxt;
        string studentvantxt;
        string studentcartxt;
        double gasprice = 2.45;
        double tripdistance = 8000;

        public Form1()
        {
            InitializeComponent();
           
        }

        private void btnCalcNum_Click(object sender, EventArgs e)
        {

             students = Convert.ToInt32(txtInput.Text);
         
                studentbus = students % bus;
                
                studentbustxt = Convert.ToString(studentbus);
                lblCW.Text = studentbustxt;


                studentvan = studentbus % van;
                
                studentvantxt = Convert.ToString(studentvan);
                lblSB.Text = studentvantxt;

          
                studentcar = studentvan % car;
                
                studentcartxt = Convert.ToString(studentcar);
                lblCars.Text = studentcartxt;
            
        }

        private void btnLastCar_Click(object sender, EventArgs e)
        {
          int  leftovers = Convert.ToInt32(studentcartxt) * 4;
            string leftoverstxt = Convert.ToString(leftovers);

            lblLeftOvers.Text = leftoverstxt;
        }

        private void btnSetMiles_Click(object sender, EventArgs e)
        {

        }

        public void btnSetGas_Click(object sender, EventArgs e)
        {
            
        }

        private void btnTripCost_Click(object sender, EventArgs e)
        {
            double studentcost = gasprice * students;
            string studentcosttxt = Convert.ToString(studentcost);
            lblTotCost.Text = studentcosttxt;
        }

        private void btnMileCost_Click(object sender, EventArgs e)
        {

        }
    }
}
