using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wordMaker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text;
            List<string> phrase = new List<string>(input.Split());
            
            for (int i = 0; i < phrase.Count(); i++) {
                string hi = phrase[i];
                lstWords.Items.Add(hi);
            }
            

        }
    }
}
