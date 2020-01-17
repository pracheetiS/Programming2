using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrabbleGame
{
    public partial class frmGrabble : Form
    {
        public frmGrabble()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Grabble" + "\n Version 1.0.0.0" + "\n Senior Project 2020" + "\n Green Hope High" + "\n" + "\n This program was created by Rich Bennett from Western High School for his 2012 Graduation Project.");
        }

        private void howToPlayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The goal of Grabble is to get as many points as possible by making words. Words can be horizontal or vertical, but cannot be diagonal or backwards." + "\n" + "\n Upon clicking the 'Go' button, you will be given a letter. This letter should be placed into the grid by clicking in an empty grid space. If the letter is not placed before the timer reaches 0, it will be randomly placed into an empty grid slot. The game ends when all of the grid spaces are full, and then you will see your score." + "\n" + "\n A list of the words that you created will be displayed along with your score. You can double click on any word to view the definition. You can only view the definition of a word if you have internet access." + "\n" + "\n It is recommended that you alter the settings, as not everyone will like the default settings. Some settings such as 'Grid Size' and 'Difficulty' cannot be changed during a game. Other settings such as 'Animation Speed' and  'Theme' are not as crucial to gameplay, and can be changed any time. All settings saved and will be the same the next time you load up the game.");
        }

        private void btnToggleMusic_Click(object sender, EventArgs e)
        {
            btnToggleMusic.Text = "Music Off";
        }
    }
}
